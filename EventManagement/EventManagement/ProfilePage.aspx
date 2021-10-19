<%@ Page Trace="true" Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="EventManagementSystem.ProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>My Profile</h2>
    <p>Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblname" runat="server" Text="Label"></asp:Label>
    </p>
    <p>EmailID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblemail" runat="server" Text="Label"></asp:Label>
    </p>
    <p>Phone&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblphone" runat="server" Text="Label"></asp:Label>
    </p>
    <p>Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbladdress" runat="server" Text="Label"></asp:Label>
    </p>
    <p>Events&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnevents" runat="server" ForeColor="#3333FF" OnClick="btnevents_Click" Text="Events" />
    </p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
</asp:Content>
