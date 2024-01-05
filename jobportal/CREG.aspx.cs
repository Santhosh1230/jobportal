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
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)

        { if (TextBox1.Text == ""|| TextBox2.Text == "")
            {
                Response.Write("<script>alert('restertation failed')</script>");
            }
            else
            {

                string ConStr = System.Configuration.ConfigurationManager.AppSettings["ConString"];

                SqlConnection con = new SqlConnection(ConStr);

                SqlCommand cmd = new SqlCommand("InsertCompanyInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                // Add parameters for the stored procedure.
                cmd.Parameters.AddWithValue("@CompanyName", TextBox1.Text);
                cmd.Parameters.AddWithValue("@Sector", TextBox2.Text);
                cmd.Parameters.AddWithValue("@Address", TextBox3.Text);
                cmd.Parameters.AddWithValue("@City", TextBox4.Text);
                cmd.Parameters.AddWithValue("@Pincode", TextBox5.Text);
                cmd.Parameters.AddWithValue("@MobileNo", TextBox6.Text);
                cmd.Parameters.AddWithValue("@Type", TextBox7.Text);
                cmd.Parameters.AddWithValue("@Email", TextBox8.Text);
                cmd.Parameters.AddWithValue("@Password", TextBox9.Text);

                // Execute the SqlCommand to insert data into the database.
                int x = cmd.ExecuteNonQuery();

                // Close the SqlConnection when you're done.
                con.Close();
                Response.Write(x + " company Inserted Sucessfully...");
            }

        }
    }
}