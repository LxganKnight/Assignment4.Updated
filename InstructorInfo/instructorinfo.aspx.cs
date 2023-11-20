using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4.Updated.InstructorInfo
{
    public partial class instructorinfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Count != 0)
            {
                if (HttpContext.Current.Session["userType"].ToString().Trim() == "Instructor")
                {
                    Session.Clear();
                    Session.RemoveAll();
                    Session.Abandon();
                    Session.Abandon();
                    FormsAuthentication.SignOut();
                    Response.Redirect("Login.aspx", true);
                }

                string firstname = (from x in dbcon.InstructorID
                                    where x.InstructorID == HttpContext.Current.Session["userID"].ToString()
                                    select x.InstructorFirstName);
                string lastname = (from x in dbcon.InstructorID
                                    where x.InstructorID == HttpContext.Current.Session["userID"].ToString()
                                    select x.InstructorLastName);
                Label1.Text = firstname;
                Label2.Text = lastname;

                /*
                NetUser myUser = (from x in dbcon.NetUsers
                                  where x.UserName == HttpContext.Current.Session["username"].ToString()
                                  && x.UserPassword == HttpContext.Current.Session["password"].ToString()
                                  select x).First();
                */

                


            }
        }

        protected System.Void Page_Load(System.Object sender, System.EventArgs e)
        {

        }
    }
}