using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_4.mywork
{
    public partial class Logon : System.Web.UI.Page
    {
        KarateSchoolsDataContext dbcon;
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            // access db
            string connString = ConfigurationManager.ConnectionStrings["KarateSchoolConnectionString"].ConnectionString;
            dbcon = new KarateSchoolsDataContext(connString);

            try
            {
                // grab user if they exist
                var selectedUser = (from x in dbcon.NetUsers
                                    where x.UserName == Login1.UserName && x.UserPassword == Login1.Password
                                    select x).First();

                // pull usertype from selecteduser and set the currentuser to selecteduser
                string userType = selectedUser.UserType.ToString().ToUpper();
                CurrentUser.UserID = selectedUser.UserID;
                
                // add user to session
                Session.Add("UserID", CurrentUser.UserID);
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, true);

                // redirect based on usertype
                switch (userType)
                {
                    case "ADMINISTRATOR":
                        Response.Redirect("~/mywork/Administrator.aspx");
                        break;
                    case "MEMBER":
                        Response.Redirect("~/mywork/Member.aspx");
                        break;
                    case "INSTRUCTOR":
                        Response.Redirect("~/mywork/Instructor.aspx");
                        break;
                }
            }
            catch (Exception ex)
            {
                // Write error to console for debug purposes
                Console.WriteLine(ex.Message);
            }
        }
    }
}