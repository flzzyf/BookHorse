<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebUserControl.ascx.cs" Inherits="Web_WebUserControl" %>

        <style type="text/css">
            .auto-style1 {
                text-align: center;
            }
        </style>

        <asp:Panel ID="search" runat="server" Height="122px">
            <asp:TextBox ID="search_tb" runat="server"></asp:TextBox>
            <asp:Button ID="search_bt" runat="server" Text="搜索" />
            <br />
            <br />
        </asp:Panel>


