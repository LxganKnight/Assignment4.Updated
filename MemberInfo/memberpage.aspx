<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="memberpage.aspx.cs" Inherits="Assignment4.Updated.MemberInfo.memberpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    Hi,
    <asp:LoginName ID="LoginName1" runat="server" />
</p>
<p>
    <asp:LoginStatus ID="LoginStatus1" runat="server" />
</p>
<p>
    &nbsp;</p>
</asp:Content>
