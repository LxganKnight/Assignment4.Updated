<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="admininfo.aspx.cs" Inherits="Assignment4.Updated.AdminInfo.admininfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Members:</p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="MemberFirstName" HeaderText="MemberFirstName" SortExpression="MemberFirstName" />
            <asp:BoundField DataField="MemberLastName" HeaderText="MemberLastName" SortExpression="MemberLastName" />
            <asp:BoundField DataField="MemberDateJoined" HeaderText="MemberDateJoined" SortExpression="MemberDateJoined" />
            <asp:BoundField DataField="MemberPhoneNumber" HeaderText="MemberPhoneNumber" SortExpression="MemberPhoneNumber" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KarateSchool_1_ConnectionString3 %>" SelectCommand="SELECT [MemberFirstName], [MemberLastName], [MemberDateJoined], [MemberPhoneNumber] FROM [Member]"></asp:SqlDataSource>
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
        <asp:Button ID="addMember" runat="server" Text="addMember" />
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
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
        <Columns>
            <asp:BoundField DataField="InstructorFirstName" HeaderText="InstructorFirstName" SortExpression="InstructorFirstName" />
            <asp:BoundField DataField="InstructorLastName" HeaderText="InstructorLastName" SortExpression="InstructorLastName" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:KarateSchool_1_ConnectionString3 %>" SelectCommand="SELECT [InstructorFirstName], [InstructorLastName] FROM [Instructor]"></asp:SqlDataSource>
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
        <asp:TextBox ID="rInstructor" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="removeInstructor" runat="server" Text="Remove Instructor" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        Create new Member Section:</p>
    <p>
        Section Name:
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
    </p>
    <p>
        Section Start Date:
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
    </p>
    <p>
        Member_ID:
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
    </p>
    <p>
        Instructor_ID:
        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
    </p>
    <p>
        Section Fee:
        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="newSection" runat="server" Text="Create New Section" />
    </p>
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
