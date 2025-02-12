using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGui
{
    public partial class Creative_Workspace_Events : Form
    {
        private int userId; //stores userId

        // Connection string -> eDBConn.
        ProjectDBConnection eDBConn = ProjectDBConnection.getInstanceOfProjectDBConnection();
        public Creative_Workspace_Events(int userId)
        {

            InitializeComponent();
            LoadDropDown();
            LoadItems();
            this.userId = userId;
        }

        //Inserts newly created event into EventsDB.mdf
        private void btInsert_Click(object sender, EventArgs e)
        {
            string eventName = tbEventName.Text;
            string eventDescription = tbEventDescription.Text;
            DateTime eventDateTime = dtpEventDate.Value.Date + dtpEventTime.Value.TimeOfDay; 
            string eventTag = cbEventTag.Text;


            if (string.IsNullOrEmpty(tbEventName.Text) || string.IsNullOrEmpty(tbEventDescription.Text) || string.IsNullOrEmpty(cbEventTag.Text))
            {
                MessageBox.Show("Please populate all fields.");
            }
            else
            {

                // Save to Events entity
                eDBConn.saveToEDB(Constants.INSERT_RECORD_EVENT, eventName, eventDescription, eventDateTime);

                // This part populates Event_Tags associative entity in database.
                DataSet matchedTagID = eDBConn.getDataSet(Constants.GET_TAG);
                Dataset_Manipulator gotMatchTagID = new Dataset_Manipulator(matchedTagID);
                int indexMatch = 0;

                for (int i = 0; i < gotMatchTagID.ReturnMaxRowNum(0); i++)
                {
                    if (gotMatchTagID.ReturnElementAsString(0, i, 1) == eventTag)
                    {
                        indexMatch = i;
                    }
                }

                DataSet lastEventID = eDBConn.getDataSet(Constants.GET_EVENT_ID_LAST);
                Dataset_Manipulator gotLastEventID = new Dataset_Manipulator(lastEventID);

                eDBConn.saveToETDB(Constants.INSERT_RECORD_EVENT_TAG, gotMatchTagID.ReturnElementAsInt(0, indexMatch, 0), gotLastEventID.ReturnElementAsInt(0, 0, 0));

                // Clear textboxes/datetimepickers
                tbEventName.Clear();
                tbEventDescription.Clear();
                dtpEventDate.Value = DateTime.Now;
                dtpEventTime.Value = DateTime.Now;

                //update
                LoadDropDown();
                LoadItems();
            }

        }

        // Load description for selected row.
        private void btLoadEventDescription_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet datasetEvents = eDBConn.getDataSet(Constants.EVENT_DESCRIPTION_FOR_ID, Convert.ToInt16(lvCWE.SelectedItems[0].SubItems[3].Text));
                tbLoadEventDescription.Text = datasetEvents.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
            }
            catch(System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select an event from the table.", "No Event Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            // Check if userId is initialized
            if (userId > 0) // Make sure userId has a valid value
            {
                // Pass the userId to the Online_Modules constructor
                Creative_Workspace_Dashboard cWD = new Creative_Workspace_Dashboard(userId);

                // Show the Creative_Workspace_Dashboard form
                cWD.Show();

                // Optionally hide the current form
                this.Close();
            }
            else
            {
                MessageBox.Show("User ID is not set. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btBook_Click(object sender, EventArgs e)
        {
            try
            {
                BookEvent(userId, Convert.ToInt16(lvCWE.SelectedItems[0].SubItems[3].Text));
            }
            catch(System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select an event from the table.", "No Event Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BookEvent(int userID, int eventID)
        {
            try
            {
                // SQL query to inserts booking into the Events_Attendance table
                string sqlQuery = Constants.INSERT_EVENT_ATTENDANCE;
                var parameters = new Dictionary<string, object>
                {
                    { "@Event_ID", eventID },
                    { "@User_ID", userID },
                };

                // Execute the query
                int rowsAffected = eDBConn.executeNonQuery(sqlQuery, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Booking successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Booking failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadItems()
        {

            DataSet datasetEvents = eDBConn.getDataSet(Constants.EVENT_SELECT_ID_NAME_DATETIME);

            Dataset_Manipulator dSM = new Dataset_Manipulator(datasetEvents);
            ListViewItem lvItem = new ListViewItem();
            string[] dateTime;

            lvCWE.Items.Clear();

            // I believe the objects that no longer have pointers to their memory address 
            // get their section of memory cleared by the garbage collector in c#.
            // If this is not the case memory leak here. - R
            // Loop loads and formats (datetime) items into ListView.

            for (int i = 0; i < dSM.ReturnMaxRowNum(0); i++)
            {
                lvItem = new ListViewItem(dSM.ReturnElementAsString(0, i, Constants.EVENT_NAME));
                dateTime = dSM.ReturnElementAsString(0, i, Constants.EVENT_DATETIME).Split(' ');
                lvItem.SubItems.Add(dateTime[0]);
                lvItem.SubItems.Add(dateTime[1]);
                lvItem.SubItems.Add(dSM.ReturnElementAsString(0, i, Constants.EVENT_ID));
                lvCWE.Items.Add(lvItem);
            }
        }

        public void LoadDropDown()
        {
            DataSet datasetEvents = eDBConn.getDataSet(Constants.GET_TAG_NAMES);
            Dataset_Manipulator dSM = new Dataset_Manipulator(datasetEvents);
            cbEventTag.Items.Clear();  

            for (int i = 0; i < dSM.ReturnMaxRowNum(0); i++)
            {
                cbEventTag.Items.Add(dSM.ReturnElementAsString(0,i,0));
            }

        }

        private void Creative_Workspace_Events_Load(object sender, EventArgs e)
        {

        }
    }
}
