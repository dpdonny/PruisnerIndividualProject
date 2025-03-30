<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="user_display.aspx.cs" Inherits="PruisnerIndividualProject.user_display" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form">
        <h2>Your Saved Vehicles</h2>
        <asp:Label ID="lblresults" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
