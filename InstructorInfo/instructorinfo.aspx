<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="instructorinfo.aspx.cs" Inherits="Assignment4.Updated.InstructorInfo.instructorinfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Welcome
        <asp:Label ID="Label1" runat="server" Text="Firstname"></asp:Label>
        ,<asp:Label ID="Label2" runat="server" Text="Lastname"></asp:Label>
        !</p>
<p>
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
</p>
    <p>
        Your Sections:</p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
