using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_4.mywork
{
    public partial class Instructor : System.Web.UI.Page
    {
        KarateSchoolsDataContext dbcon;
        string connString = ConfigurationManager.ConnectionStrings["KarateSchoolConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            // If a user is on a page that doesn't match their usertype, kick them back to the proper page.
            if (CurrentUser.UserType != "INSTRUCTOR")
                Response.Redirect(CurrentUser.GetRedirectString());

            // access db
            dbcon = new KarateSchoolsDataContext(connString);

            // grab current instrucctor and display name
            var myInstructor = dbcon.Instructors.FirstOrDefault(i => i.InstructorID == CurrentUser.UserID);
            lblInstructorName.Text = myInstructor.InstructorFirstName+ " " + myInstructor.InstructorLastName;

            // grab all relavent section data to the instructor
            var records = from instructor in dbcon.Instructors
                          join section in dbcon.Sections on instructor.InstructorID equals section.Instructor_ID
                          join member in dbcon.Members on section.Member_ID equals member.Member_UserID
                          where instructor.InstructorID == CurrentUser.UserID
                          select new
                          {
                              section.SectionName,
                              member.MemberFirstName,
                              member.MemberLastName
                          };

            // databind
            gvInstructor.DataSource = records;
            gvInstructor.DataBind();
        }
    }
}