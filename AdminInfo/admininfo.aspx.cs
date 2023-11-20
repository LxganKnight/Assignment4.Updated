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
        string connString = ConfigurationManager.ConnectionStrings["KarateSchool_1_ConnectionString"].ConnectionString;

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
                    FormsAuthentication.SignOut();
                    Response.Redirect("Login.aspx", true);
                }

            }
        }

        protected void removeMember_Click(object sender, EventArgs e)
        {
            
            int id;

            Int32.TryParse(rMember.Text, out id);
            var result = from x in dbconn.Member
                         where x.Member_UserID == id
                         select x;
            foreach (var x in result)
            {
                dbconn.Member.DeleteOnSubmit(x);
            }
            try
            {
                dbconn.SubmitChanges();
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
            var result = from x in dbconn.Instructor
                         where x.Instructor == id
                         select x;
            foreach (var x in result)
            {
                dbconn.Instructor.DeleteOnSubmit(x);
            }
            try
            {
                dbconn.SubmitChanges();
            }
            catch
            {

            }
            GridView2.DataBind();

        }

        protected void addMember_Click(object sender, EventArgs e)
        {
            string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Noah Nickman\\Documents\\nickman213\\nickman213a3p2\\App_Data\\AutoRental.mdf\";Integrated Security=True;Connect Timeout=30";
            dbconn = new DataClasses1DataContext(conn);
            string mName = TextBox4.Text;
            int id, cargoSpace;
            Int32.TryParse(TextBox3.Text, out id);
            Int32.TryParse(TextBox2.Text, out cargoSpace);
            Member member = new Member
            {
                ModelName = mName,
                AutoTypeID = id,
                CargoSpace = cargoSpace
            };
            dbconn.Models.InsertOnSubmit(model);
            try
            {
                dbconn.SubmitChanges();
            }
            catch
            {

            }
            GridView1.DataBind();
        }
    }
}