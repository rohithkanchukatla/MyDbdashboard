<%@ Page Title="Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="MyDbDashboard.Details" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Database Details</h3>
    <p><b>Database Name:</b> <asp:Label ID="lblName" runat="server"></asp:Label></p>
    <p><b>Server Name:</b> <asp:Label ID="lblServer" runat="server"></asp:Label></p>
    <p><b>Last Backup:</b> <asp:Label ID="lblLastBackup" runat="server"></asp:Label></p>
    <p><b>Size (MB):</b> <asp:Label ID="lblSize" runat="server"></asp:Label></p>
    <br />
    <asp:HyperLink NavigateUrl="~/Default.aspx" runat="server">Back to Home</asp:HyperLink>
</asp:Content>

