using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGui
{
    internal class ProjectDBConnection
    {  
        // private object of class itself
        private static ProjectDBConnection _instance;

        // Connection string for projectDB.mdf
        private string ProjectDBConnectionString;

        private ProjectDBConnection()
        {
            // initialise eventsDBConnectionString
            ProjectDBConnectionString = Properties.Settings.Default.DBConnectionString;
        }

        //methods

        public static ProjectDBConnection getInstanceOfProjectDBConnection()
        {
            if (_instance == null)
            {
                _instance = new ProjectDBConnection();
            }
            return _instance;
        }

        public DataSet getDataSet( string sqlQuery)
        {

            DataSet dataset = new DataSet();

            using (SqlConnection connToEDB = new SqlConnection(ProjectDBConnectionString))
            {
                //open connetion
                connToEDB.Open();

                //send SQL query to the dataset
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connToEDB);

                //fill in the dataset
                adapter.Fill(dataset);
            }
            return dataset;
        }

        // Search specific IDs.
        public DataSet getDataSet(string sqlQuery, int value)
        {

            DataSet dataset = new DataSet();
            sqlQuery = string.Concat(sqlQuery, value.ToString());

            using (SqlConnection connToEDB = new SqlConnection(ProjectDBConnectionString))
            {
                //open connetion
                connToEDB.Open();

                //send SQL query to the dataset
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connToEDB);

                //fill in the dataset
                adapter.Fill(dataset);
            }
            return dataset;
        }

        // Use string
        public DataSet getDataSet(string sqlQuery, string value)
        {

            DataSet dataset = new DataSet();

            value = "'" + value + "'"; 
            sqlQuery = string.Concat(sqlQuery, value);

            using (SqlConnection connToEDB = new SqlConnection(ProjectDBConnectionString))
            {
                //open connetion
                connToEDB.Open();

                //send SQL query to the dataset
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connToEDB);

                //fill in the dataset
                adapter.Fill(dataset);
            }
            return dataset;
        }


        // Method to save an event into the event database.
        public void saveToEDB(string sqlQuery, string eventName, string eventDescription, DateTime eventDateTime)
        {
            using (SqlConnection connToEDB = new SqlConnection(ProjectDBConnectionString))
            {
                connToEDB.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery,connToEDB);

                //set sqlCommands properties
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.Add(new SqlParameter("eventName", eventName));
                sqlCommand.Parameters.Add(new SqlParameter("eventDescription", eventDescription));
                sqlCommand.Parameters.Add(new SqlParameter("eventDateTime", eventDateTime));

                // Execute

                sqlCommand.ExecuteNonQuery();
            }
        }

        public void saveToETDB(string sqlQuery, int Tag_ID, int Event_ID)
        {
            using (SqlConnection connToEDB = new SqlConnection(ProjectDBConnectionString))
            {
                connToEDB.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToEDB);

                //set sqlCommands's properties
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.Add(new SqlParameter("Tag_ID", Tag_ID));
                sqlCommand.Parameters.Add(new SqlParameter("Event_ID", Event_ID));

                // Execute

                sqlCommand.ExecuteNonQuery();
            }
        }

        // Method to get email and password from the User table
        public bool ValidateUserCredentials(string email, string password, out bool isApproved, out int userId, out string membershipType, out string userType)
        {
            isApproved = false;
            userId = -1;
            membershipType = null;
            userType = null;
            bool isValid = false;

            string userValidationQuery = @"SELECT User_ID, Is_Approved, Membership_Type, User_Type, User_Password
                                   FROM Users
                                   WHERE User_Email = @Email";

            using (SqlConnection connToEDB = new SqlConnection(ProjectDBConnectionString))
            {
                try
                {
                    connToEDB.Open();
                    SqlCommand sqlCommand = new SqlCommand(userValidationQuery, connToEDB);
                    sqlCommand.Parameters.AddWithValue("@Email", email);

                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        string hashedPassword = reader["User_Password"].ToString();
                        if (PasswordHasher.VerifyPassword(password, hashedPassword))
                        {
                            userId = Convert.ToInt32(reader["User_ID"]);
                            isApproved = Convert.ToBoolean(reader["Is_Approved"]);
                            membershipType = reader["Membership_Type"].ToString();
                            userType = reader["User_Type"].ToString();
                            isValid = true;
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in user validation: " + ex.Message);
                }
            }

            return isValid && userId != -1;
        }

        //handles parameterized queries
        public int executeNonQuery(string query, Dictionary<string, object> parameters)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(this.ProjectDBConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error with the querry
                Console.WriteLine("Error executing query: " + ex.Message);
            }

            return rowsAffected;
        }
        public List<string> GetUserInterests(int userId)
        {
            List<string> interests = new List<string>();

            // SQL query to fetch user interests from the database
            string query = "SELECT InterestName FROM UserInterests WHERE UserID = @UserID";

            using (SqlConnection connToEDB = new SqlConnection(ProjectDBConnectionString))
            {
                try
                {
                    connToEDB.Open();

                    // Create the SQL command
                    SqlCommand sqlCommand = new SqlCommand(query, connToEDB);
                    sqlCommand.Parameters.AddWithValue("@UserID", userId);

                    // Execute the command and read the data
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        interests.Add(reader["InterestName"].ToString());  // Add each interest to the list
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error retrieving user interests: " + ex.Message);
                }
            }

            return interests;
        }



    }
}
