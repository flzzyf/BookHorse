<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CatMenu.ascx.cs" Inherits="Controller_CatMenu" %>

        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="FindBsCategories" TypeName="BsCategoryBLL"></asp:ObjectDataSource>
        <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1" RepeatDirection="Horizontal" Width="100%">
            <ItemTemplate>
                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("ID") %>' OnCommand="LinkButton1_Command" Text='<%# Eval("Name") %>'></asp:LinkButton>
            </ItemTemplate>
        </asp:DataList>
