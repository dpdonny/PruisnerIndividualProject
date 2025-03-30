<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="upload.aspx.cs" Inherits="PruisnerIndividualProject.upload" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form">
        <h2>Upload a picture of your vehicle/dream vehicle</h2>
        <asp:FileUpload ID="file" runat="server" /><br />
        <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click"/><br />
        <asp:Label ID="lblresults" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
