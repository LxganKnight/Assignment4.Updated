using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4.Updated.AdminInfo
{
    public partial class admininfo : System.Web.UI.Page
    {
        KSchoolDataContext dbcon;
        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Noah Nickman\\source\\repos\\Assignment4Updated\\App_Data\\KarateSchool(1).mdf\";Integrated Security=True;Connect Timeout=30";

        protected void Page_Load(object sender, EventArgs e)
        {
            dbcon = new KSchoolDataContext(connString);


            if (Session.Count != 0)
            {
                if (HttpContext.Current.Session["userType"].ToString().Trim() == "Administrator")
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
            
            int id;

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

            Member member = new Member
            {
                MemberFirstName = fname,
                MemberLastName = lname,
                MemberDateJoined = date,
                MemberPhoneNumber = pnumber,
                MemberEmail = email
            };
            dbcon.Members.InsertOnSubmit(member);
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

            Section section = new Section
            {
                SectionName = sectionName,
                SectionStartDate = StartDate,
                Member_ID = member_id,
                Instructor_ID = instructor_id,
                SectionFee = sectionfee
            };
            dbcon.Sections.InsertOnSubmit(section);
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