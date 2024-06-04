<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NewTestCK.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style4 {
        margin-right: 121px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:DataList ID="DDL_default" runat="server" CssClass="auto-style4"  Width="628px" RepeatColumns="3" RepeatDirection="Horizontal">
    <ItemTemplate>
        <asp:ImageButton ID="ImageButton1" runat="server" CommandArgument='<%# Eval("MaSP") %>' ImageUrl='<%# "Images/" + Eval("Hinh") %>' OnClick="ImageButton1_Click" Height="97px" Width="105px" />
        <br />
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" Text='<%# Eval("TenSP") %>' CommandArgument='<%# Eval("MaSP") %>'></asp:LinkButton>
        <br />
        Đơn giá:
        <asp:Label ID="Label2" runat="server" Text='<%# Eval("DonGia") %>'></asp:Label>
        <br />
    
    </ItemTemplate>
</asp:DataList>
</asp:Content>
