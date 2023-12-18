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
    public partial class WebForm12 : System.Web.UI.Page
    {
        string ConStr = System.Configuration.ConfigurationManager.AppSettings["ConString"];
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection(ConStr);
                SqlCommand cmd = new SqlCommand("discomid", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@Email", Session["company"]);
                SqlDataReader discan = cmd.ExecuteReader();
                while (discan.Read())
                {
                    TextBox1.Text = discan.GetValue(1).ToString();
                    TextBox2.Text = discan.GetValue(2).ToString();
                    TextBox3.Text = discan.GetValue(3).ToString();
                    TextBox4.Text = discan.GetValue(4).ToString();
                    TextBox5.Text = discan.GetValue(5).ToString();
                    TextBox6.Text = discan.GetValue(6).ToString();
                    TextBox7.Text = discan.GetValue(7).ToString();
                    TextBox8.Text = discan.GetValue(8).ToString();
                    
                                    }
                con.Close();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConStr);
            SqlCommand cmd = new SqlCommand("upCompanyInfo", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            cmd.Parameters.AddWithValue("@CompanyName", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Sector", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Address", TextBox3.Text);
            cmd.Parameters.AddWithValue("@City", TextBox4.Text);
            cmd.Parameters.AddWithValue("@Pincode", TextBox5.Text);
            cmd.Parameters.AddWithValue("@MobileNo", TextBox6.Text);
            cmd.Parameters.AddWithValue("@Type", TextBox7.Text);
            cmd.Parameters.AddWithValue("@Email", TextBox8.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Write("Company Details updated successfully.");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AHOME.aspx");
        }
    }
}