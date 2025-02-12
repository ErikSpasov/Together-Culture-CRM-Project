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
    public partial class Creative_Workspace_Membership : Form
    {
        private int userId; //stores userId
        public Creative_Workspace_Membership(int userId)
        {
            InitializeComponent();
            this.userId = userId;
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
                this.Close();
            }
            else
            {
                MessageBox.Show("User ID is not set. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CWM_Pay_Membership_Button_Click(object sender, EventArgs e)
        {
            // Check if userId is initialized
            if (userId > 0) // Make sure userId has a valid value
            {
                // Pass the userId to the Payment_Page constructor
                Payment_Page pP = new Payment_Page(userId);

                // Show the Creative_Workspace_Dashboard form
                pP.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("User ID is not set. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
