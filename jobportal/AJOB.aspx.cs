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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            string ConStr = System.Configuration.ConfigurationManager.AppSettings["ConString"];

            SqlConnection con = new SqlConnection(ConStr);

            SqlCommand cmd = new SqlCommand("clog", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@cemail", TextBox1.Text);
            cmd.Parameters.AddWithValue("@cpass", TextBox2.Text);
            SqlDataReader clog = cmd.ExecuteReader();
            clog.Read();
            int cx = int.Parse(clog[0].ToString());
            con.Close();
            Session["user"] = TextBox1.Text;
            if (cx != 0)
            {
                Response.Redirect("JHOME.aspx");
            }
            else
            {
                string script = "loginfailed";
                ClientScript.RegisterStartupScript(this.GetType(), "PopupScript", script);
            
            }

        }
    }
}