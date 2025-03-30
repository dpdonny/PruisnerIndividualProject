<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="entry.aspx.cs" Inherits="PruisnerIndividualProject.entry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form">
        <h2>Tell me about your vehicle(s)!</h2>
        <p>I am interested in the vehicles that are on people's minds. Tell me about a vehicle that you own or one that you find to be interesting.</p>
        <asp:Label ID="Label1" runat="server" Text="Your vehicle: "></asp:Label>
        <asp:TextBox ID="txtdescription" runat="server"></asp:TextBox>
        <asp:Button class="button" ID="btndescription" runat="server" Text="Save Vehicle" OnClick="btndescription_Click"/><br />
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />
    </div>
</asp:Content>
