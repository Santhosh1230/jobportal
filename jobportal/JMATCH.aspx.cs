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
    public partial class WebForm15 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ConStr = System.Configuration.ConfigurationManager.AppSettings["ConString"];

            SqlConnection con = new SqlConnection(ConStr);
            SqlCommand cmd = new SqlCommand("jobm", con);

            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            
            SqlDataReader ds = cmd.ExecuteReader();

           
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AHOME.aspx");

        }
    }
}