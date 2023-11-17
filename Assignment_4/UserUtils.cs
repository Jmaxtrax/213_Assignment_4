using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_4
{
    public static class UserUtils
    {
        public static string GetRedirectString(string userType)
        {
            string returnString = "";
            switch (userType)
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