using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_4
{
    public static class CurrentUser
    {
        public static int UserID { get; set; }
        public static string UserType { get; set; } 
        public static string GetRedirectString()
        {
            string returnString = "";
            switch (UserType)
            {
                case "ADMINISTRATOR":
                    returnString = "~/mywork/Administrator.aspx";
                    break;
                case "MEMBER":
                    returnString = "~/mywork/Member.aspx";
                    break;
                case "INSTRUCTOR":
                    returnString = "~/mywork/Instructor.aspx";
                    break;
                default:
                    returnString = "~/mywork/Logon.aspx";
                    break;
            }
            return returnString;
        }

    }
}