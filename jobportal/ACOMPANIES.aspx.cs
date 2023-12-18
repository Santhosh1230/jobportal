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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {

            string ConStr = System.Configuration.ConfigurationManager.AppSettings["ConString"];

            SqlConnection con = new SqlConnection(ConStr);

            SqlCommand cmd = new SqlCommand("comlog", con);
            SqlCommand cmds = new SqlCommand("discomid", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmds.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@Email", TextBox1.Text);
            cmds.Parameters.AddWithValue("@Email", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Password", TextBox2.Text);
            SqlDataReader clog = cmd.ExecuteReader();
            

            clog.Read();
            
           
            int x = int.Parse(clog[0].ToString());
            
            con.Close();
            Session["company"] = TextBox1.Text;
            Response.Write(x + " Sucessfully...");
            con.Open();
            
            //cmds.Parameters.AddWithValue("@Email", Session["company"]);
            SqlDataReader companytable = cmds.ExecuteReader();
            companytable.Read();
            Session["companyid"] = int.Parse(companytable[0].ToString());

            con.Close();
            

            if (x != 0)
            {
                Response.Redirect("CHOME.aspx");
            }


        }
    }
}