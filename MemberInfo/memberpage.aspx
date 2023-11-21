<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="memberpage.aspx.cs" Inherits="Assignment4.Updated.MemberInfo.memberpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
            <div>
                <p>Name:
                    <asp:Label ID="lblMemberName" runat="server" Text="Label"></asp:Label>
                </p>
            </div>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
</p>
    <p>
        Total Cost:<asp:Label ID="lblTotalCost" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:LoginStatus ID="LoginStatus1" runat="server" />
</p>
<p>
    &nbsp;</p>
</asp:Content>
