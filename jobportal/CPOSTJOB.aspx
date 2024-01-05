<%@ Page Title="" Language="C#" MasterPageFile="~/MCOMPANIES.Master" AutoEventWireup="true" CodeBehind="CPOSTJOB.aspx.cs" Inherits="jobportal.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        height: 28px;
    }
</style>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"><div class="LButton" ><asp:Button ID="Button2" runat="server" Text="Logout" CssClass="registerb" OnClick="Button2_Click" />
           </div>     

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server"><h3>POST A JOB VACCANCY</h3><div >
    
    <table width="40%" border="1"  align="center"><tr><td><p>JOB TITLE:</p></td><td><asp:TextBox ID="TextBox1" runat="server" CssClass="tbus"></asp:TextBox></td></tr>
           <tr><td><p>DEGREE:</p></td><td><asp:TextBox ID="TextBox2" runat="server" CssClass="tbps"></asp:TextBox></td></tr>
            <tr><td class="auto-style1"><p>SKILL:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox3" runat="server" CssClass="tbus"></asp:TextBox></td></tr>
            <tr><td><p>SALARY:</p></td><td><asp:TextBox ID="TextBox4" runat="server" CssClass="tbps"></asp:TextBox></td></tr>
            <tr><td><p>EXPERIENCE:</p></td><td><asp:TextBox ID="TextBox5" runat="server" CssClass="tbus" TextMode="Number"></asp:TextBox></td></tr>
            <tr><td><p>NUMBER OF VACANCY:</p></td><td><asp:TextBox ID="TextBox6" runat="server" CssClass="tbps" TextMode="Number"></asp:TextBox></td></tr>
            <tr><td><p>JOB DISCRIPTION:</p></td><td><asp:TextBox ID="TextBox7" runat="server" CssClass="tbus" TextMode="MultiLine"></asp:TextBox></td></tr>
            <tr><td><asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /></td><td><asp:Button ID="Button3" runat="server" Text="Cancel" /></td></tr>
            
    </table>
    
    </div>
    
    

</asp:Content>