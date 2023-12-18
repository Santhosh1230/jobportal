using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace jobportal
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AHOME.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //            @JobTitle ,
            //@DegreeRequired ,
            //    @Skill  ,
            //   @Salary ,
            //    @Experience, 
            //    @NumberOfVacancies , 
            //    @JobDescription

            string ConStr = System.Configuration.ConfigurationManager.AppSettings["ConString"];

            SqlConnection con = new SqlConnection(ConStr);

            SqlCommand cmd = new SqlCommand("injob", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
                // Add parameters for the stored procedure.
            cmd.Parameters.AddWithValue("@cid", Session["companyid"]);
            cmd.Parameters.AddWithValue("@JobTitle", TextBox1.Text);
            cmd.Parameters.AddWithValue("@DegreeRequired", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Skill ", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Salary", TextBox4.Text);
            cmd.Parameters.AddWithValue("@Experience", TextBox5.Text);
            cmd.Parameters.AddWithValue("@NumberOfVacancies", TextBox6.Text);
            cmd.Parameters.AddWithValue("@JobDescription", TextBox7.Text);
            

            // Execute the SqlCommand to insert data into the database.
            int x = cmd.ExecuteNonQuery();

            // Close the SqlConnection when you're done.
            con.Close();
            Response.Write(x + " company Inserted Sucessfully...");

        }
    }
}
