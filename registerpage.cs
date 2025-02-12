using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProjectGui
{
    public partial class registerPage : Form
    {
        private string selectedMembershipName; // Store selected membership type name

        // Constructor initialize form and load membership types
        public registerPage()
        {
            InitializeComponent();
            LoadMembershipTypes();
        }

        // Method to load membership types and display on datagridview
        private void LoadMembershipTypes()
        {
            try
            {
                ProjectDBConnection dbConnection = ProjectDBConnection.getInstanceOfProjectDBConnection();
                string sqlQuery = "SELECT Membership_ID, Membership_Name, Membership_Description FROM Membership_Types";
                DataSet membershipData = dbConnection.getDataSet(sqlQuery);

                if (membershipData.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = membershipData.Tables[0];
                    dataGridView1.Columns["Membership_ID"].Visible = false; // Hide Membership_ID column
                    dataGridView1.Columns["Membership_Name"].HeaderText = "Memberships";
                    dataGridView1.Columns["Membership_Description"].HeaderText = "Membership Description";

                    AddSelectButtonColumn();
                }
                else
                {
                    MessageBox.Show("No membership types found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading membership types: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to add SELECT buttons in datagridview to select memberships
        private void AddSelectButtonColumn()
        {
            DataGridViewButtonColumn selectButton = new DataGridViewButtonColumn
            {
                Name = "SelectButton",
                HeaderText = "Select",
                Text = "Select",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(selectButton);
        }

        // Event to handle cell click in datagridview
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["SelectButton"].Index)
            {
                // Capture the Membership_Name from the selected row
                selectedMembershipName = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Membership_Name"].Value);
                MessageBox.Show($"Selected Membership Type: {selectedMembershipName}", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Event handler to process the user registration
        private void btSubmit_Click(object sender, EventArgs e)
        {
            // Get input from textboxes
            string firstName = tbFirstName.Text.Trim();
            string lastName = tbLastName.Text.Trim();
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();
            string confirmPassword = tbConfirmPassword.Text.Trim();
            string address = tbAddress.Text.Trim();
            string phoneNum = tbPhoneNum.Text.Trim();
            string gender = cbGender.SelectedItem.ToString(); // Get selected gender from ComboBox
            string nationality = tbNationality.Text.Trim();
            DateTime dateOfBirth = dtpDateOfBirth.Value; // Get date of birth from DateTimePicker

            // Validate first and last name
            if (!System.Text.RegularExpressions.Regex.IsMatch(firstName, "^[a-zA-Z]{2,50}$") ||
                !System.Text.RegularExpressions.Regex.IsMatch(lastName, "^[a-zA-Z]{2,50}$"))
            {
                MessageBox.Show("First and Last names must contain only alphabetic characters and be between 2 and 50 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate email
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$"))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate password strength
            if (!System.Text.RegularExpressions.Regex.IsMatch(password, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&#])[A-Za-z\\d@$!%*?&#]{8,}$"))
            {
                MessageBox.Show("Password must be at least 8 characters long and include an uppercase letter, a lowercase letter, a number, and a special character.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate password confirmation
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please check your password confirmation.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate address
            if (address.Length < 5 || !System.Text.RegularExpressions.Regex.IsMatch(address, "^[a-zA-Z0-9 .,-]+$"))
            {
                MessageBox.Show("Address must be at least 5 characters long and contain only valid characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate phone number
            if (phoneNum.Length < 11 || !System.Text.RegularExpressions.Regex.IsMatch(phoneNum, "^[0-9]+$"))
            {
                MessageBox.Show("Phone number must be at least 11 digits long and contain only numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for duplicate email and phone number
            try
            {
                ProjectDBConnection dbConnection = ProjectDBConnection.getInstanceOfProjectDBConnection();

                // Check email if exsisting
                string emailCheckQuery = "SELECT COUNT(*) FROM Users WHERE User_Email = @Email";
                var emailParameters = new Dictionary<string, object> { { "@Email", email } };
                int emailCount = Convert.ToInt32(dbConnection.executeNonQuery(emailCheckQuery, emailParameters));

                if (emailCount > 0)
                {
                    MessageBox.Show("Email is already registered. Please use a different email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check phone number if existing
                string phoneCheckQuery = "SELECT COUNT(*) FROM Users WHERE Phone_Num = @PhoneNum";
                var phoneParameters = new Dictionary<string, object> { { "@PhoneNum", phoneNum } };
                int phoneCount = Convert.ToInt32(dbConnection.executeNonQuery(phoneCheckQuery, phoneParameters));

                if (phoneCount > 0)
                {
                    MessageBox.Show("Phone number is already registered. Please use a different phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while checking for duplicates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check for empty fields
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phoneNum) ||
                string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(nationality) ||
                string.IsNullOrEmpty(selectedMembershipName))
            {
                MessageBox.Show("Please fill in all fields correctly and select a membership type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Hash the user's password using PasswordHasher
                string hashedPassword = PasswordHasher.HashPassword(password);

                // Create a new instance of the database connection
                ProjectDBConnection dbConnection = ProjectDBConnection.getInstanceOfProjectDBConnection();

                // SQL query for inserting user data, includes Membership_Type
                string sqlQuery = @"INSERT INTO Users 
                    (First_Name, Last_Name, User_Email, User_Password, Is_Approved, User_Type, Date_Joined, Address, Phone_Num, Gender, Nationality, Date_Of_Birth, Membership_Type)
                    VALUES 
                    (@FirstName, @LastName, @Email, @Password, @IsApproved, @UserType, @DateJoined, @Address, @PhoneNum, @Gender, @Nationality, @DateOfBirth, @MembershipType)";

                // Parameters for user insertion
                var userParameters = new Dictionary<string, object>
                {
                    { "@FirstName", firstName },
                    { "@LastName", lastName },
                    { "@Email", email },
                    { "@Password", hashedPassword },
                    { "@IsApproved", false },
                    { "@UserType", "member" },
                    { "@DateJoined", DateTime.Now },
                    { "@Address", address },
                    { "@PhoneNum", phoneNum },
                    { "@Gender", gender },
                    { "@Nationality", nationality },
                    { "@DateOfBirth", dateOfBirth },
                    { "@MembershipType", selectedMembershipName }
                };

                // Execute the user insertion query
                int userId = dbConnection.executeNonQuery(sqlQuery, userParameters);

                if (userId > 0)
                {
                    // SQL query for inserting into User_Membership table
                    string membershipQuery = @"INSERT INTO User_Membership (Membership_ID, User_ID)
                       VALUES (@MembershipID, @UserID)";

                    // Parameters for User_Membership insertion
                    var membershipParameters = new Dictionary<string, object>
                    {
                        { "@MembershipID", GetSelectedMembershipID() },
                        { "@UserID", userId }
                    };

                    // Execute the User_Membership insertion query
                    int membershipRowsAffected = dbConnection.executeNonQuery(membershipQuery, membershipParameters);

                    if (membershipRowsAffected > 0)
                    {
                        SaveUserIntrests(userId);
                        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HomePage homePage = new HomePage(); // Redirect user to Home Page
                        homePage.Show();
                        this.Hide();
                        homePage.FormClosed += (s, args) => this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to assign membership. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        // Save user intrest into database
        private void SaveUserIntrests(int userId)
        {
            // Loop through the rows of dataGridView2 to find the selected checkboxes
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Selector"].Value)) // Check if the checkbox is checked
                {
                    int intrestId = Convert.ToInt32(row.Cells["Intrest_ID"].Value); // Assuming Intrest_ID column exists in dataGridView2

                    // Insert the selected intrest into the user_intrest table
                    try
                    {
                        ProjectDBConnection dbConnection = ProjectDBConnection.getInstanceOfProjectDBConnection();

                        string sqlQuery = @"INSERT INTO User_Intrest (user_id, intrest_id)
                                            VALUES (@UserID, @IntrestID)";

                        var parameters = new Dictionary<string, object>
                        {
                            { "@UserID", userId },
                            { "@IntrestID", intrestId }
                        };

                        dbConnection.executeNonQuery(sqlQuery, parameters);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while saving user intrests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Event handler for form load to initialize intrests
        private void registerPage_Load(object sender, EventArgs e)
        {
            try
            {
                ProjectDBConnection dbConnection = ProjectDBConnection.getInstanceOfProjectDBConnection();
                string sqlQuery = "SELECT Intrest_ID, Intrest_Name, Intrest_Description FROM Intrests";
                DataSet intrestData = dbConnection.getDataSet(sqlQuery);

                if (intrestData.Tables[0].Rows.Count > 0)
                {
                    dataGridView2.DataSource = intrestData.Tables[0];
                    dataGridView2.Columns["Intrest_ID"].Visible = false; // Hide Interest_ID column
                    AddIntrestCheckBoxColumn();
                }
                else
                {
                    MessageBox.Show("No intrests found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading intrests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddIntrestCheckBoxColumn()
        {
            if (!dataGridView2.Columns.Contains("Selector"))
            {
                DataGridViewCheckBoxColumn selectorColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "Selector",
                    HeaderText = "Select",
                    FalseValue = false,
                    TrueValue = true
                };
                dataGridView2.Columns.Add(selectorColumn);
            }
            else
            {
                MessageBox.Show("No interests found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Helper method to get Membership_ID based on Membership_Name
        private int GetSelectedMembershipID()
        {
            try
            {
                ProjectDBConnection dbConnection = ProjectDBConnection.getInstanceOfProjectDBConnection();

                // SQL query to get Membership_ID from Membership_Types table
                string sqlQuery = "SELECT Membership_ID FROM Membership_Types WHERE Membership_Name = @MembershipName";

                // Create a DataSet using getDataSet method
                DataSet dataSet = dbConnection.getDataSet(sqlQuery.Replace("@MembershipName", "'" + selectedMembershipName + "'"));

                // Check if the result is not empty and return the Membership_ID
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    return Convert.ToInt32(dataSet.Tables[0].Rows[0]["Membership_ID"]);
                }
                else
                {
                    MessageBox.Show("No Membership_ID found for the selected Membership_Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching Membership_ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}