<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyDbDashboard._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <h1> DBA Dashboard </h1>
        <p class="lead">Select a database to view its details.</p>
        <asp:DropDownList ID="ddlDatabases" runat="server"></asp:DropDownList>
        <br /><br />
        <asp:Button ID="btnGetDetails" runat="server" Text="Get Details" OnClick="btnGetDetails_Click" />




    </main>

</asp:Content>
