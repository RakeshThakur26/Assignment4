<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="userspecificevent.aspx.cs" Inherits="EventManagementSystem.userspecificevent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>My Events</h2>
    <p>&nbsp;</p>
    <p>
        <asp:GridView ID="gveventtable" runat="server" AutoGenerateColumns="False" OnRowCommand="gveventtable_RowCommand" OnRowDeleting="gveventtable_RowDeleting" OnRowEditing="gveventtable_RowEditing">
            <Columns>
                <asp:BoundField DataField="event_id" HeaderText="Event ID" />
                <asp:BoundField DataField="event_type" HeaderText="Event Type" />
                <asp:BoundField DataField="guests" HeaderText="Guests" />
                <asp:BoundField DataField="book_date" HeaderText="Booking Date" />
            </Columns>
        </asp:GridView>
    </p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>

</asp:Content>
