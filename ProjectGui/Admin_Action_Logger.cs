using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGui
{
    internal class Admin_Action_Logger
    {
        public static Admin_Action_Logger _instance;

        private String LogFile = "AdminLogFile.txt";

        private StreamWriter writer;

        private Admin_Action_Logger() 
        {
            try
            {
                writer = new StreamWriter(LogFile, true);
            }
            catch(IOException e)
            {
                MessageBox.Show("IO error in Admin Action Logger");
            }
        }

        public static Admin_Action_Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Admin_Action_Logger();
                }

                return _instance;
            }

        }

        public void ChangedMemberType(string adminID, string user_ID, string memberType)
        {
            writer.WriteLine("Admin ID: " + adminID + " changed user, User ID: " + user_ID + " to Member Type: " + memberType);
        }

        public void ChangedApprovedStatus(string adminID, string user_ID, string approveStatus)
        {
            writer.WriteLine("Admin ID: " + adminID + " changed user, User ID: " + user_ID + " to Approve Status: " + approveStatus);
        }

        public void Close()
        {
            writer.Close();
        }



    }
}
