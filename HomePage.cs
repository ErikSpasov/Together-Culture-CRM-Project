using System;
using System.Windows.Forms;

namespace ProjectGui
{
    // HomePage class represents the main page of the application that allows users to Login, Sign Up or Continue as Guest
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        // Guest button redirects user to guestRegister page
        private void BtnGuest_Click(object sender, EventArgs e)
        {
            GuestRegister guestPage = new GuestRegister();
            guestPage.Show();
            this.Hide();
            guestPage.FormClosed += (s, args) => this.Show();
        }

        // Login button
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();

            bool isApproved = false;// Stores boolean isApproved whenever if user is approved by admin or not
            int userId = -1;// Stores userId after successful login
            string membershipType = null;// Stores membership type of the user
            string userType = null;// Stores user types (member,admin or guest)

            // Calls validation method from ProjectDBConnections class
            bool isValid = ProjectDBConnection.getInstanceOfProjectDBConnection().ValidateUserCredentials(
                email,
                password,
                out isApproved,
                out userId,
                out membershipType,
                out userType
            );
            // Checks if user credentials are valid and account is approved by admin
            if (isValid && isApproved)
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // If userType is admin redirect to admin dashboard
                if (userType == "admin")
                {
                    Admin_User_Operations adminDashboard = new Admin_User_Operations(userId);
                    adminDashboard.Show();
                    this.Hide();
                }
                else
                {
                    // Redirects members to their dashboard based on the membership type
                    switch (membershipType)
                    {
                        case "Community Member":
                            Community_Members communityDashboard = new Community_Members(userId);
                            communityDashboard.Show();
                            this.Hide();
                            break;
                        case "Workspace Member":
                            Creative_Workspace_Dashboard workspaceDashboard = new Creative_Workspace_Dashboard(userId);
                            workspaceDashboard.Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("Unknown membership type. Redirecting to default dashboard.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                }
            }
            // If user input is correct but the account is not approved by admin yet
            else if (isValid && !isApproved)
            {
                MessageBox.Show("Your account is not approved yet. Please contact the admin.", "Not Approved", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
            // If user inputs incorrect login details
                MessageBox.Show("Invalid Email or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // SignUp button when clicked user is redirected to Register Page
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            registerPage RegisterPage = new registerPage();
            RegisterPage.Show();
            this.Hide();
            RegisterPage.FormClosed += (s, args) => this.Show();
        }
    }
}
