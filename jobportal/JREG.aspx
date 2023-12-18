<%@ Page Title="" Language="C#" MasterPageFile="~/AMaster.Master" AutoEventWireup="true" CodeBehind="JREG.aspx.cs" Inherits="jobportal.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"><link href="StyleSheet1.css" rel="stylesheet" /><style type="text/css">
        .auto-style1 {
            width: 157px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server"><table width="40%" border="1"  align="center">
    <tr><td><p>FIRST NAME:</p></td><td class="auto-style1"> <asp:TextBox ID="TextBox1" runat="server" CssClass="tbus"></asp:TextBox></td></tr>
    <tr><td><p>LAST NAME:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox2" runat="server" CssClass="tbps"></asp:TextBox></td></tr>
    <tr><td><p>ADDRESS:</p></td><td class="auto-style1"> <asp:TextBox ID="TextBox3" runat="server" CssClass="tbus"></asp:TextBox></td></tr>
    <tr><td>  <p>CITY:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox4" runat="server" CssClass="tbps"></asp:TextBox></td></tr>
    <tr><td><p>PINCODE:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox5" runat="server" CssClass="tbus"></asp:TextBox></td></tr>
    <tr><td><p>MOBILE NO:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox6" runat="server" CssClass="tbps"></asp:TextBox></td></tr>
    <tr><td><p>GENDER:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox7" runat="server" CssClass="tbus"></asp:TextBox></td></tr>
    <tr><td><p>DATE OF BIRTH:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox8" runat="server" CssClass="tbus" TextMode="Date"></asp:TextBox></td></tr>
     <tr><td><p>DEGREE:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox9" runat="server" CssClass="tbps"></asp:TextBox></td></tr>
    <tr><td><p>SKILL:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox10" runat="server" CssClass="tbus"></asp:TextBox></td></tr>
     <tr><td><p>YEAR OF PASSED OUT:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox11" runat="server" CssClass="tbps"></asp:TextBox></td></tr>
    <tr><td><p>EXPERIENCE:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox12" runat="server" CssClass="tbps"></asp:TextBox></td></tr>
     <tr><td><p>EMAIL:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox13" runat="server" CssClass="tbps"></asp:TextBox></td></tr>
    <tr><td><p>PASSWORD:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox14" runat="server" CssClass="tbus"></asp:TextBox></td></tr>
    <tr><td><p>REENTER-PASWORD:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox15" runat="server" CssClass="tbps"></asp:TextBox></td></tr>
    <tr><td>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" />
        </td><td>
            <asp:Button ID="Button1" runat="server" Text="Cancel" />
        </td></tr>
    
    
</asp:Content>
