<%@ Page Title="" Language="C#" MasterPageFile="~/MJOB.Master" AutoEventWireup="true" CodeBehind="JMYACC.aspx.cs" Inherits="jobportal.WebForm14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> <div class="LButton" ><asp:Button ID="Button2" runat="server" Text="Logout" CssClass="registerb" OnClick="Button2_Click"/></div>   </asp:Content> 
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        <%--@cfirstname,@clastname,@caddress  ,@ccity ,@cpincode ,@cmobile ,@cgender ,@cdob  ,@cdegree ,@cskill ,@cyop , @cexperiance,@cemail,@cpass)--%>
    </p>
    <asp:Label ID="Label1" runat="server" Text="Firstname :"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    &nbsp;&nbsp;
    <br />
    <asp:Label ID="Label2" runat="server" Text="Lastname :"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>&nbsp;&nbsp; <br />
    <asp:Label ID="Label3" runat="server" Text="Address :"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" Text="City :"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="PIN-Code :"></asp:Label>
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <asp:Label ID="Label6" runat="server" Text="MOBILE NO:"></asp:Label>
    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    &nbsp;
    <asp:Label ID="Label7" runat="server" Text="Gender"></asp:Label>
    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label8" runat="server" Text="Data Of Birth :"></asp:Label>
    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    &nbsp;<asp:Label ID="Label9" runat="server" Text="Degree :"></asp:Label>
    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label10" runat="server" Text="Skill :"></asp:Label>
    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label11" runat="server" Text="Year Of Passedout :"></asp:Label>
    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <asp:Label ID="Label12" runat="server" Text="Experience:"></asp:Label>
    <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <asp:Label ID="Label13" runat="server" Text="Mail-ID :"></asp:Label>
    <asp:TextBox ID="TextBox13" runat="server" ReadOnly="True"></asp:TextBox>
    &nbsp;&nbsp;
    <br />
    <asp:Button ID="Button1" runat="server" Text="update" OnClick="Button1_Click" />
    
    
    <br />
    
    
</asp:Content>
