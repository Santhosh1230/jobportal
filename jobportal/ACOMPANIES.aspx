﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AMaster.Master" AutoEventWireup="true" CodeBehind="ACOMPANIES.aspx.cs" Inherits="jobportal.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"></asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" /> <div class="login-page">
  <div class="form">
    <form class="login-form"><h2> COMPANY LOGIN</h2>
     <%-- <input type="text" placeholder="username"/>--%><asp:TextBox  ID="TextBox1"  runat="server" placeholder="username"></asp:TextBox>
      <%--<input type="password" placeholder="password"/>--%><asp:TextBox ID="TextBox2" runat="server" placeholder="password"></asp:TextBox>
      <asp:Button ID="Button"  runat="server" Text="Login" CssClass="Button" ForeColor="#0066FF" OnClick="Button_Click" />
      <p class="message">Not registered? <a > <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/CREG.aspx">click to register</asp:HyperLink></a></p>
    </form>
  </div>
</div></asp:Content>
