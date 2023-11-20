using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_4.mywork
{
    public partial class Administrator : System.Web.UI.Page
    {
        KarateSchoolsDataContext dbcon;
        string connString = ConfigurationManager.ConnectionStrings["KarateSchoolConnectionString"].ConnectionString;
        List<int> memberIDs = new List<int>();
        List<int> instructorIDs = new List<int>();

        protected void Page_Load(object sender, EventArgs e)
        {
            // If a user is on a page that doesn't match their usertype, kick them back to the proper page.
            string currentUserType = (string)Session["UserType"];
            if (currentUserType != "ADMINISTRATOR")
                Response.Redirect(UserUtils.GetRedirectString(currentUserType));

            
            if (IsPostBack) return;

            // Load gridviews
            LoadMembers();
            LoadInstructors();
            RefreshAssignDDL();
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
                             member.MemberDateJoined
                         };



            gvMember.DataSource = result;
            gvMember.DataBind();

            var resultIDs = from member in dbcon.Members
                           select new
                           {
                               member.Member_UserID
                           };

            foreach (var mem in resultIDs)
                memberIDs.Add(mem.Member_UserID);
        }

        private void LoadInstructors()
        {
            dbcon = new KarateSchoolsDataContext(connString);

            var result = from Instructor in dbcon.Instructors
                         select new
                         {
                             Instructor.InstructorFirstName,
                             Instructor.InstructorLastName,
                         };

            gvInstructor.DataSource = result;
            gvInstructor.DataBind();

            var resultIDs = from instructor in dbcon.Instructors
                            select new
                            {
                                instructor.InstructorID
                            };

            foreach (var inst in resultIDs)
                instructorIDs.Add(inst.InstructorID);
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
            dbcon = new KarateSchoolsDataContext(connString);

            int selectedMemberID = memberIDs[gvMember.SelectedIndex];

            using (SqlConnection context = new SqlConnection(connString))
            {
                context.Open();

                // Delete from members first
                string delete = "DELETE FROM Member WHERE Member_UserID = " + selectedMemberID;
                SqlCommand sqlcom = new SqlCommand(delete, context);
                sqlcom.ExecuteNonQuery();

                // Then delete from netusers
                string delete2 = "DELETE FROM NetUser WHERE UserID = " + selectedMemberID;
                SqlCommand sqlcom2 = new SqlCommand(delete2, context);
                sqlcom2.ExecuteNonQuery();

                context.Close();
            }

            RefreshAssignDDL();
            LoadMembers();
            LoadInstructors();
        }

        protected void btnDeleteInstructor_Click(object sender, EventArgs e)
        {
            dbcon = new KarateSchoolsDataContext(connString);

            int selectedInstructorID = instructorIDs[gvInstructor.SelectedIndex];

            using (SqlConnection context = new SqlConnection(connString))
            {
                context.Open();

                // Delete from instructor first
                string delete = "DELETE FROM Instructor WHERE InstructorID = " + selectedInstructorID;
                SqlCommand sqlcom = new SqlCommand(delete, context);
                sqlcom.ExecuteNonQuery();

                // Then delete from netusers
                string delete2 = "DELETE FROM NetUser WHERE UserID = " + selectedInstructorID;
                SqlCommand sqlcom2 = new SqlCommand(delete2, context);
                sqlcom2.ExecuteNonQuery();

                context.Close();
            }

            RefreshAssignDDL();
            LoadMembers();
            LoadInstructors();
        }

        protected void btnAddMember_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values from the textboxes
                string username = txtBxAddMemberUsername.Text.Trim();
                string password = txtBxAddMemberPassword.Text.Trim();
                string firstName = txtBxAddMemberFirstName.Text.Trim();
                string lastName = txtBxAddMemberLastName.Text.Trim();
                string phoneNumber = txtBxAddMemberPhone.Text.Trim();
                string email = txtBxAddMemberEmail.Text.Trim();
                DateTime dateJoined = DateTime.Now;
                string userType = "Member";

                dbcon = new KarateSchoolsDataContext(connString);

                using (SqlConnection context = new SqlConnection(connString))
                {
                    string insert = "INSERT INTO NetUser(UserName, UserPassword, UserType) " +
                "VALUES('" + username + "','" + password + "','" + userType + "')";


                    context.Open();
                    SqlCommand sqlcom = new SqlCommand(insert, context);
                    sqlcom.ExecuteNonQuery();

                    var selectedUser = (from x in dbcon.NetUsers
                                        where x.UserName == txtBxAddMemberUsername.Text
                                        select x).First();

                    string iq2 = "INSERT INTO Member(Member_UserID, MemberFirstName, MemberLastName, MemberDateJoined, MemberPhoneNumber, MemberEmail) " +
                   "VALUES(" + selectedUser.UserID + ",'" + firstName + "', '" + lastName + "', '" + dateJoined + "', '" + phoneNumber + "', '" + email + "')";


                    SqlCommand sqlcom2 = new SqlCommand(iq2, context);
                    sqlcom2.ExecuteNonQuery();

                    context.Close();
                    LoadMembers();
                    RefreshAssignDDL();
                }



            }
            catch (SqlException ex)
            {

            }

            // Refresh the GridView and clear boxes
            txtBxAddMemberUsername.Text = "";
            txtBxAddMemberPassword.Text = "";
            txtBxAddMemberFirstName.Text = "";
            txtBxAddMemberLastName.Text = "";
            txtBxAddMemberPhone.Text = "";
            txtBxAddMemberEmail.Text = "";

        }

        protected void btnAddInstructor_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values from the textboxes
                string username = txtBxAddInstructorUsername.Text.Trim();
                string password = txtBxAddInstructorPassword.Text.Trim();
                string firstName = txtBxAddInstructorFirstName.Text.Trim();
                string lastName = txtBxAddInstructorLastName.Text.Trim();
                string phoneNumber = txtBxAddInstructorPhone.Text.Trim();
                string email = txtBxAddMemberEmail.Text.Trim();
                string userType = "Instructor";

                dbcon = new KarateSchoolsDataContext(connString);

                using (SqlConnection context = new SqlConnection(connString))
                {
                    string insert = "INSERT INTO NetUser(UserName, UserPassword, UserType) " +
                "VALUES('" + username + "','" + password + "','" + userType + "')";


                    context.Open();
                    SqlCommand sqlcom = new SqlCommand(insert, context);
                    sqlcom.ExecuteNonQuery();

                    var selectedUser = (from x in dbcon.NetUsers
                                        where x.UserName == txtBxAddInstructorUsername.Text
                                        select x).First();

                    string insertQuery2 = "INSERT INTO Instructor(InstructorID, InstructorFirstName, InstructorLastName, InstructorPhoneNumber)" +
                            " VALUES(" + selectedUser.UserID + ",'" + firstName + "', '" + lastName + "', '" + phoneNumber + "')";

                    //connect query
                    SqlCommand sqlcom2 = new SqlCommand(insertQuery2, context);

                    sqlcom2.ExecuteNonQuery();

                    context.Close();
                    LoadMembers();
                    LoadInstructors();
                    RefreshAssignDDL();
                }
            }
            catch (SqlException ex)
            {

            }
        }

        protected void btnAssignMember_Click(object sender, EventArgs e)
        {
            string sectionName = ddlSection.SelectedValue;
            DateTime sectionDate = DateTime.Now;
            string memberID = ddlMember.SelectedValue.ToString();
            string instructorID = ddlInstructor.SelectedValue.ToString();
            string sectionFee = txtBxSectionFee.Text.Trim();

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    dbcon = new KarateSchoolsDataContext(connString);

                    string insertQuery = "INSERT INTO Section(SectionName, SectionStartDate, Member_ID, Instructor_ID, SectionFee) " +
                     "VALUES('" + sectionName + "','" + sectionDate + "','" + memberID + "','" + instructorID + "','" + sectionFee + "')";


                    conn.Open();

                    SqlCommand sqlcom = new SqlCommand(insertQuery, conn);
                    sqlcom.ExecuteNonQuery();

                    RefreshAssignDDL();
                    LoadMembers();
                    LoadInstructors();
                }
            }
            catch (SqlException ex)
            {

            }
        }

        public void RefreshAssignDDL()
        {
            var result = from x in dbcon.Members select new { Name = x.MemberFirstName + " " + x.MemberLastName, x.Member_UserID };

            ddlMember.DataTextField = "Name";
            ddlMember.DataValueField = "Member_UserID";

            ddlMember.DataSource = result;
            ddlMember.DataBind();

            var result2 = from x in dbcon.Instructors select new { Name = x.InstructorFirstName + " " + x.InstructorLastName, x.InstructorID };

            ddlInstructor.DataTextField = "Name";
            ddlInstructor.DataValueField = "InstructorID";

            ddlInstructor.DataSource = result2;
            ddlInstructor.DataBind();


        }

    }
}