<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="EventInformation.aspx.cs" Inherits="EventManagementSystem.EventInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Event Information</h2>
    <p>
        <asp:GridView ID="gvEventInfo" runat="server" AutoGenerateColumns="False" OnRowCommand="gvEventInfo_RowCommand" OnRowDeleting="gvEventInfo_RowDeleting" OnRowEditing="gvEventInfo_RowEditing">
            <Columns>
                <asp:BoundField DataField="event_id" HeaderText="Event ID" />
                <asp:BoundField DataField="event_type" HeaderText="Event Type" />
                <asp:BoundField DataField="guests" HeaderText="Guests" />
                <asp:BoundField DataField="book_date" HeaderText="Booking Date" />
                <asp:BoundField DataField="user_id" HeaderText="User ID" />
            </Columns>
        </asp:GridView>
    </p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
</asp:Content>
