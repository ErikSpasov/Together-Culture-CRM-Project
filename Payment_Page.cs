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
    public partial class Payment_Page : Form
    {

        private int userID;
        public Payment_Page(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            // Check if userId is initialized
            if (userID > 0) // Make sure userId has a valid value
            {
                // Pass the userId to the Creative_Workspace_Membership constructor
                Creative_Workspace_Membership cWM = new Creative_Workspace_Membership(userID);

                // Show the Creative_Workspace_Membership form
                cWM.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("User ID is not set. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Payment_Page_Load(object sender, EventArgs e)
        {

        }
    }
}
