<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Web_Default3" %>

<%@ Register Src="~/Controller/UserLogin.ascx" TagPrefix="uc1" TagName="UserLogin" %>
<%@ Register Src="~/Controller/MainMenu.ascx" TagPrefix="uc1" TagName="MainMenu" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    标题
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Left" Runat="Server">
        <uc1:UserLogin runat="server" ID="UserLogin" />

</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="Navi" Runat="Server">
        
    <asp:SiteMapPath ID="SiteMapPath1" runat="server">

    </asp:SiteMapPath>
        
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <uc1:MainMenu runat="server" ID="MainMenu" />

    内容qweqewqewqeeqeqweqweqwewqewq

</asp:Content>

