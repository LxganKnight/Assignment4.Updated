using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4.Updated
{
    
    public partial class Login : System.Web.UI.Page
    {
        KSchoolDataContext dbcon;
        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Noah Nickman\\source\\repos\\Assignment4Updated\\App_Data\\KarateSchool(1).mdf\";Integrated Security=True;Connect Timeout=30";

        protected void Page_Load(object sender, EventArgs e)
        {
            dbcon = new KSchoolDataContext(connString);
        }
        
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string username = Login1.UserName;
            string password = Login1.Password;      

            //taking username and password from the login menu

            HttpContext.Current.Session["username"] = username;
            HttpContext.Current.Session["password"] = password;

            NetUser myUser = (from x in dbcon.NetUsers
                              where x.UserName == HttpContext.Current.Session["username"].ToString()
                              && x.UserPassword == HttpContext.Current.Session["password"].ToString()
                              select x).FirstOrDefault();


            if (myUser != null)
            {
                //Add UserID and User type to the Session
                HttpContext.Current.Session["userID"] = myUser.UserID;
                HttpContext.Current.Session["userType"] = myUser.UserType;

            }
            //if & else if statements to take the user to their page
            if (myUser != null && HttpContext.Current.Session["userType"].ToString().Trim() == "Member")
            {

                FormsAuthentication.RedirectFromLoginPage(HttpContext.Current.Session["username"].ToString(), true);

                Response.Redirect("~/MemberInfo/memberpage.aspx");
            }
            else if (myUser != null && HttpContext.Current.Session["userType"].ToString().Trim() == "Instructor")
            {

                FormsAuthentication.RedirectFromLoginPage(HttpContext.Current.Session["username"].ToString(), true);

                Response.Redirect("~/InstructorInfo/instructorinfo.aspx");
            }
            else if (myUser != null && HttpContext.Current.Session["userType"].ToString().Trim() == "Administrator")
            {

                FormsAuthentication.RedirectFromLoginPage(HttpContext.Current.Session["username"].ToString(), true);

                Response.Redirect("~/AdminInfo/admininfo.aspx");
            }
            else
                Response.Redirect("logon.aspx", true);


        }
    }
}