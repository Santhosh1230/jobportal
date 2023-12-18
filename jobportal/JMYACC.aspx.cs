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
    public partial class WebForm14 : System.Web.UI.Page
    {
        string ConStr = System.Configuration.ConfigurationManager.AppSettings["ConString"];

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
            SqlConnection con = new SqlConnection(ConStr);
            SqlCommand cmd = new SqlCommand("discan", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@cemail", Session["user"]);
            SqlDataReader discan = cmd.ExecuteReader();
           while(discan.Read())
            {
                TextBox1.Text = discan.GetValue(1).ToString();
                TextBox2.Text = discan.GetValue(2).ToString();
                TextBox3.Text = discan.GetValue(3).ToString();
                TextBox4.Text = discan.GetValue(4).ToString();
                TextBox5.Text = discan.GetValue(5).ToString();
                TextBox6.Text = discan.GetValue(6).ToString();
                TextBox7.Text = discan.GetValue(7).ToString();
                TextBox8.Text = discan.GetValue(8).ToString();
                TextBox9.Text = discan.GetValue(9).ToString();
                TextBox10.Text = discan.GetValue(10).ToString();
                TextBox11.Text = discan.GetValue(11).ToString();
                TextBox12.Text = discan.GetValue(12).ToString();
                TextBox13.Text = discan.GetValue(13).ToString();

            }
                con.Close();
            }
            



        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConStr);
            SqlCommand cmd = new SqlCommand("upcan", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            cmd.Parameters.AddWithValue("@cfirstname", TextBox1.Text);
            cmd.Parameters.AddWithValue("@clastname", TextBox2.Text);
            cmd.Parameters.AddWithValue("@caddress", TextBox3.Text);
            cmd.Parameters.AddWithValue("@ccity", TextBox4.Text);
            cmd.Parameters.AddWithValue("@cpincode", TextBox5.Text);
            cmd.Parameters.AddWithValue("@cmobile", TextBox6.Text);
            cmd.Parameters.AddWithValue("@cgender", TextBox7.Text);
            cmd.Parameters.AddWithValue("@cdob", TextBox8.Text);
            cmd.Parameters.AddWithValue("@cdegree", TextBox9.Text);
            cmd.Parameters.AddWithValue("@cskill", TextBox10.Text);
            cmd.Parameters.AddWithValue("@cyop", TextBox11.Text);
            cmd.Parameters.AddWithValue("@cexperiance", TextBox12.Text);

            cmd.Parameters.AddWithValue("@cemail", TextBox13.Text);
            //string sqlQuery = "UPDATE candidates SET cfirstname = @cfirstname,@clastname,@caddress  ,@ccity ,@cpincode ,@cmobile ,@cgender ,@cdob  ,@cdegree ,@cskill ,@cyop , @cexperiance WHERE cemail = @cemail";
            //Response.Write("SQL Query: " + sqlQuery + Session["user"]); // Add this line before cmd.ExecuteNonQuery();

            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Write("Candidate updated successfully.");

            //if (x > 0)
            //{

            //}
            //else
            //{
            //    Response.Write("No candidate was updated. Please check the email address.");
            //}
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AHOME.aspx");
        }
    }
}