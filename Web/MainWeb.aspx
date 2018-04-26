<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MainWeb.aspx.cs" Inherits="Web_MainWeb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Left" Runat="Server">
    <p>
        &nbsp;</p>
    <p>
        <br />
    </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Navi" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Content" Runat="Server">


    <p>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DeleteMethod="DeleteBsBook" SelectCountMethod="FindCount" SelectMethod="FindBsBooks" SortParameterName="sortExpression" TypeName="BsBookBLL">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <SelectParameters>
                <asp:Parameter Name="catID" Type="Int32" DefaultValue="" />
                <asp:SessionParameter Name="name" SessionField="bookName" Type="String" />
                <asp:SessionParameter Name="author" SessionField="bookAuthor" Type="String" />
                <asp:Parameter Name="sortExpression" Type="String" />
                <asp:Parameter Name="startRowIndex" Type="Int32" />
                <asp:Parameter Name="maximumRows" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        <asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSource2" GroupItemCount="2">
            
            <EmptyDataTemplate>
                <table runat="server" style="">
                    <tr>
                        <td>未返回数据。</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <EmptyItemTemplate>
<td runat="server" />
            </EmptyItemTemplate>
            <GroupTemplate>
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server"></td>
                </tr>
            </GroupTemplate>
            
            <ItemTemplate>
                <td runat="server" style="width: 16px">
                    <table style="width: 1700%">
                        <tr>
                            <td rowspan="4">
                                <asp:Image ID="Image1" runat="server" />
                            </td>
                            <td>书名：</td>
                            <td>
                                <asp:HyperLink ID="HyperLink1" runat="server" Target="_blank" Text='<%# Eval("Name") %>'></asp:HyperLink>
                            </td>
                        </tr>
                        <tr>
                            <td>作者：</td>
                            <td>
                                <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("Author") %>'></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 20px">单价：</td>
                            <td style="height: 20px">
                                <asp:Literal ID="Literal2" runat="server" Text='<%# Eval("Price") %>'></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:HyperLink ID="HyperLink2" runat="server">加入购物车</asp:HyperLink>
                            </td>
                        </tr>
                    </table>
                </td>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                                <tr id="groupPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="">
                            <asp:DataPager ID="DataPager1" runat="server" PageSize="4">
                                <Fields>
                                    <asp:NextPreviousPagerField ShowFirstPageButton="True" ShowLastPageButton="True" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            
        </asp:ListView>
    </p>
    <p>
    </p>


</asp:Content>

