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
            var myMember = dbcon.Members.FirstOrDefault(m => m.Member_UserID == (int)Session["UserID"]);
            try
            {
                lblMemberName.Text = myMember.MemberFirstName + " " + myMember.MemberLastName;
            }
            catch(Exception ex)
            {

            }
            var records = from member in dbcon.Members
                           join section in dbcon.Sections on member.Member_UserID equals section.Member_ID
                           join instructor in dbcon.Instructors on section.Instructor_ID equals instructor.InstructorID
                           where member.Member_UserID == (int)Session["UserID"]
                           select new
                           {
                               section.SectionName,
                               section.SectionID,
                               section.SectionFee,
                               section.SectionStartDate,
                               instructor.InstructorFirstName,
                               instructor.InstructorLastName,


                           };

            decimal totalPayments = records.Sum(section => section.SectionFee);
            lblTotalCost.Text = totalPayments.ToString("c");


            gvMember.DataSource = records;
            gvMember.DataBind();


        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Cookies.Clear();
            Response.Redirect("~/mywork/Logon.aspx");
        }
    }
}
