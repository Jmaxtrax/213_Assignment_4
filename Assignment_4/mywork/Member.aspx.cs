using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Drawing;

namespace Assignment_4.mywork
{
    public partial class Member : System.Web.UI.Page
    {
        KarateSchoolsDataContext dbcon;
        string connString = ConfigurationManager.ConnectionStrings["KarateSchoolConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            // If a user is on a page that doesn't match their usertype, kick them back to the proper page.
            string currentUserType = (string) Session["UserType"];
            if (currentUserType != "MEMBER")
                Response.Redirect(UserUtils.GetRedirectString(currentUserType));

            // access db
            dbcon = new KarateSchoolsDataContext(connString);

            // grab current member 
            var myMember = dbcon.Members.FirstOrDefault(m => m.Member_UserID == (int) Session["UserID"]);
            lblMemberName.Text = myMember.MemberFirstName + " " + myMember.MemberLastName;

            // display all member data with secion name, instructor names, payment dates, and current payment amounts
            var records = from member in dbcon.Members
                          join section in dbcon.Sections on member.Member_UserID equals section.Member_ID
                          join instructor in dbcon.Instructors on section.Instructor_ID equals instructor.InstructorID
                          where member.Member_UserID == (int) Session["UserID"]
                          select new
                          {
                              member.MemberFirstName,
                              member.MemberLastName,
                              member.MemberDateJoined,
                              member.MemberPhoneNumber,
                              member.MemberEmail,
                              section.SectionName,
                              instructor.InstructorFirstName,
                              instructor.InstructorLastName
                          };

            gvMember.DataSource = records;
            gvMember.DataBind();
        }

    }
}
