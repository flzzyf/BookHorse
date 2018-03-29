<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Web_Default3" %>

<%@ Register Src="~/Web/WebUserControl.ascx" TagPrefix="uc1" TagName="WebUserControl" %>
<%@ Register Src="~/Controller/UserLogin.ascx" TagPrefix="uc1" TagName="UserLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    标题
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    内容qweqewqewqeeqeqweqweqwewqewq

    <uc1:UserLogin runat="server" ID="UserLogin" />
</asp:Content>

