using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4.Updated.InstructorInfo
{
    public partial class instructorinfo : System.Web.UI.Page
    {
        KSchoolDataContext dbcon;
        string connString = ConfigurationManager.ConnectionStrings["KarateSchool_1_ConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            dbcon = new KSchoolDataContext(connString);


            if (Session.Count != 0)
            {
                if (HttpContext.Current.Session["userType"].ToString().Trim() != "Instructor")
                {
                    Session.Clear();
                    Session.RemoveAll();
                    Session.Abandon();
                    Session.Abandon();
                    System.Web.Security.FormsAuthentication.SignOut();
                    Response.Redirect("Login.aspx", true);
                }

                //taking the user's id and gettingnames
                int id;
                Int32.TryParse(HttpContext.Current.Session["userID"].ToString(), out id);

                Instructor instructor = (from x in dbcon.Instructors
                                         where x.InstructorID == id
                                         select x).FirstOrDefault();

                Label1.Text = instructor.InstructorFirstName;
                Label2.Text = instructor.InstructorLastName;


                //filling table with isntructors sections
                var result = from section in dbcon.Sections
                             join member in dbcon.Members
                             on section.Member_ID equals member.Member_UserID
                             where section.Instructor_ID == id
                             select new
                             {
                                 Section_Name = section.SectionName,
                                 First_Name = member.MemberFirstName,
                                 Last_Name = member.MemberLastName
                             };
                GridView1.DataSource = result;
                GridView1.DataBind();

            }
        }

    }
}