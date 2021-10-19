<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="UserInformation.aspx.cs" Inherits="EventManagementSystem.UserInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>User Information</h2>
    <p>
        <asp:GridView ID="gvuserinfo" runat="server" AutoGenerateColumns="False" OnRowCommand="gvuserinfo_RowCommand" OnRowDeleting="gvuserinfo_RowDeleting" OnRowEditing="gvuserinfo_RowEditing">
            <Columns>
                <asp:BoundField DataField="user_id" HeaderText="User ID" />
                <asp:BoundField DataField="first_name" HeaderText="Name" />
                <asp:BoundField DataField="email" HeaderText="Email ID" />
                <asp:BoundField DataField="address" HeaderText="Address" />
            </Columns>
        </asp:GridView>
        <br />
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
