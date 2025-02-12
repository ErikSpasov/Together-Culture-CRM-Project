using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGui
{
    public partial class Admin_User_Overview : Form
    {
        private string selectedUserID;
        private int userID;
        ProjectDBConnection eDBConn = ProjectDBConnection.getInstanceOfProjectDBConnection();
        Admin_Action_Logger aAL = Admin_Action_Logger.Instance;
        public Admin_User_Overview(string selectedUserID, int userID)
        {
            InitializeComponent();
            this.selectedUserID = selectedUserID;
            this.userID = userID;
            LoadUserRole();
            LoadUserRoleSelection();
            LoadUserChart();
            LoadApprovalStatus();

        }

        private void btClose_Click(object sender, EventArgs e)
        {     
                this.Close();
        }

        public void LoadUserRole()
        {
            tbCurrentUserRole.Clear();
            DataSet dataset = eDBConn.getDataSet(Constants.GET_MEMBERSHIP_NAME_FROM_ID, selectedUserID);
            tbCurrentUserRole.Text = dataset.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
        }

        private void btApplyUserRoleSelection_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dataset = eDBConn.getDataSet(Constants.GET_USER_ID_IN_USER_MEM);
                Dataset_Manipulator dSM = new Dataset_Manipulator(dataset);
                bool recordExists = false;

                // Check if User is already in User_Members.
                for (int i = 0; i < dSM.ReturnMaxRowNum(0); i++)
                {
                    if (selectedUserID == dSM.ReturnElementAsString(0, i, 0))
                    {
                        recordExists = true;
                    }
                }

                if (recordExists)
                {
                    MessageBox.Show(cbChangeUserRoleSeletion.Text);
                    string sqlQuery = Constants.CHANGE_M_ID_IN_USER_M;
                    var parameters = new Dictionary<string, object>
                    {
                        { "@Membership_ID", eDBConn.getDataSet(Constants.GET_M_ID_FROM_M_NAME, cbChangeUserRoleSeletion.Text).Tables[0].Rows[0].ItemArray.GetValue(0)}, //Will provide the correct membership ID for the selected user role in the "Change User Role To:" combo box.
                        { "@User_ID" , Convert.ToInt32(selectedUserID)},
                    };

                    InsertDB iUM = new InsertDB();
                    iUM.InsertNonQuery(sqlQuery, parameters, "Role change");



                    string sqlQueryTwo = Constants.CHANGE_MEM_TYPE_IN_USER;
                    var parametersTwo = new Dictionary<string, object>
                    {
                        { "@Membership_Type", cbChangeUserRoleSeletion.Text},
                        { "@User_ID" , Convert.ToInt32(selectedUserID)},
                    };

                    InsertDB iUMT = new InsertDB();
                    iUMT.InsertNonQuery(sqlQuery, parameters, " ");


                    aAL.ChangedMemberType(userID.ToString(), selectedUserID, eDBConn.getDataSet(Constants.GET_M_ID_FROM_M_NAME, cbChangeUserRoleSeletion.Text).Tables[0].Rows[0].ItemArray.GetValue(0).ToString());
                    LoadUserRole();
                }
                else
                {
                    string sqlQuery = Constants.INSERT_USER_MEMBERSHIP;
                    var parameters = new Dictionary<string, object>
                    {
                        { "@User_ID", selectedUserID },
                        { "@Membership_ID", eDBConn.getDataSet(Constants.GET_M_ID_FROM_M_NAME, cbChangeUserRoleSeletion.Text).Tables[0].Rows[0].ItemArray.GetValue(0)}, //Will provide the correct membership ID for the selected user role in the "Change User Role To:" combo box.
                    };

                    InsertDB iUM = new InsertDB();
                    iUM.InsertNonQuery(sqlQuery, parameters, "Role change");



                    string sqlQueryTwo = Constants.CHANGE_MEM_TYPE_IN_USER;
                    var parametersTwo = new Dictionary<string, object>
                    {
                        { "@Membership_Type", cbChangeUserRoleSeletion.Text},
                        { "@User_ID" , Convert.ToInt32(selectedUserID)},
                    };

                    InsertDB iUMT = new InsertDB();
                    iUMT.InsertNonQuery(sqlQuery, parameters, " ");

                    aAL.ChangedMemberType(userID.ToString(), selectedUserID, eDBConn.getDataSet(Constants.GET_M_ID_FROM_M_NAME, cbChangeUserRoleSeletion.Text).Tables[0].Rows[0].ItemArray.GetValue(0).ToString());
                    LoadUserRole();
                }
            }
            catch(System.IndexOutOfRangeException)
            {
                MessageBox.Show("Please select a user role from the drop down menu.", "No Roll Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btApprove_Click(object sender, EventArgs e)
        {
            DataSet dataset = eDBConn.getDataSet(Constants.GET_APPROVAL_STATUS, selectedUserID);
            string approvalStatus = dataset.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
            bool apStat;

            if(approvalStatus == "True")
            {
                apStat = false;
            }
            else
            {
               apStat = true;
            }

            string sqlQuery = Constants.CHANGE_APPROVAL_STATUS;
            var parameters = new Dictionary<string, object>
                    {
                        { "@Is_Approved", apStat }, 
                        { "@User_ID" , Convert.ToInt32(selectedUserID)},
                    };

            InsertDB iUM = new InsertDB();
            iUM.InsertNonQuery(sqlQuery, parameters, "Change Approve Status");
            LoadApprovalStatus();
            aAL.ChangedApprovedStatus(userID.ToString(), selectedUserID, apStat.ToString());
        }

        public void LoadUserRoleSelection()
        {
            //Change this Query to provide new role names whenever they are added !!!!!!!!!!!!
            DataSet datasetEvents = eDBConn.getDataSet(Constants.GET_MEMBERSHIP_NAMES);
            Dataset_Manipulator dSM = new Dataset_Manipulator(datasetEvents);
            cbChangeUserRoleSeletion.Items.Clear();

            for (int i = 0; i < dSM.ReturnMaxRowNum(0); i++)
            {
                cbChangeUserRoleSeletion.Items.Add(dSM.ReturnElementAsString(0, i, 0));
            }
        }

        public void LoadUserChart()
        {

            DataSet datasetInterests = eDBConn.getDataSet(Constants.INDIVIDUAL_USER_INTERESTS, selectedUserID);
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
                //MessageBox.Show(tagNames[i] + " = " + frequencyOfTags[i].ToString());
                chartGlobalInterests.Series["User Interests"].Points.AddXY(tagNames[i], frequencyOfTags[i]);
            }

        }

        public void LoadApprovalStatus()
        {
            tbIsUserApproved.Clear();

            DataSet dataset = eDBConn.getDataSet(Constants.GET_APPROVAL_STATUS, selectedUserID);
            tbIsUserApproved.Text = dataset.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();

        }

        
    }
}
