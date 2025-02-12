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
    public partial class Creative_Workspace_Benefits : Form
    {
        ProjectDBConnection eDBConn = ProjectDBConnection.getInstanceOfProjectDBConnection();
        private int userId; //stores userId
        public Creative_Workspace_Benefits(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            InitChart();
            LoadInfo();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            // Check if userId is initialized
            if (userId > 0) // Make sure userId has a valid value
            {
                // Pass the userId to the Creative_Workspace_Dashboard constructor
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

        public void InitChart()
        {
            DataSet datasetInterests = eDBConn.getDataSet(Constants.INDIVIDUAL_USER_INTERESTS, userId);
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
                if (frequencyOfTags[i] > 0)
                {
                    chartCMB.Series["Your Interests"].Points.AddXY(tagNames[i], frequencyOfTags[i]);
                }
                
            }
        }

        public void LoadInfo()
        {
            DataSet dataset = eDBConn.getDataSet(Constants.MEMBERSHIP_DESCRIPTION_FOR_CW);
            tbInfo.Text = dataset.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
        }

        private void chartCMB_Click(object sender, EventArgs e)
        {

        }
    }
}
