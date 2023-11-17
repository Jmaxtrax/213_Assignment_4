﻿using System;
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
                             member.MemberDateJoined
                         };

            gvMember.DataSource = result;
            gvMember.DataBind();
        }

        private void LoadInstructors()
        {
            dbcon = new KarateSchoolsDataContext(connString);

            var result = from instructor in dbcon.Instructors
                         select new
                         {
                             instructor.InstructorFirstName,
                             instructor.InstructorLastName
                         };

            gvInstructor.DataSource = result;
            gvInstructor.DataBind();
        }
    }
}