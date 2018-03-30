<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SearchBook.ascx.cs" Inherits="Controller_SearchBook" %>

        <asp:Panel ID="search_panel" runat="server" style="text-align: center">
            <asp:Label ID="Label1" runat="server" Text="查询图书：" Font-Bold="True" Font-Size="Large"></asp:Label>
            <asp:RadioButtonList ID="search_radio" runat="server" RepeatColumns="2">
                <asp:ListItem>按书名</asp:ListItem>
                <asp:ListItem>按作者</asp:ListItem>
            </asp:RadioButtonList>
            <asp:TextBox ID="search_tb" runat="server"></asp:TextBox>
            <asp:Button ID="search_bt" runat="server" Text="查询" />
            <br />
        </asp:Panel>