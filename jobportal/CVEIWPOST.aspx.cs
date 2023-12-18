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
    public partial class WebForm13 : System.Web.UI.Page
    {
        string ConStr = System.Configuration.ConfigurationManager.AppSettings["ConString"];

        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConStr);


            cmd = new SqlCommand();
            cmd.Connection = con;
            if (!IsPostBack)
                BindToGrid();
 
            
            
        }
        public void BindToGrid()
        {
            cmd.CommandText = "pjob";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cid", Session["companyid"]);
            con.Open();
           SqlDataReader pjob = cmd.ExecuteReader();
            DataGrid1.DataSource = pjob;
              DataGrid1.DataBind();
            //using(SqlDataAdapter da = new SqlDataAdapter(cmd)){
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    DataGrid1.DataSource = dt;
            //    DataGrid1.DataBind();
            //}
            con.Close();

        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AHOME.aspx");

        }

        protected void DataGrid1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DataGrid1_EditCommand(object source, DataGridCommandEventArgs e)
        {
            DataGrid1.EditItemIndex = e.Item.ItemIndex;
            BindToGrid();

        }

        protected void DataGrid1_DeleteCommand(object source, DataGridCommandEventArgs e)
        {
            cmd.CommandText = "delete from cjob where JobId=" + DataGrid1.DataKeys[e.Item.ItemIndex];
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            DataGrid1.EditItemIndex = -1;
            
            BindToGrid();
        }

        protected void DataGrid1_UpdateCommand(object source, DataGridCommandEventArgs e)
        {
            TextBox Jobt = (TextBox)e.Item.Cells[0].Controls[0];
            TextBox degree = (TextBox)e.Item.Cells[1].Controls[0];
            TextBox skil = (TextBox)e.Item.Cells[2].Controls[0];
            TextBox exp = (TextBox)e.Item.Cells[3].Controls[0];
            TextBox noofvac = (TextBox)e.Item.Cells[4].Controls[0];
            TextBox sal = (TextBox)e.Item.Cells[5].Controls[0];
            TextBox jobdis = (TextBox)e.Item.Cells[6].Controls[0];
            cmd.CommandText = "update from cjob set JobTitle=@JobTitle,DegreeRequired=@DegreeRequired ,Skill=@Skill ,Salary=@Salary , Experience=@Experience, NumberOfVacancies=@NumberOfVacancies  ,JobDescription=@JobDescription where JobId=@JobId" + DataGrid1.DataKeys[e.Item.ItemIndex];
            cmd.Parameters.AddWithValue("@DegreeRequired", degree.Text);
            cmd.Parameters.AddWithValue("@Skill", skil.Text);
            cmd.Parameters.AddWithValue("@Salary", sal.Text);
            cmd.Parameters.AddWithValue("@Experience", exp.Text);
            cmd.Parameters.AddWithValue("@NumberOfVacancies", noofvac.Text);
            cmd.Parameters.AddWithValue("@JobDescription", jobdis.Text);
            cmd.Parameters.AddWithValue("@JobId", DataGrid1.DataKeys[e.Item.ItemIndex]);
            con.Open();
            
            cmd.ExecuteNonQuery();
            con.Close();
            BindToGrid();
        }

        protected void DataGrid1_CancelCommand(object source, DataGridCommandEventArgs e)
        {

        }
    }
}