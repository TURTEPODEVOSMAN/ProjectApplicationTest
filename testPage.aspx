<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="testPage.aspx.cs" Inherits="SQLinj.testPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <div>
            <h2>SQL Injection Simülasyonu</h2>
            <label for="txtUsername">Kullanıcı Adı:</label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            <label for="txtPassword">Şifre:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Giriş Yap" OnClick="btnLogin_Click" />
            <br />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        </div>
</asp:Content>
