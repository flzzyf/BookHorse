﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Web_Default3" %>

<%@ Register Src="~/Controller/UserLogin.ascx" TagPrefix="uc1" TagName="UserLogin" %>
<%@ Register Src="~/Controller/MainMenu.ascx" TagPrefix="uc1" TagName="MainMenu" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    标题
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:MainMenu runat="server" ID="MainMenu" />

    内容qweqewqewqeeqeqweqweqwewqewq

    <uc1:UserLogin runat="server" ID="UserLogin" />
</asp:Content>
