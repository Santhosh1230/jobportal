<%@ Page Title="" Language="C#" MasterPageFile="~/MCOMPANIES.Master" AutoEventWireup="true" CodeBehind="CMYACCOUNT.aspx.cs" Inherits="jobportal.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 28px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> <div class="LButton" ><asp:Button ID="Button3" runat="server" Text="Logout" CssClass="registerb" OnClick="Button2_Click"/></div>   </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server"><table width="40%" border="1"  align="center">
    <tr><td><p>COMPANY NAME:</p></td><td class="auto-style1"> <asp:TextBox ID="TextBox1" runat="server" CssClass="tbus"></asp:TextBox></td></tr>
    <tr><td><p>SECTOR:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox2" runat="server" CssClass="tbps"></asp:TextBox></td></tr>
    <tr><td><p>ADDRESS:</p></td><td class="auto-style1"> <asp:TextBox ID="TextBox3" runat="server" CssClass="tbus"></asp:TextBox></td></tr>
    <tr><td>  <p>CITY:</p></td><td><asp:TextBox ID="TextBox4" runat="server" CssClass="tbps"></asp:TextBox></td></tr>
    <tr><td><p>PINCODE:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox5" runat="server" CssClass="tbus"></asp:TextBox></td></tr>
    <tr><td><p>MOBILE NO:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox6" runat="server" CssClass="tbps"></asp:TextBox></td></tr>
    <tr><td><p>TYPE:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox7" runat="server" CssClass="tbus"></asp:TextBox></td></tr>
    <tr><td><p>EMAIL:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox8" runat="server" CssClass="tbps" ReadOnly="True"></asp:TextBox></td></tr>
    
    <tr><td>
        <asp:Button ID="Button1" runat="server" Text="UPDATE" OnClick="Button1_Click" /></td><td>
            <asp:Button ID="Button2" runat="server" Text="Cancle" /></td></tr>
    
 </table>
</asp:Content>
