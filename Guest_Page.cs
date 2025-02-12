using System;
using System.Windows.Forms;

namespace ProjectGui
{
    public partial class Guest_Page : Form
    {
        private int userId; // To store the User_ID passed from GuestRegister

        public Guest_Page(int userId)
        {
            InitializeComponent();
            this.userId = userId; // Assign the userId to the field
        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            // Example: Pass userId to Modules page
            if (userId > 0) // Make sure userId exists
            {
                Creative_Workspace_Events eventsForm = new Creative_Workspace_Events(userId);
                eventsForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User ID is not set. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Confirm exit
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Close application
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Example: Pass userId to Modules page
            if (userId > 0) // Make sure userId exists
            {
                Online_Modules onlineModulesForm = new Online_Modules(userId);
                onlineModulesForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User ID is not set. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
