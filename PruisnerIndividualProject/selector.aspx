<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="selector.aspx.cs" Inherits="PruisnerIndividualProject.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="form">
        <h2>Donny's Vehicles</h2>
        <asp:Label ID="lbldisplay" runat="server" Text=""></asp:Label>
        <h3>View a random vehicle in Donny's collection</h3>
        <asp:Button class="button" ID="randvehiclebtn" runat="server" Text="Display Random Vehicle" OnClick="randvehiclebtn_Click"/><br />
        <asp:Label ID="randvehiclelbl" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="randvehicleimg" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
