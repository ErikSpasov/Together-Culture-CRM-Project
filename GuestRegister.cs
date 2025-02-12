using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectGui
{
    public partial class GuestRegister : Form
    {
        public GuestRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get input from textboxes
            string firstName = tbGuestFirstName.Text.Trim();
            string lastName = tbGuestLastName.Text.Trim();
            string email = tbGuestEmail.Text.Trim();
            string userType = "guest"; // Hardcoded as 'guest' for guests only

            // Check for empty fields
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Validate user names
            if (!System.Text.RegularExpressions.Regex.IsMatch(firstName, "^[a-zA-Z]{2,50}$") ||
                !System.Text.RegularExpressions.Regex.IsMatch(lastName, "^[a-zA-Z]{2,50}$"))
            {
                MessageBox.Show("First and Last names must contain only alphabetic characters and be between 2 and 50 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Validate email
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$"))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            try
            {
                // SQL query for inserting data and returning the userId
                string sqlQuery = @"
                    INSERT INTO Users (First_Name, Last_Name, User_Email, User_Type)
                    VALUES (@FirstName, @LastName, @Email, @UserType);
                    SELECT SCOPE_IDENTITY();";

                // Parameters for the query
                var parameters = new Dictionary<string, object>
                {
                    { "@FirstName", firstName },
                    { "@LastName", lastName },
                    { "@Email", email },
                    { "@UserType", userType }
                };

                // Get the database connection instance
                ProjectDBConnection dbConnection = ProjectDBConnection.getInstanceOfProjectDBConnection();

                // Execute the query and retrieve the new userId
                int userId = 0;
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DBConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }

                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            userId = Convert.ToInt32(result);
                        }
                    }
                }

                // Check if registration was successful
                if (userId > 0)
                {
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Pass userId to Guest_Page
                    Guest_Page guestPage = new Guest_Page(userId);
                    guestPage.Show();
                    this.Hide();
                    guestPage.FormClosed += (s, args) => this.Show();
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}