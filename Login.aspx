<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Assignment4.Updated.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        text-align: center;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p style="font-size: xx-large" class="auto-style2">
    Please Login:</p>
<p>
    <asp:Login ID="Login1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" style="font-size: medium; margin-left: 670px;" Height="369px" OnAuthenticate="Login1_Authenticate" Width="504px">
        <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
    </asp:Login>
</p>
</asp:Content>
