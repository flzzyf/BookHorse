<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserLogin.ascx.cs" Inherits="Controller_UserLogin" %>

<style type="text/css">
    .auto-style1 {
        text-align: center;
    }
</style>

 <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                <asp:Panel ID="Panel1" runat="server">
                    <div class="auto-style1">
                        <asp:Label ID="Username" runat="server" Text="账号"></asp:Label>
                        <asp:TextBox ID="tb_username" runat="server"></asp:TextBox>
                        <br />
                        <asp:Label ID="Password" runat="server" Text="密码"></asp:Label>
                        <asp:TextBox ID="tb_password" runat="server" TextMode="Password"></asp:TextBox>
                        <br />
                        <asp:Button ID="bt_login" runat="server" Text="登录" OnClick="bt_login_Click" />
                    </div>
                </asp:Panel>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:Panel ID="Panel2" runat="server">
                    <div class="auto-style1">
                        <asp:Button ID="bt_logout" runat="server" Height="28px" OnClick="bt_logout_Click" Text="注销" Width="50px" />
                        &nbsp;<asp:Button ID="bt_modify" runat="server" Height="28px" Text="修改个人信息" />
                    </div>
                </asp:Panel>
            </asp:View>
        </asp:MultiView>