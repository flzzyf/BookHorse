<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default"  Theme="MainSkin"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <asp:Button ID="Button3" runat="server" Text="Button"/>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" SkinID="GreenButton"/>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Button" SkinID="GreenButton2"/>

        
    </div>
    </form>
</body>
</html>
