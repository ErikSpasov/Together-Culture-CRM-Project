using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProjectGui
{
    public partial class Online_Modules : Form
    {

        private int userId; // Stores userID
        public Online_Modules(int userId)
        {
            InitializeComponent();
            this.userId = userId; // Initialize userId
            this.Load += new EventHandler(this.Online_Modules_Load);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTag = cbTagFilter.SelectedItem?.ToString();
            LoadModules(selectedTag);
        }

        //Loads modules into DataGridView
        private void Online_Modules_Load(object sender, EventArgs e)
        {
            try
            {

                PopulateTagsComboBox();

                // Fetch data from the database
                ProjectDBConnection dbConnection = ProjectDBConnection.getInstanceOfProjectDBConnection();
                string sqlQuery = "SELECT " +
                                  "Modules.Module_ID, " +
                                  "Modules.Module_Name, " +
                                  "Modules.Module_Description, " +
                                  "Tags.Tag_Name " +
                                  "FROM Modules " +
                                  "LEFT JOIN Module_Tag ON Modules.Module_ID = Module_Tag.Module_ID " +
                                  "LEFT JOIN Tags ON Module_Tag.Tag_ID = Tags.Tag_ID";

                DataSet modulesDataSet = dbConnection.getDataSet(sqlQuery);

                // Check if data is available and populate DataGridView
                if (modulesDataSet.Tables.Count > 0 && modulesDataSet.Tables[0].Rows.Count > 0)
                {
                    //Clear data from rows before populating new data
                    dgvModules.Rows.Clear();
                    foreach (DataRow row in modulesDataSet.Tables[0].Rows)
                    {
                        dgvModules.Rows.Add(
                            row["Module_ID"],
                            row["Module_Name"],
                            row["Module_Description"],
                            row["Tag_Name"]
                        );
                    }
                }
                else
                {
                    MessageBox.Show("No modules available in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Populates Tags ComboBox with Tags
        private void PopulateTagsComboBox()
        {
            // Clear the ComboBox before populating it
            cbTagFilter.Items.Clear();
            cbTagFilter.Items.Add("All"); // Add "All" as an option for no filter

            // Get Tags from the database
            ProjectDBConnection dbConnection = ProjectDBConnection.getInstanceOfProjectDBConnection();
            string sqlQuery = "SELECT DISTINCT Tag_Name FROM Tags";

            DataSet tagsDataSet = dbConnection.getDataSet(sqlQuery);

            // Check if data is available and populate ComboBox
            if (tagsDataSet.Tables.Count > 0 && tagsDataSet.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in tagsDataSet.Tables[0].Rows)
                {
                    cbTagFilter.Items.Add(row["Tag_Name"].ToString());
                }
            }
            cbTagFilter.SelectedIndex = 0; // Set default to "All" to show all modules
        }
        //Loads modules while using Tags
        private void LoadModules(string tagFilter = null)
        {
            // Clear existing rows
            dgvModules.Rows.Clear();

            // SQL query to fetch Modules data with optional Tag filter
            string sqlQuery = "SELECT DISTINCT Modules.Module_ID, Modules.Module_Name, Modules.Module_Description, Tags.Tag_Name " +
                      "FROM Modules " +
                      "LEFT JOIN Module_Tag ON Modules.Module_ID = Module_Tag.Module_ID " +
                      "LEFT JOIN Tags ON Module_Tag.Tag_ID = Tags.Tag_ID";

            if (!string.IsNullOrEmpty(tagFilter) && tagFilter != "All")
            {
                sqlQuery += " WHERE Tags.Tag_Name = @TagName";
            }

            // Get the DataSet from the database
            ProjectDBConnection dbConnection = ProjectDBConnection.getInstanceOfProjectDBConnection();
            DataSet modulesDataSet;

            if (string.IsNullOrEmpty(tagFilter) || tagFilter == "All")
            {
                modulesDataSet = dbConnection.getDataSet(sqlQuery);
            }
            else
            {
                // Using parameterized query to avoid SQL injection
                sqlQuery = sqlQuery.Replace("@TagName", $"'{tagFilter}'");
                modulesDataSet = dbConnection.getDataSet(sqlQuery);
            }

            // Check if data is available and populate DataGridView
            if (modulesDataSet.Tables.Count > 0 && modulesDataSet.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in modulesDataSet.Tables[0].Rows)
                {
                    dgvModules.Rows.Add(
                        row["Module_ID"],
                        row["Module_Name"],
                        row["Module_Description"],
                        row["Tag_Name"]
                    );
                }
            }
            else
            {
                MessageBox.Show("No modules available in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Filters modules by selected Tag
        private void comboBoxTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected tag
            string selectedTag = cbTagFilter.SelectedItem.ToString();

            // Load modules based on selected tag
            LoadModules(selectedTag);
        }


        private void EnrollUserInModule(int userId, int moduleId)
        {
            try
            {
                // SQL query to insert enrollment into the Module_Enrollment table
                string sqlQuery = "INSERT INTO Module_Enrollment (User_ID, Module_ID, Enrollment_Date) VALUES (@UserId, @ModuleId, @EnrollmentDate)";

                // Set up the database connection and command
                ProjectDBConnection dbConnection = ProjectDBConnection.getInstanceOfProjectDBConnection();
                var parameters = new Dictionary<string, object>
                {
                    { "@UserId", userId },
                    { "@ModuleId", moduleId },
                    { "@EnrollmentDate", DateTime.Now } // Set current date as the enrollment date
                };

                // Execute the query
                int rowsAffected = dbConnection.executeNonQuery(sqlQuery, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Enrollment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Enrollment failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnroll_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Check if a module is selected
                if (dgvModules.SelectedRows.Count > 0)
                {
                    // Get the selected module ID from the DataGridView
                    int selectedModuleId = Convert.ToInt32(dgvModules.SelectedRows[0].Cells["Module_ID"].Value);

                    // Call the EnrollUserInModule method
                    EnrollUserInModule(this.userId, selectedModuleId);
                }
                else
                {
                    MessageBox.Show("Please select a module to enroll in.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            // Check if userId is initialized
            if (userId > 0) // Make sure userId has a valid value
            {
                // Pass the userId to the Online_Modules constructor
                Creative_Workspace_Dashboard cWD = new Creative_Workspace_Dashboard(userId);

                // Show the Online_Modules form
                cWD.Show();

                // Optionally hide the current form
                this.Close();
            }
            else
            {
                MessageBox.Show("User ID is not set. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}