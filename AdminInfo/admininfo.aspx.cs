using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4.Updated.AdminInfo
{
    public partial class admininfo : System.Web.UI.Page
    {
        KSchoolDataContext dbcon;
        string connString = ConfigurationManager.ConnectionStrings["KarateSchool_1_ConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            dbcon = new KSchoolDataContext(connString);


            if (Session.Count != 0)
            {
                if (HttpContext.Current.Session["userType"].ToString().Trim() != "Administrator")
                {
                    Session.Clear();
                    Session.RemoveAll();
                    Session.Abandon();
                    Session.Abandon();
                    System.Web.Security.FormsAuthentication.SignOut();
                    Response.Redirect("Login.aspx", true);
                }

            }
        }




        protected void removeMember_Click(object sender, EventArgs e)
        {
            KSchoolDataContext dbcon = new KSchoolDataContext(connString);
            int id;
            //finding member with selected id and removing them
            Int32.TryParse(rMember.Text, out id);
            var result = from x in dbcon.Members
                         where x.Member_UserID == id
                         select x;
            foreach (var x in result)
            {
                dbcon.Members.DeleteOnSubmit(x);
            }
            try
            {
                dbcon.SubmitChanges();
            }
            catch
            {

            }
            GridView1.DataBind();

        }

        protected void removeInstructor_Click(object sender, EventArgs e)
        {

            int id;
            //finding instructor with selected id and removing them
            Int32.TryParse(rInstructor.Text, out id);
            var result = from x in dbcon.Instructors
                         where x.InstructorID == id
                         select x;
            foreach (var x in result)
            {
                dbcon.Instructors.DeleteOnSubmit(x);
            }
            try
            {
                dbcon.SubmitChanges();
            }
            catch
            {

            }
            GridView2.DataBind();

        }

        protected void addMember_Click(object sender, EventArgs e)
        {
            string fname = TextBox1.Text;
            string lname = TextBox2.Text;
            string date = TextBox3.Text;
            string pnumber = TextBox4.Text;
            string email = TextBox5.Text;
            //creating member to be added
            Member member = new Member
            {
                MemberFirstName = fname,
                MemberLastName = lname,
                MemberDateJoined = DateTime.Now,
                MemberPhoneNumber = pnumber,
                MemberEmail = email
            };
            dbcon.Members.InsertOnSubmit(member);
            //trying to add member
            try
            {
                dbcon.SubmitChanges();
            }
            catch
            {

            }
            GridView1.DataBind();
        }

        protected void addInstructor_Click(object sender, EventArgs e)
        {
            string fname = TextBox6.Text;
            string lname = TextBox7.Text;
            string pnumber = TextBox8.Text;
            //creating instructor to be added
            Instructor instructor = new Instructor
            {
                InstructorFirstName = fname,
                InstructorLastName = lname,
                InstructorPhoneNumber = pnumber
            };
            dbcon.Instructors.InsertOnSubmit(instructor);
            try
            {
                dbcon.SubmitChanges();
            }
            catch
            {

            }
            GridView1.DataBind();
        }







        protected void addSection_Click(object sender, EventArgs e)
        {
            
            string sectionName = TextBox9.Text;
            string StartDate = TextBox10.Text;
            int member_id, instructor_id, sectionfee;
            Int32.TryParse(TextBox11.Text, out member_id);
            Int32.TryParse(TextBox12.Text, out instructor_id);
            Int32.TryParse(TextBox13.Text, out sectionfee);
            //creating section to be added
            Section section = new Section
            {
                SectionName = sectionName,
                SectionStartDate = DateTime.Now,
                Member_ID = member_id,
                Instructor_ID = instructor_id,
                SectionFee = sectionfee
            };
            dbcon.Sections.InsertOnSubmit(section);
            //trying to add section
            try
            {
                dbcon.SubmitChanges();
            }
            catch
            {

            }
        }
    }
}