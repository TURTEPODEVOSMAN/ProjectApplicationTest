<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="adminPanel.aspx.cs" Inherits="OKucukkelesSQLinj.adminPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="width:100%; background-color:#13acde;">

        <asp:Label ID="lblBilgi" class="info" runat="server" Text="_" style="font-weight: 700; color: #00FFCC"> <br /> </asp:Label> 
        <asp:Button ID="btnLogOff" class="btn-danger" Style="padding-left: 10%;" runat="server" Text="Çıkış" OnClick="btnLogOff_Click" />
       
        <img style="width:100%;" alt="Admin Panel Dashboard Example" src="zzz_admin.png" /></div>

</asp:Content>
