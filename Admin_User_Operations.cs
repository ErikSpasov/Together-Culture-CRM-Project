using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGui
{
    public partial class Admin_User_Operations : Form
    {
        private int userID;
       
        // Connection string -> eDBConn.
        Admin_Action_Logger aAl = Admin_Action_Logger.Instance;
        ProjectDBConnection eDBConn = ProjectDBConnection.getInstanceOfProjectDBConnection();
        
        public Admin_User_Operations(int userID)
        {
            InitializeComponent();
            initListView();
            initDropDown();
            LoadItems(eDBConn.getDataSet(Constants.GET_DETAILS_USER_OPERATIONS));
            this.userID = userID;
            LoadChart(Constants.GLOBAL_USER_INTERESTS);


        }

        private void btApplyFilter_Click(object sender, EventArgs e)
        {
            string filterBy = cbFilter.Text;
           
            switch (filterBy)
            {
                case "ALL" :

                    
                    LoadItems(eDBConn.getDataSet(Constants.GET_DETAILS_USER_OPERATIONS));
                    LoadChart(Constants.GLOBAL_USER_INTERESTS);

                    break;

                case "Creative Workspace":

                    LoadItems(eDBConn.getDataSet(Constants.GET_DETAILS_USER_OPERATIONS + " WHERE Users.Membership_Type = 'Workspace Member'"));
                    LoadChart(Constants.FILTERS_USER_INTERESTS + " WHERE Users.Membership_Type = 'Workspace Member'");

                    break;

                case "Community Member":

                    LoadItems(eDBConn.getDataSet(Constants.GET_DETAILS_USER_OPERATIONS + " WHERE Users.Membership_Type = 'Community Member'"));
                    LoadChart(Constants.FILTERS_USER_INTERESTS + " WHERE Users.Membership_Type = 'Community Member'");

                    break;

                case "Member":

                    LoadItems(eDBConn.getDataSet(Constants.GET_DETAILS_USER_OPERATIONS + " WHERE Users.User_Type = 'member'"));
                    LoadChart(Constants.FILTERS_USER_INTERESTS + " WHERE Users.User_Type = 'member'");
                    break;

                case "Admin":

                    LoadItems(eDBConn.getDataSet(Constants.GET_DETAILS_USER_OPERATIONS + " WHERE Users.User_Type = 'admin'"));
                    LoadChart(Constants.FILTERS_USER_INTERESTS + " WHERE Users.User_Type = 'admin'");
                    break;

                case "New Users - 2 Weeks":

                    DateTime dtPast = DateTime.Now.AddDays(-14); //Current date minus 2 weeks.
                    string sPast = dtPast.ToString("yyyy-MM-dd");
                    LoadItems(eDBConn.getDataSet(Constants.GET_DETAILS_USER_OPERATIONS + " WHERE Users.Date_Joined >= " + "'" + sPast + "'"));
                    LoadChart(Constants.FILTERS_USER_INTERESTS + " WHERE Users.Date_Joined >= " + "'" + sPast + "'");
                    break;

                case "Unapproved Users":

                    LoadItems(eDBConn.getDataSet(Constants.GET_DETAILS_USER_OPERATIONS + " WHERE Users.Is_Approved = 'False'"));
                    LoadChart(Constants.FILTERS_USER_INTERESTS + " WHERE Users.Is_Approved = 'False'");
                    break;

                case "Guests":

                    LoadItems(eDBConn.getDataSet(Constants.GET_DETAILS_USER_OPERATIONS + " WHERE Users.User_Type = 'guest'"));
                    LoadChart(Constants.FILTERS_USER_INTERESTS + " WHERE Users.User_Type = 'guest'");
                    break;

                default:

                    break;

            }

        }

        private void btOpenUserDeatails_Click(object sender, EventArgs e)
        {
            if (userID > 0) // Make sure userId has a valid value
            {
                try
                {
                    Admin_User_Overview cWD = new Admin_User_Overview(lvAUO.SelectedItems[0].SubItems[0].Text, userID);

                    // Show the Admin_User_Overview form
                    cWD.Show();
                }
                catch(System.ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Please select a record from the table.", "No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User ID is not set. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }





        private void initDropDown()
        {
            cbFilter.Items.Clear();
            cbFilter.Items.Add("ALL");
            cbFilter.Items.Add("Creative Workspace");
            cbFilter.Items.Add("Community Member");
            cbFilter.Items.Add("Member");
            cbFilter.Items.Add("Admin");
            cbFilter.Items.Add("New Users - 2 Weeks");
            cbFilter.Items.Add("Unapproved Users");
            cbFilter.Items.Add("Guests");

        }

        private void initListView()
        {
            /*
            +---------+------------+-----------+------------+-------------+-----------+-------------+----------------------+------------------+---------------+---------+-----------+-------------+
            | 0       | 1          | 2         | 3          | 4           | 5         | 6           | 7                    | 8                | 9             | 10      | 11        | 12          |
            +---------+------------+-----------+------------+-------------+-----------+-------------+----------------------+------------------+---------------+---------+-----------+-------------+
            | User_ID | First_Name | Last_Name | User_Email | Is_Approved | User_Type | Date_Joined | User_Signup_Intrests | Current_Intrests | Date_Of_Birth | Address | Phone_Num | Nationality |
            +---------+------------+-----------+------------+-------------+-----------+-------------+----------------------+------------------+---------------+---------+-----------+-------------+
            */

            lvAUO.Columns.Add("User ID", -2, HorizontalAlignment.Left);                 //0
            lvAUO.Columns.Add("First Name", -2, HorizontalAlignment.Left);              //1
            lvAUO.Columns.Add("Last Name", -2, HorizontalAlignment.Left);               //2
            lvAUO.Columns.Add("Email Address", -2, HorizontalAlignment.Left);           //3
            lvAUO.Columns.Add("Approved", -2, HorizontalAlignment.Left);                //4
            lvAUO.Columns.Add("Member Type", -2, HorizontalAlignment.Left);             //5
            lvAUO.Columns.Add("Date Joined", -2, HorizontalAlignment.Left);             //6
            lvAUO.Columns.Add("User Signup Intrests", -2, HorizontalAlignment.Left);    //7
            lvAUO.Columns.Add("Current Intrests", -2, HorizontalAlignment.Left);        //8
            lvAUO.Columns.Add("Date Of Birth", -2, HorizontalAlignment.Left);           //9
            lvAUO.Columns.Add("Address", -2, HorizontalAlignment.Left);                 //10
            lvAUO.Columns.Add("Phone Number", -2, HorizontalAlignment.Left);            //11
            lvAUO.Columns.Add("Nationality", -2, HorizontalAlignment.Left);             //12
        }

        private void LoadItems(DataSet dataset)
        {

            Dataset_Manipulator dSM = new Dataset_Manipulator(dataset);
            ListViewItem lvItem = new ListViewItem();

            lvAUO.Items.Clear();


            for (int i = 0; i < dSM.ReturnMaxRowNum(0); i++)
            {
                lvItem = new ListViewItem(dSM.ReturnElementAsString(0, i, 0));

                for (int j = 1; j < dSM.ReturnMaxColumnNum(0); j++)
                {
                    lvItem.SubItems.Add(dSM.ReturnElementAsString(0, i, j));
                }
                lvAUO.Items.Add(lvItem);
            }
            
        }

        private void LoadChart(string query)
        {
            chartGlobalInterests.Series["Interest Distribution of selected filter"].Points.Clear();
           
            DataSet datasetInterests = eDBConn.getDataSet(query);
            Dataset_Manipulator dSMI = new Dataset_Manipulator(datasetInterests);

            DataSet datasetTags = eDBConn.getDataSet(Constants.GET_TAG_NAMES);
            Dataset_Manipulator dSMT = new Dataset_Manipulator(datasetTags);

            string[] tagNames = new string[dSMT.ReturnMaxRowNum(0)];
            int[] frequencyOfTags = new int[dSMT.ReturnMaxRowNum(0)];

            for (int i = 0; i < tagNames.Length; i++)
            {
                tagNames[i] = dSMT.ReturnElementAsString(0, i, 0);
            }

            for (int i = 0; i < dSMI.ReturnMaxRowNum(0); i++)
            {
                for (int j = 0; j < tagNames.Length; j++)
                {
                if (tagNames[j] == dSMI.ReturnElementAsString(0, i, 0))
                    {
                        frequencyOfTags[j] += 1;
                    }
                }
            }

            for (int i = 0; i < tagNames.Length; i++)
            {
                chartGlobalInterests.Series["Interest Distribution of selected filter"].Points.AddXY(tagNames[i], frequencyOfTags[i]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            aAl.Close();
            System.Windows.Forms.Application.Exit();
        }
    }
}
