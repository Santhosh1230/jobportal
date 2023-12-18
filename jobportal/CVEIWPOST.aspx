<%@ Page Title="" Language="C#" MasterPageFile="~/MCOMPANIES.Master" AutoEventWireup="true" CodeBehind="CVEIWPOST.aspx.cs" Inherits="jobportal.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> <div class="LButton" ><asp:Button ID="Button2" runat="server" Text="Logout" CssClass="registerb" OnClick="Button2_Click"/></div>   </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <br />
    <asp:DataGrid ID="DataGrid1" runat="server" OnCancelCommand="DataGrid1_CancelCommand" OnDeleteCommand="DataGrid1_DeleteCommand" OnEditCommand="DataGrid1_EditCommand" OnSelectedIndexChanged="DataGrid1_SelectedIndexChanged" OnUpdateCommand="DataGrid1_UpdateCommand">
        <Columns>
            <asp:EditCommandColumn CancelText="Cancel" EditText="Edit" UpdateText="Update"></asp:EditCommandColumn>
            <asp:ButtonColumn CommandName="Delete" Text="Delete"></asp:ButtonColumn>
        </Columns>
    </asp:DataGrid>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
<br />
</asp:Content>
