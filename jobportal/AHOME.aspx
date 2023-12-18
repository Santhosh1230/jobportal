<%@ Page Title="" Language="C#" MasterPageFile="~/AMaster.Master" AutoEventWireup="true" CodeBehind="AHOME.aspx.cs" Inherits="jobportal.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="LButton" ><asp:Button ID="Button1" runat="server" Text="LOGIN" Class="loginb" OnClick="Button1_Click" /><asp:Button ID="Button2" runat="server" Text="Register" CssClass="registerb" OnClick="Button2_Click" />
           </div>     
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server" ><div align="center"><h1>Find JOBS From Top companies</h1></br>
<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AJOB.aspx">Login To continue</asp:HyperLink> </div>   </asp:Content>
