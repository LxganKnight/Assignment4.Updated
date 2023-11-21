<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="memberpage.aspx.cs" Inherits="Assignment4.Updated.MemberInfo.memberpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Welcome, 
        <asp:LoginName ID="LoginName1" runat="server" />
        !</h1>
            <div>
                <p>First Name: <asp:Label ID="lblFirstName" runat="server"></asp:Label></p>
                <p>aaaa Last Name: <asp:Label ID="lblLastName" runat="server"></asp:Label></p>
            </div>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="SectionStartDate" HeaderText="SectionStartDate" SortExpression="SectionStartDate" />
                <asp:BoundField DataField="SectionFee" HeaderText="SectionFee" SortExpression="SectionFee" />
                <asp:BoundField DataField="SectionName" HeaderText="SectionName" SortExpression="SectionName" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KarateSchool_1_ConnectionString3 %>" SelectCommand="SELECT [SectionStartDate], [SectionFee], [SectionName] FROM [Section]"></asp:SqlDataSource>
</p>
<p>
    <asp:LoginStatus ID="LoginStatus1" runat="server" />
</p>
<p>
    &nbsp;</p>
</asp:Content>
