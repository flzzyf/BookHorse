<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MainWeb.aspx.cs" Inherits="Web_MainWeb" %>

<%@ Register src="../Controller/CatMenu.ascx" tagname="CatMenu" tagprefix="uc1" %>
<%@ Register Src="~/Controller/SearchBook.ascx" TagPrefix="uc1" TagName="SearchBook" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Left" Runat="Server">
    <uc1:SearchBook runat="server" ID="SearchBook" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Navi" Runat="Server">
    <uc1:CatMenu ID="CatMenu1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Content" Runat="Server">


    <p>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DeleteMethod="DeleteBsBook" SelectCountMethod="FindCount" SelectMethod="FindBsBooks" SortParameterName="sortExpression" TypeName="BsBookBLL">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <SelectParameters>
                <asp:SessionParameter DefaultValue="" Name="catID" SessionField="catID" Type="Int32" />
                <asp:SessionParameter Name="name" SessionField="bookName" Type="String" />
                <asp:SessionParameter Name="author" SessionField="bookAuthor" Type="String" />
                <asp:Parameter Name="sortExpression" Type="String" />
                <asp:Parameter Name="startRowIndex" Type="Int32" />
                <asp:Parameter Name="maximumRows" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        <asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSource2" GroupItemCount="2" style="text-align: center; margin-right: 241px">
            
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
                <td runat="server" style="width: 400px">
                    <table style="width: 100%">
                        <tr>
                            <td rowspan="4">
                                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Image", "~/Web/Common/BookImages/{0}") %>' Width="97px" Height="124"/>
                            </td>
                            <td>书名：</td>
                            <td style="width: 191px">
                                <asp:HyperLink ID="HyperLink1" runat="server" Target="_blank" Text='<%# Eval("Name") %>'></asp:HyperLink>
                            </td>
                        </tr>
                        <tr>
                            <td>作者：</td>
                            <td style="width: 191px">
                                <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("Author") %>'></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 20px">单价：</td>
                            <td style="height: 20px; width: 191px;">
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
        &nbsp;</p>
    <p>
    </p>


</asp:Content>

