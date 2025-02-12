using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGui
{
    class Constants
    {
        public static int ASCII_SIZE = 7;
        public static int SALT = 123;

        public static int EVENT_ID = 0;
        public static int EVENT_NAME = 1;
        public static int EVENT_DATETIME = 2;

        public static string EVENT_SELECT_ALL = "SELECT * FROM Events";
        public static string EVENT_SELECT_NAME_DATETIME = "SELECT eventName, eventDateTime FROM Events";
        public static string EVENT_SELECT_ID_NAME_DATETIME = "SELECT eventID, eventName, eventDateTime FROM Events";

        public static string GET_TAG_NAMES = "SELECT DISTINCT Tag_Name FROM Tags";
        public static string GET_MEMBERSHIP_NAMES = "SELECT DISTINCT Membership_Name FROM Membership_Types";
        public static string GET_EVENT_ID_LAST = "SELECT MAX(eventID) AS eventID FROM Events";

        public static string GET_USER_ID_IN_USER_MEM = "SELECT User_ID FROM User_Membership";

        public static string GET_DETAILS_USER_OPERATIONS = "SELECT User_ID, First_Name, Last_Name, User_Email, Is_Approved, User_Type, Date_Joined, User_Signup_Intrests, Current_Intrests, Date_Of_Birth, Address, Phone_Num, Nationality FROM Users";

        public static string INSERT_RECORD_EVENT = "INSERT INTO Events (eventName, eventDescription, eventDateTime) VALUES (@eventName, @eventDescription, @eventDateTime)";
        public static string INSERT_RECORD_EVENT_TAG = "INSERT INTO Event_Tag (Tag_ID, Event_ID) VALUES (@Tag_ID, @Event_ID)";
        public static string INSERT_EVENT_ATTENDANCE = "INSERT INTO Event_Attendance (Event_ID, User_ID) VALUES (@Event_ID, @User_ID)";
        public static string INSERT_USER_MEMBERSHIP = "INSERT INTO User_Membership (User_ID, Membership_ID) VALUES (@User_ID ,@Membership_ID)";

        public static string EVENT_DESCRIPTION_FOR_ID = "SELECT eventDescription FROM Events WHERE eventID = ";
        public static string MEMBERSHIP_DESCRIPTION_FOR_CW = "SELECT Membership_Description FROM Membership_Types WHERE Membership_Name = 'Workspace Member'";
        public static string GET_MEMBERSHIP_NAME_FROM_ID = "SELECT Membership_Type From Users WHERE User_ID = ";

        public static string GET_TAG_ID_FROM_NAME = "SELECT Tag_ID FROM Tags WHERE Tag_Name = ";
        public static string GET_APPROVAL_STATUS = "SELECT Is_Approved FROM Users WHERE User_ID = ";
        public static string GET_M_ID_FROM_M_NAME = "SELECT Membership_ID FROM Membership_Types WHERE Membership_Name = ";
        public static string GET_TAG = "SELECT * FROM Tags";

        public static string CHANGE_M_ID_IN_USER_M = "UPDATE User_Membership SET Membership_ID = @Membership_ID WHERE User_Membership.User_ID = @User_ID";
        public static string CHANGE_MEM_TYPE_IN_USER = "UPDATE Users SET Membership_Type = @Membership_Type WHERE Users.User_ID = @User_ID";
        public static string CHANGE_APPROVAL_STATUS = "UPDATE Users SET Is_Approved = @Is_Approved WHERE Users.User_ID = @User_ID";

        public static string GLOBAL_USER_INTERESTS = "SELECT Tags.Tag_Name FROM Tags INNER JOIN Event_Tag ON Tags.Tag_ID = Event_Tag.Tag_ID " + "INNER JOIN Events ON Event_Tag.Event_ID = Events.eventID " + "INNER JOIN Event_Attendance ON Events.eventID = Event_Attendance.Event_ID ";
        public static string INDIVIDUAL_USER_INTERESTS = "SELECT Tags.Tag_Name FROM Tags INNER JOIN Event_Tag ON Tags.Tag_ID = Event_Tag.Tag_ID " + "INNER JOIN Events ON Event_Tag.Event_ID = Events.eventID " + "INNER JOIN Event_Attendance ON Events.eventID = Event_Attendance.Event_ID " + "INNER JOIN Users ON Users.User_ID = Event_Attendance.User_ID WHERE Users.User_ID = ";
        public static string FILTERS_USER_INTERESTS = "SELECT Tags.Tag_Name FROM Tags INNER JOIN Event_Tag ON Tags.Tag_ID = Event_Tag.Tag_ID " + "INNER JOIN Events ON Event_Tag.Event_ID = Events.eventID " + "INNER JOIN Event_Attendance ON Events.eventID = Event_Attendance.Event_ID " + "INNER JOIN Users ON Users.User_ID = Event_Attendance.User_ID";
    }
}
