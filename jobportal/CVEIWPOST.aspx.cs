﻿using System;
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
            GridView1.DataSource = pjob;
            GridView1.DataBind();
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
            
            BindToGrid();

        }

      

        //protected void DataGrid1_UpdateCommand(object source, DataGridCommandEventArgs e)
        //{
        //    TextBox Jobt = (TextBox)e.Item.Cells[0].Controls[0];
        //    TextBox degree = (TextBox)e.Item.Cells[1].Controls[0];
        //    TextBox skil = (TextBox)e.Item.Cells[2].Controls[0];
        //    TextBox exp = (TextBox)e.Item.Cells[3].Controls[0];
        //    TextBox noofvac = (TextBox)e.Item.Cells[4].Controls[0];
        //    TextBox sal = (TextBox)e.Item.Cells[5].Controls[0];
        //    TextBox jobdis = (TextBox)e.Item.Cells[6].Controls[0];
        //    cmd.CommandText = "update from cjob set JobTitle=@JobTitle,DegreeRequired=@DegreeRequired ,Skill=@Skill ,Salary=@Salary , Experience=@Experience, NumberOfVacancies=@NumberOfVacancies  ,JobDescription=@JobDescription where JobId=@JobId" + DataGrid1.DataKeys[e.Item.ItemIndex];
        //    cmd.Parameters.AddWithValue("@DegreeRequired", degree.Text);
        //    cmd.Parameters.AddWithValue("@Skill", skil.Text);
        //    cmd.Parameters.AddWithValue("@Salary", sal.Text);
        //    cmd.Parameters.AddWithValue("@Experience", exp.Text);
        //    cmd.Parameters.AddWithValue("@NumberOfVacancies", noofvac.Text);
        //    cmd.Parameters.AddWithValue("@JobDescription", jobdis.Text);
        //    cmd.Parameters.AddWithValue("@JobId", DataGrid1.DataKeys[e.Item.ItemIndex]);
        //    con.Open();
            
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    BindToGrid();
        //}

        protected void DataGrid1_CancelCommand(object source, DataGridCommandEventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindToGrid();

        }

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = int.Parse(GridView1.DataKeys[e.RowIndex].Value.ToString());
            string titl = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string quali = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string skills = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            string ctc = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            string exp = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text;
            string jd = ((TextBox)GridView1.Rows[e.RowIndex].Cells[6].Controls[0]).Text;
            con = new SqlConnection(ConStr);
            
            con.Open();
            string up = "update cjob set JobTitle='" + titl + "',DegreeRequired ='"+quali+"' ,Skill='"+skills+"'  ,Salary = '"+ctc+"' , Experience ='" +exp+"', NumberOfVacancies ='" +exp+ " ' where JobId ='"+ i+"'";
            cmd = new SqlCommand(up,con);
            int t= cmd.ExecuteNonQuery();
            if (t > 0)
            {
                Response.Write("<script>alert('updated')</script>");
            }
              con.Close();
              BindToGrid();





        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            con = new SqlConnection(ConStr);
            con.Open();
            string delete = "delete from cjob where JobId='" + id + "'";
            cmd = new SqlCommand(delete, con);
            int t = cmd.ExecuteNonQuery();
            if (t > 0)
            {
                Response.Write("<script>alert('deletedted')</script>");
            }
            con.Close();
            BindToGrid();

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindToGrid();
        }
    }
}