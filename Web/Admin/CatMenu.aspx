<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CatMenu.aspx.cs" Inherits="Web_Admin_CatMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="FindBsCategories" TypeName="BsCategoryBLL"></asp:ObjectDataSource>
        <br />
        <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1" RepeatDirection="Horizontal" Width="100%">
            <ItemTemplate>
                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("ID") %>' OnCommand="LinkButton1_Command" Text='<%# Eval("Name") %>'></asp:LinkButton>
            </ItemTemplate>
        </asp:DataList>
    
    </div>
    </form>
</body>
</html>
