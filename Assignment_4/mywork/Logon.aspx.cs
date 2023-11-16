using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_4.mywork
{
    public partial class Logon : System.Web.UI.Page
    {
        private readonly Dictionary<string, string> users = new Dictionary<string, string>
        {
            { "member1", "password1" },
            { "member2", "password2" },
            { "instructor1", "password3" },
            { "instructor2", "password4" },
            { "admin", "adminpassword" }
        };

        protected void btnLogin_ServerClick(object sender, EventArgs e)
        {
            string username = txtUsername.Value.Trim();
            string password = txtPassword.Value.Trim();

            if (AuthenticateUser(username, password))
            {
                // Redirect based on user type
                if (IsMember(username))
                {
                    Response.Redirect("Member.aspx");
                }
                else if (IsInstructor(username))
                {
                    Response.Redirect("Instructor.aspx");
                }
                else if (IsAdmin(username))
                {
                    Response.Redirect("Administrator.aspx");
                }
            }
            else
            {
                // Display authentication failure message
                ScriptManager.RegisterStartupScript(this, GetType(), "showAlert", "alert('Authentication failed!');", true);
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Simple authentication logic (replace with database validation)
            return users.ContainsKey(username) && users[username] == password;
        }

        private bool IsMember(string username)
        {
            // Check if the user is a member (customize based on your criteria)
            return username.StartsWith("member", StringComparison.OrdinalIgnoreCase);
        }

        private bool IsInstructor(string username)
        {
            // Check if the user is an instructor (customize based on your criteria)
            return username.StartsWith("instructor", StringComparison.OrdinalIgnoreCase);
        }

        private bool IsAdmin(string username)
        {
            // Check if the user is an admin (customize based on your criteria)
            return string.Equals(username, "admin", StringComparison.OrdinalIgnoreCase);
        }
    }
}