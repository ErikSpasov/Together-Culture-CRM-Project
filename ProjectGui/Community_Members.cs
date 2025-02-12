using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace ProjectGui
{
    public partial class Community_Members : Form
    {
        private int userId; // Store the user ID

        public Community_Members(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            SetupForm();
            LoadUserInterests();
        }

        // Setup Form Design
        private void SetupForm()
        {
            // Set form background color to light gray for modern design
            this.BackColor = Color.LightGray;
            this.Text = "Community Members"; // Window title

            // Header panel design
            Panel headerPanel = new Panel();
            headerPanel.Dock = DockStyle.Top;
            headerPanel.BackColor = Color.Red;
            headerPanel.Height = 80;

            Label headerLabel = new Label();
            headerLabel.Text = "Community Member";
            headerLabel.Font = new Font("Arial", 24, FontStyle.Bold);
            headerLabel.ForeColor = Color.White;
            headerLabel.Dock = DockStyle.Fill;
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;

            headerPanel.Controls.Add(headerLabel);
            this.Controls.Add(headerPanel);

            // Set button styling for "View Events"
            btnViewEvents.BackColor = Color.DarkRed;
            btnViewEvents.ForeColor = Color.White;
            btnViewEvents.FlatStyle = FlatStyle.Flat;
            btnViewEvents.FlatAppearance.BorderSize = 0;
            btnViewEvents.Text = "View Events"; // Change button text
        }

        private void LoadUserInterests()
        {
            // Get the list of user interests from the database
            List<string> userInterests = ProjectDBConnection.getInstanceOfProjectDBConnection().GetUserInterests(userId);

            // Convert the list of interests to a DataTable
            DataTable interestsTable = ConvertListToDataTable(userInterests);

            if (interestsTable != null && interestsTable.Rows.Count > 0)
            {
                // Bind the DataTable to the DataGridView
                dgvUserInterests.DataSource = interestsTable;
            }
            else
            {
                MessageBox.Show("No interests found for this user.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private DataTable ConvertListToDataTable(List<string> interests)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Interest_Name"); // Define the column for interest names

            foreach (string interest in interests)
            {
                DataRow row = dataTable.NewRow();
                row["Interest_Name"] = interest;  // Add each interest as a row in the DataTable
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        // Updated button click event for View Events
        private void btnViewEvents_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dgvUserInterests.SelectedRows.Count > 0)
            {
                // Get the selected interest name (optional)
                string interestName = dgvUserInterests.SelectedRows[0].Cells["Interest_Name"].Value.ToString();

                // Show a message box (optional) to notify the user of the selected interest
                MessageBox.Show($"You selected: {interestName} - Viewing related events.", "Event Details");

                // Create a new instance of the Creative_Workspace_Events form and pass the userId
                Creative_Workspace_Events eventPage = new Creative_Workspace_Events(userId);

                // Show the event page
                eventPage.Show();

                // Optionally, hide the current page
                this.Hide();
            }
            else
            {
                // If no row is selected, show a warning message
                MessageBox.Show("Please select an interest to view events.", "No Event Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Community_Members_Load(object sender, EventArgs e)
        {
            // Load data into the interests table when the form loads
            this.intrestsTableAdapter.Fill(this.projectDBDataSet.Intrests);
        }
    }
}
