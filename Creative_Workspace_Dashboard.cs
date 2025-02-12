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
    public partial class Creative_Workspace_Dashboard : Form
    {
        private int userId; //stores userId

        //constructor to accept the userId
        public Creative_Workspace_Dashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;//initialise userId
        }

        private void Creative_Workspace_Dashboard_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if userId is initialized
            if (userId > 0) // Make sure userId has a valid value
            {
                // Pass the userId to the Online_Modules constructor
                Online_Modules onlineModulesForm = new Online_Modules(userId);

                // Show the Online_Modules form
                onlineModulesForm.Show();

                // Optionally hide the current form
                this.Close();
            }
            else
            {
                MessageBox.Show("User ID is not set. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CWD_View_Benefits_Button_Click(object sender, EventArgs e)
        {
            // Check if userId is initialized
            if (userId > 0) // Make sure userId has a valid value
            {
                // Pass the userId to the Creative_Workspace_Events constructor
                Creative_Workspace_Events cWE = new Creative_Workspace_Events(userId);

                // Show the Creative_Workspace_Events form
                cWE.Show();

                // Optionally hide the current form
                this.Close();
            }
            else
            {
                MessageBox.Show("User ID is not set. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CWD_Manage_Membership_Button_Click(object sender, EventArgs e)
        {
            // Check if userId is initialized
            if (userId > 0) // Make sure userId has a valid value
            {
                // Pass the userId to the Creative_Workspace_Membership constructor
                Creative_Workspace_Membership cWE = new Creative_Workspace_Membership(userId);

                // Show the Creative_Workspace_Membership form
                cWE.Show();

                // Optionally hide the current form
                this.Close();
            }
            else
            {
                MessageBox.Show("User ID is not set. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CWD_View_Benifits_Button_Click(object sender, EventArgs e)
        {
            // Check if userId is initialized
            if (userId > 0) // Make sure userId has a valid value
            {
                // Pass the userId to the Creative_Workspace_Benefits constructor
                Creative_Workspace_Benefits cWE = new Creative_Workspace_Benefits(userId);

                // Show the Creative_Workspace_Benefits form
                cWE.Show();

                // Optionally hide the current form
                this.Close();
            }
            else
            {
                MessageBox.Show("User ID is not set. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
