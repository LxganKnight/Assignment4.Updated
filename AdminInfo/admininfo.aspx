<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="admininfo.aspx.cs" Inherits="Assignment4.Updated.AdminInfo.admininfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Hi,<asp:LoginName ID="LoginName1" runat="server" />
</p>
<p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        Members:</p>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <p>
        Add a new Member:</p>
    <p>
        First Name:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        Last Name:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Today&#39;s Date:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        Phone Number:
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>
        Email:
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </p>
    <p>
        Remove Member:</p>
    <p>
        Member to be Removed&#39;s ID:
        <asp:TextBox ID="rMember" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="removeMember" runat="server" Text="Remove Member" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        Instructors:</p>
    <asp:GridView ID="GridView2" runat="server">
    </asp:GridView>
    <p>
        Add a new Instructor:</p>
    <p>
        First Name:
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </p>
    <p>
        Last Name:
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    </p>
    <p>
        Phone Number:
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="addInstructor" runat="server" Text="Add Instructor" />
    </p>
    <p>
        Remove Instructor: </p>
    <p>
        Instructor to be Removed&#39;s ID:
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="removeInstructor" runat="server" Text="Remove Instructor" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
<p>
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
</p>
</asp:Content>
