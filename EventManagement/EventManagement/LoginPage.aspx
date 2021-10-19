<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="EventManagementSystem.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Login Page</h2>
    <hr />
    <p>&nbsp;</p>
    <table class="auto-style1">
        
        <tr>
            
            <td>Email ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtloginemailid" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtloginpassword" runat="server" TextMode="Password"></asp:TextBox>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="txtsubmit" runat="server" ForeColor="#3333FF" Text="Submit" OnClick="txtsubmit_Click" />
                &nbsp;<asp:Button ID="txtresetlogin" runat="server" ForeColor="#3333FF" PostBackUrl="~/LoginPage.aspx" Text="Reset" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="txtloginlabel" runat="server" Text=""></asp:Label>
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="txtlabel" runat="server" Text="No Account ? "></asp:Label>
                <asp:HyperLink ID="txthyperlink" runat="server" ForeColor="#3333FF" NavigateUrl="~/UserRegistration.aspx">Create One !</asp:HyperLink>
                <br />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
