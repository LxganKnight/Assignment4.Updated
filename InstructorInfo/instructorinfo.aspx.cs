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
        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Noah Nickman\\source\\repos\\Assignment4Updated\\App_Data\\KarateSchool(1).mdf\";Integrated Security=True;Connect Timeout=30";

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
                int id;
                Int32.TryParse(HttpContext.Current.Session["userID"].ToString(), out id);

                string firstname = (from x in dbcon.Instructors
                                    where x.InstructorID == id
                                    select x.InstructorFirstName).ToString();
                string lastname = (from x in dbcon.Instructors
                                    where x.InstructorID == id
                                    select x.InstructorLastName).ToString();
                Label1.Text = firstname;
                Label2.Text = lastname;


                


            }
        }

        protected System.Void Page_Load(System.Object sender, System.EventArgs e)
        {

        }
    }
}