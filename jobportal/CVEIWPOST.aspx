<%@ Page Title="" Language="C#" MasterPageFile="~/MCOMPANIES.Master" AutoEventWireup="true" CodeBehind="CVEIWPOST.aspx.cs" Inherits="jobportal.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> <div class="LButton" ><asp:Button ID="Button2" runat="server" Text="Logout" CssClass="registerb" OnClick="Button2_Click"/></div>   </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <br />
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="JobID" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdated="GridView1_RowUpdated" OnRowUpdating="GridView1_RowUpdating">
        <Columns>
            <asp:BoundField DataField="JobID" HeaderText="JOBID" ReadOnly="True" />
            <asp:BoundField DataField="JobTitle" HeaderText="JobTitle" />
            <asp:BoundField DataField="DegreeRequired" HeaderText="QUALIFICATION" />
            <asp:BoundField DataField="Skill" HeaderText="Skills" />
            <asp:BoundField DataField="Salary" HeaderText="CTC" />
            <asp:BoundField DataField="Experience" HeaderText="Experience" />
            <asp:BoundField DataField="NumberOfVacancies" HeaderText="NumberOfVacancies" />
            <asp:CommandField ButtonType="Button" ShowEditButton="True" />
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
<br />
</asp:Content>
