using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_4.mywork
{
    public partial class Administrator : System.Web.UI.Page
    {
        KarateSchoolsDataContext dbcon;
        string connString = ConfigurationManager.ConnectionStrings["KarateSchoolConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            // If a user is on a page that doesn't match their usertype, kick them back to the proper page.
            string currentUserType = (string)Session["UserType"];
            if (currentUserType != "ADMINISTRATOR")
                Response.Redirect(UserUtils.GetRedirectString(currentUserType));


        }

        private void LoadMembers()
        {
            dbcon = new KarateSchoolsDataContext(connString);
        }
    }
}