﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DBTest.aspx.cs" Inherits="Web_DBTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server">
            <asp:TextBox ID="tb_search" runat="server"></asp:TextBox>
            <asp:Button ID="bt_search" runat="server" OnClick="bt_search_Click" Text="搜索" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>