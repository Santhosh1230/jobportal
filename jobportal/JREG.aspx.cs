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
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string ConStr = System.Configuration.ConfigurationManager.AppSettings["ConString"];

            SqlConnection con = new SqlConnection(ConStr);


            SqlCommand cmd = new SqlCommand("incan", con);


            cmd.CommandType = CommandType.StoredProcedure;
            //@cfirstname,@clastname,@caddress  ,@ccity ,@cpincode ,@cmobile ,@cgender ,@cdob  ,@cdegree ,@cskill ,@cyop , @cexperiance,@cemail,@cpass)

            con.Open();

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
            cmd.Parameters.AddWithValue("@cpass", TextBox14.Text);
            int x = cmd.ExecuteNonQuery();

            con.Close();


            Response.Write(x + " Student Inserted Sucessfully...");
        }
    }
}