<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserLogin.ascx.cs" Inherits="Web_Common_UserLogin" %>
<style type="text/css">
    .auto-style1 {
        text-align: center;
    }
</style>

<asp:LoginView ID="LoginView1" runat="server">
    <AnonymousTemplate>
        <asp:Login ID="Login1" runat="server" BackColor="#66FF66" FailureText="登录失败！" Font-Size="12pt" Width="190px" DestinationPageUrl="~/Web/MainWeb.aspx" Height="116px">
            <TextBoxStyle Width="100px" />
        </asp:Login>
    </AnonymousTemplate>
    <LoggedInTemplate>
        <asp:Panel ID="Panel1" runat="server" BackColor="#E6E2D8" Height="116px" Width="190px">
            <div class="auto-style1">
                <br />
                <asp:LoginName ID="LoginName1" runat="server" />
                着陆成功！<br /> 
                <asp:LoginStatus ID="LoginStatus1" runat="server" />
                &nbsp;
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Web/Member/EditPassword">修改密码</asp:HyperLink>
            </div>
        </asp:Panel>
    </LoggedInTemplate>
</asp:LoginView>

