<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserLogin_Old.ascx.cs" Inherits="Controller_UserLogin" %>

<style type="text/css">
    .auto-style1 {
        text-align: center;
    }
</style>

 <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                <asp:Panel ID="Panel1" runat="server">
                    <div class="auto-style1">
                        <asp:Label ID="Username" runat="server" Text="账号" Font-Size="Large"></asp:Label>
                        <asp:TextBox ID="tb_username" runat="server" Width="90px"></asp:TextBox>
                        <br />
                        <asp:Label ID="Password" runat="server" Text="密码" Font-Size="Large"></asp:Label>
                        <asp:TextBox ID="tb_password" runat="server" TextMode="Password" Width="90px"></asp:TextBox>
                        <br />
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="保存登录" />
                        &nbsp;<asp:Button ID="bt_login" runat="server" Text="登录" OnClick="bt_login_Click" />
                    </div>
                </asp:Panel>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:Panel ID="Panel2" runat="server">
                    <div class="auto-style1">
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        <br />
                        <asp:Button ID="bt_logout" runat="server" Height="28px" OnClick="bt_logout_Click" Text="注销" Width="50px" />
                        &nbsp;<asp:Button ID="bt_modify" runat="server" Height="28px" Text="修改个人信息" />
                        <br />
                        <asp:LinkButton ID="bt_deleteCookie" runat="server" OnClick="LinkButton1_Click">删除Cookie</asp:LinkButton>
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </div>
                </asp:Panel>
            </asp:View>
        </asp:MultiView>