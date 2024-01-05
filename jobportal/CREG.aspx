<%@ Page Title="" Language="C#" MasterPageFile="~/AMaster.Master" AutoEventWireup="true" CodeBehind="CREG.aspx.cs" Inherits="jobportal.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"><link href="StyleSheet1.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 276px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server"><table width="40%" border="1"  align="center">
    <tr><td><p>COMPANY NAME:</p></td><td class="auto-style1"> <asp:TextBox ID="TextBox1" runat="server" CssClass="tbus"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" EnableClientScript="False" ErrorMessage="please fill this" ForeColor="Red"></asp:RequiredFieldValidator>
        </td></tr>
    <tr><td><p>SECTOR:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox2" runat="server" CssClass="tbps"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" EnableClientScript="False" ErrorMessage="please fill this" ForeColor="Red"></asp:RequiredFieldValidator>
        </td></tr>
    <tr><td><p>ADDRESS:</p></td><td class="auto-style1"> <asp:TextBox ID="TextBox3" runat="server" CssClass="tbus"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" EnableClientScript="False" ErrorMessage="please fill this" ForeColor="Red"></asp:RequiredFieldValidator>
        </td></tr>
    <tr><td>  <p>CITY:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox4" runat="server" CssClass="tbps"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" EnableClientScript="False" ErrorMessage="please fill this" ForeColor="Red"></asp:RequiredFieldValidator>
        </td></tr>
    <tr><td><p>PINCODE:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox5" runat="server" CssClass="tbus"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" EnableClientScript="False" ErrorMessage="please fill this" ForeColor="Red"></asp:RequiredFieldValidator>
        </td></tr>
    <tr><td><p>MOBILE NO:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox6" runat="server" CssClass="tbps"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6" EnableClientScript="False" ErrorMessage="please fill this" ForeColor="Red"></asp:RequiredFieldValidator>
        </td></tr>
    <tr><td><p>TYPE:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox7" runat="server" CssClass="tbus"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox7" EnableClientScript="False" ErrorMessage="please fill this" ForeColor="Red"></asp:RequiredFieldValidator>
        </td></tr>
    <tr><td><p>EMAIL:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox8" runat="server" CssClass="tbps"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox8" EnableClientScript="False" ErrorMessage="please fill this" ForeColor="Red"></asp:RequiredFieldValidator>
        </td></tr>
    <tr><td><p>PASSWORD:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox9" runat="server" CssClass="tbus"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox9" EnableClientScript="False" ErrorMessage="please fill this" ForeColor="Red"></asp:RequiredFieldValidator>
        </td></tr>
    <tr><td><p>REENTER-PASWORD:</p></td><td class="auto-style1"><asp:TextBox ID="TextBox10" runat="server" CssClass="tbps"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextBox10" EnableClientScript="False" ErrorMessage="please fill this" ForeColor="Red"></asp:RequiredFieldValidator>
        </td></tr>
    <tr><td>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /></td><td class="auto-style1">
            <asp:Button ID="Button2" runat="server" Text="Cancle" /></td></tr>
    
 </table>
    <div class ="reg"><div class="us">
    
     
                                                                                                       </div><div class="ps">
       
       
                                                                                                             </div><div class="us">
    
     
                                                                                                       </div><div class="ps">
     
       
                                                                                                             </div>
        <div class="us">
    
      
                                                                                                       </div><div class="ps">
       
       
                                                                                                             </div><div class="us">
    
      
                                                                                                       </div><div class="ps">
       
       
                                                                                                             </div>
        <div class="us">
          
                                                                                                       </div><div class="ps">
       
       
                                                                                                             </div><div class="submb">
                                                                                                                 
                                                                                                                   <%--<asp:Button ID="Button1" runat="server" Text="Submit" />
                                                                                                                   <asp:Button ID="Button2" runat="server" Text="Cancel" />--%>

                                                                                                                   </div></div>
</asp:Content>
