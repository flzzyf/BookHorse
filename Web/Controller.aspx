<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Controller.aspx.cs" Inherits="Web_Controller" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Panel ID="search" runat="server" Height="122px">
            <asp:TextBox ID="search_tb" runat="server"></asp:TextBox>
            <asp:Button ID="search_bt" runat="server" Text="搜索" />
        </asp:Panel>


        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                <asp:Panel ID="Panel1" runat="server">
                    <div class="auto-style1">
                        <asp:Label ID="Username" runat="server" Text="账号"></asp:Label>
                        <asp:TextBox ID="tb_username" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="Password" runat="server" Text="密码"></asp:Label>
                        <asp:TextBox ID="tb_password" runat="server"></asp:TextBox>
                        <br />
                        <asp:Button ID="bt_login" runat="server" Text="登录" />
                    </div>
                </asp:Panel>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:Panel ID="Panel2" runat="server">
                    <div class="auto-style1">
                        <asp:HyperLink ID="HyperLink1" runat="server">注销</asp:HyperLink>
                        &nbsp;<asp:HyperLink ID="HyperLink2" runat="server">修改个人信息</asp:HyperLink>
                    </div>
                </asp:Panel>
            </asp:View>
        </asp:MultiView>
        <asp:Panel ID="Panel3" runat="server">
            <asp:Label ID="Label1" runat="server" Text="查询图书："></asp:Label>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatColumns="2">
                <asp:ListItem>按书名</asp:ListItem>
                <asp:ListItem>按作者</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Button ID="bt_search" runat="server" OnClick="bt_search_Click" Text="查询" />
            <br />
        </asp:Panel>
    </form>
</body>
</html>
