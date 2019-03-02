<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Coffee.aspx.cs" Inherits="Pages_Coffee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <p>
    Select a type:
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="sds_type" DataTextField="type" DataValueField="type" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:SqlDataSource ID="sds_type" runat="server" ConnectionString="<%$ ConnectionStrings:CoffeeDBConnectionString %>" SelectCommand="SELECT [type] FROM [coffee] ORDER BY [type]"></asp:SqlDataSource>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</p>
</asp:Content>

