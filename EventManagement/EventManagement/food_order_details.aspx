<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="food_order_details.aspx.cs" Inherits="EventManagementSystem.food_order_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Food Order Page</h2>
    <p>&nbsp;</p>
    <p>Food Type&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="txtveg" runat="server" ForeColor="#3333FF"  Text="Veg" AutoPostBack="True" GroupName="FoodGroup" OnCheckedChanged="txtveg_CheckedChanged" />
        <asp:RadioButton ID="txtnonveg" runat="server" ForeColor="#3333FF" Text="Non Veg" AutoPostBack="True" GroupName="FoodGroup" OnCheckedChanged="txtnonveg_CheckedChanged" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    <p>Meal Type&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:RadioButton ID="txtlunch" runat="server" ForeColor="#3333FF" Text="Lunch" AutoPostBack="True" GroupName="MealGroup" OnCheckedChanged="txtlunch_CheckedChanged" />
        <asp:RadioButton ID="txtdinner" runat="server" ForeColor="#3333FF" Text="Dinner" AutoPostBack="True" GroupName="MealGroup" OnCheckedChanged="txtdinner_CheckedChanged" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    <p>Dish Type&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="txtSouthindian" runat="server" ForeColor="#3333FF" Text="South Indian" OnCheckedChanged="txtSouthindian_CheckedChanged" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="txtNorthindian" runat="server" ForeColor="#3333FF" Text="North Indian" OnCheckedChanged="txtNorthindian_CheckedChanged" />
        &nbsp;</p>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="txtpunjabi" runat="server" ForeColor="#3333FF" Text="Punjabi " OnCheckedChanged="txtpunjabi_CheckedChanged" />
        &nbsp;</p>
    <p>User ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtuseridfood" runat="server"></asp:TextBox>
    </p>
    <p>Event ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txteventidfood" runat="server"></asp:TextBox>
    </p>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="txtbookfood" runat="server" ForeColor="#3333FF" Text="Book Food" OnClick="txtbookfood_Click" />
        &nbsp;
        <asp:Button ID="txtcancelfoodorder" runat="server" ForeColor="#3333FF" PostBackUrl="~/FoodOrder.aspx" Text="Cancel" />
        &nbsp;&nbsp;<asp:Button ID="btnorderflowers" runat="server" ForeColor="#3333FF" OnClick="btnorderflowers_Click" Text="Click To Order Flowers" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</p>

</asp:Content>
