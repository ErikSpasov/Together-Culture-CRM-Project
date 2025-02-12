using System;
using System.Windows.Forms;

namespace ProjectGui
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void BtnGuest_Click(object sender, EventArgs e)
        {
            GuestRegister guestPage = new GuestRegister();
            guestPage.Show();
            this.Hide();
            guestPage.FormClosed += (s, args) => this.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();

            bool isApproved = false;
            int userId = -1;
            string membershipType = null;
            string userType = null;

            bool isValid = ProjectDBConnection.getInstanceOfProjectDBConnection().ValidateUserCredentials(
                email,
                password,
                out isApproved,
                out userId,
                out membershipType,
                out userType
            );

            if (isValid && isApproved)
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (userType == "admin")
                {
                    Admin_User_Operations adminDashboard = new Admin_User_Operations(userId);
                    adminDashboard.Show();
                    this.Hide();
                }
                else
                {
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
            else if (isValid && !isApproved)
            {
                MessageBox.Show("Your account is not approved yet. Please contact the admin.", "Not Approved", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Invalid Email or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            registerPage RegisterPage = new registerPage();
            RegisterPage.Show();
            this.Hide();
            RegisterPage.FormClosed += (s, args) => this.Show();
        }
    }
}
