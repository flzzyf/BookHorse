<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserOtherInfo.aspx.cs" Inherits="Web_Member_UserOtherInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
    <div style="margin: 20px; line-height: 25px;">
        <asp:Panel ID="Panel1" runat="server">
            <b>请填写如下信息：</b><br />
            <br />
            真实名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                ErrorMessage="真实名不能为空!"></asp:RequiredFieldValidator>
            <br />
            电&nbsp;&nbsp;&nbsp; 话：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                ErrorMessage="电话不能为空!"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2"
                ErrorMessage="电话号码格式不正确!" ValidationExpression="(\(\d{3}\)|\d{3}-)?\d{8}"></asp:RegularExpressionValidator>
            <br />
            地&nbsp;&nbsp;&nbsp; 址：<asp:TextBox ID="TextBox3" runat="server" Width="263px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3"
                ErrorMessage="地址不能为空!"></asp:RequiredFieldValidator>
            <br />
            邮&nbsp;&nbsp;&nbsp; 编：<asp:TextBox ID="TextBox4" runat="server" Width="80px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4"
                ErrorMessage="邮政编码不能为空!"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox4"
                ErrorMessage="邮政编码格式不正确!" ValidationExpression="\d{6}"></asp:RegularExpressionValidator>
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">提交</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" OnClick="LinkButton2_Click">取消</asp:LinkButton>
        </asp:Panel>
        <br />
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
