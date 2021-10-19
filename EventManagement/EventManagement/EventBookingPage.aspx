<%@ Page  trace="true" Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="EventBookingPage.aspx.cs" Inherits="EventManagementSystem.EventBookingPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Event Booking Page</h2>
    <p>&nbsp;<asp:LinkButton ID="lbtnbookingstatus" runat="server" ForeColor="#3333FF" OnClick="lbtnbookingstatus_Click">Booking Status</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;<asp:LinkButton ID="lbtnprofile" runat="server" Text="Profile" OnClick="lbtnprofile_Click"></asp:LinkButton>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="txtlinktofoodordering" runat="server" ForeColor="#3333FF" PostBackUrl="~/FoodOrder.aspx">Food Ordering</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="txtlinktoflowers" runat="server" ForeColor="#3333FF" PostBackUrl="~/Flowers.aspx">Flowers Booking</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hi Customer!&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="txtlogout" runat="server" PostBackUrl="~/LoginPage.aspx">Logout</asp:LinkButton>
    </p>
    <hr />
    <p>Event Type&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="droplistEventType" runat="server" ForeColor="#3333FF" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>--Select--</asp:ListItem>
            <asp:ListItem>Birthday Party</asp:ListItem>
            <asp:ListItem>Wedding </asp:ListItem>
            <asp:ListItem>Naming Ceremony</asp:ListItem>
            <asp:ListItem>Thread Ceremony</asp:ListItem>
            <asp:ListItem>Corporate Event</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>Number Of Guest&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtnumberofguest" runat="server"></asp:TextBox>
    </p>
    <p>Booking Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtbookingdate" runat="server"></asp:TextBox>
&nbsp;<asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="#3333FF" Height="190px" NextPrevFormat="FullMonth" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged" Width="350px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
        User ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtuserid" runat="server" ForeColor="#3333FF"></asp:TextBox>
&nbsp;
    </p>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="txtsubmitbooking" runat="server" ForeColor="#3333FF" OnClick="txtsubmitbooking_Click" Text="Submit" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;<asp:LinkButton ID="lbtncancelEvent" runat="server" ForeColor="#3333FF" PostBackUrl="~/EventBookingPage.aspx">Cancel</asp:LinkButton>
    </p>
    <p>&nbsp;</p>

</asp:Content>
