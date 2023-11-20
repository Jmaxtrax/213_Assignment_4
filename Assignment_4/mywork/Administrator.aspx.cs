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

            // Load gridviews
            LoadMembers();
            LoadInstructors();
        }

        private void LoadMembers()
        {
            dbcon = new KarateSchoolsDataContext(connString);

            var result = from member in dbcon.Members
                         select new
                         {
                             member.MemberFirstName,
                             member.MemberLastName,
                             member.MemberPhoneNumber,
                             member.MemberDateJoined,
                             member.Member_UserID
                         };

            gvMember.DataSource = result;
            gvMember.DataBind();
        }

        private void LoadInstructors()
        {
            dbcon = new KarateSchoolsDataContext(connString);

            var result = from Instructor in dbcon.Instructors
                         select new
                         {
                             Instructor.InstructorFirstName,
                             Instructor.InstructorLastName,
                             Instructor.InstructorID
                         };

            gvInstructor.DataSource = result;
            gvInstructor.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Cookies.Clear();
            Response.Redirect("~/mywork/Logon.aspx");
        }

        protected void btnDeleteMember_Click(object sender, EventArgs e)
        {

        }

        protected void btnDeleteInstructor_Click(object sender, EventArgs e)
        {

        }

        protected void btnAddMember_Click(object sender, EventArgs e)
        {
            // Get the values from the textboxes
            string userId = txtBxAddMemberUserID.Text;
            string username = txtBxAddMemberUsername.Text;
            string password = txtBxAddMemberPassword.Text;
            string firstName = txtBxAddMemberFirstName.Text;
            string lastName = txtBxAddMemberLastName.Text;
            string phoneNumber = txtBxAddMemberPhone.Text;
            string email = txtBxAddMemberEmail.Text;

            // Create a new instance of the data context
            dbcon = new KarateSchoolsDataContext(connString);
            using (dbcon = new KarateSchoolsDataContext(connString))
            {
                // Create a new Member object
                Member newMember = new Member
                {
                    //Member_UserID = userId,
                    //MemberUsername = username,
                   // MemberPassword = password,
                   // MemberFirstName = firstName,
                   // MemberLastName = lastName,
                    //MemberPhoneNumber = phoneNumber,
                    //MemberEmail = email
                };

                // Add the new member to the Members table
                //dbcon.Members.InsertOnSubmit(newMember);


                dbcon.SubmitChanges();
            }

            // Refresh the GridView
            LoadMembers();
        }

        protected void btnAddInstructor_Click(object sender, EventArgs e)
        {

        }

        protected void btnAssignMember_Click(object sender, EventArgs e)
        {

        }
    }
}