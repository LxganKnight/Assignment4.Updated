using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4.Updated.MemberInfo
{
    public partial class memberpage : System.Web.UI.Page
    {
        KSchoolDataContext dbcon;
        string connString = ConfigurationManager.ConnectionStrings["KarateSchool_1_ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string currentUserType = (string)Session["UserType"];          
                        
            dbcon = new KSchoolDataContext(connString);
            
                var myMember = dbcon.Members.FirstOrDefault(m => m.Member_UserID == (int)Session["UserID"]);
                try
                {
                lblMemberName.Text = myMember.MemberFirstName + " " + myMember.MemberLastName;
            }
            catch (Exception ex)
            {

            }
            var records = from member in dbcon.Members
                          join section in dbcon.Sections on member.Member_UserID equals section.Member_ID
                          join instructor in dbcon.Instructors on section.Instructor_ID equals instructor.InstructorID
                          where member.Member_UserID == (int)Session["UserID"]
                          select new
                          {
                              section.SectionName,
                              section.SectionID,
                             section.SectionFee,
                              section.SectionStartDate,
                              instructor.InstructorFirstName,
                              instructor.InstructorLastName,


                          };

            decimal totalPayments = records.Sum(section => section.SectionFee);
            lblTotalCost.Text = totalPayments.ToString("c");


            GridView1.DataSource = records;
            GridView1.DataBind();

        }
    }
}