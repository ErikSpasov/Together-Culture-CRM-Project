using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGui
{
    internal class InsertDB
    {
        ProjectDBConnection eDBConn = ProjectDBConnection.getInstanceOfProjectDBConnection();
        public void InsertNonQuery(string sqlQuery, Dictionary<string, object> parameters, string message)
        {
            try
            {

            int rowsAffected = eDBConn.executeNonQuery(sqlQuery, parameters);

                if (message != " ")
                {
                    if (rowsAffected > 0)

                    {
                        MessageBox.Show(message + " successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(message + " failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
    }
}
