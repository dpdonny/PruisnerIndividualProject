<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="favorite.aspx.cs" Inherits="PruisnerIndividualProject.favorite" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form">
    <h2>What is your favorite vehicle?</h2>
    <p>There are many vehicles that people like, and some of them happen to be owned by people we know. Out of this collection of user saved vehicles, which one is your favorite? </p>
    <asp:Label ID="lblform" runat="server" Text=""></asp:Label><br />
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    <asp:Button ID="btnform" runat="server" Text="Submit" OnClick="btnform_Click"/><br />
    <asp:Label ID="lblresults" runat="server" Text=""></asp:Label>
</div>
</asp:Content>
