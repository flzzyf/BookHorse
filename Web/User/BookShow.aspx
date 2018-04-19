<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookShow.aspx.cs" Inherits="Web_User_BookShow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 99%;
        }
        .auto-style3 {
            height: 22px;
            width: 141px;
        }
        .auto-style4 {
            height: 169px;
            width: 141px;
        }
        .auto-style6 {
            width: 141px;
        }
        .auto-style7 {
            width: 75px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="FindBsBook" TypeName="BsBookBLL">
                <SelectParameters>
                    <asp:QueryStringParameter Name="id" QueryStringField="bookID" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <br />
            <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource1" HorizontalAlign="Center" Width="651px">
                <EditItemTemplate>
                    ID:
                    <asp:TextBox ID="IDTextBox" runat="server" Text='<%# Bind("ID") %>' />
                    <br />
                    CatID:
                    <asp:TextBox ID="CatIDTextBox" runat="server" Text='<%# Bind("CatID") %>' />
                    <br />
                    BsCategory:
                    <asp:TextBox ID="BsCategoryTextBox" runat="server" Text='<%# Bind("BsCategory") %>' />
                    <br />
                    Name:
                    <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                    <br />
                    Image:
                    <asp:TextBox ID="ImageTextBox" runat="server" Text='<%# Bind("Image") %>' />
                    <br />
                    Price:
                    <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
                    <br />
                    Summary:
                    <asp:TextBox ID="SummaryTextBox" runat="server" Text='<%# Bind("Summary") %>' />
                    <br />
                    Author:
                    <asp:TextBox ID="AuthorTextBox" runat="server" Text='<%# Bind("Author") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="更新" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消" />
                </EditItemTemplate>
                <InsertItemTemplate>
                    ID:
                    <asp:TextBox ID="IDTextBox" runat="server" Text='<%# Bind("ID") %>' />
                    <br />
                    CatID:
                    <asp:TextBox ID="CatIDTextBox" runat="server" Text='<%# Bind("CatID") %>' />
                    <br />
                    BsCategory:
                    <asp:TextBox ID="BsCategoryTextBox" runat="server" Text='<%# Bind("BsCategory") %>' />
                    <br />
                    Name:
                    <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                    <br />
                    Image:
                    <asp:TextBox ID="ImageTextBox" runat="server" Text='<%# Bind("Image") %>' />
                    <br />
                    Price:
                    <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
                    <br />
                    Summary:
                    <asp:TextBox ID="SummaryTextBox" runat="server" Text='<%# Bind("Summary") %>' />
                    <br />
                    Author:
                    <asp:TextBox ID="AuthorTextBox" runat="server" Text='<%# Bind("Author") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="插入" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消" />
                </InsertItemTemplate>
                <ItemTemplate>
                    <br />
                    <table align="left" border="1" class="auto-style1" style="text-align: left">
                        <tr>
                            <td class="auto-style7" rowspan="5">
                                <asp:Image ID="Image1" runat="server" />
                            </td>
                            <td class="auto-style6">标题：<asp:Literal ID="Literal1" runat="server" Text='<%# Eval("Name") %>'></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">简介：</td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                &nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Literal ID="Literal2" runat="server" Text='<%# Eval("Summary") %>'></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">价格：<asp:Literal ID="Literal3" runat="server" Text='<%# Eval("Price") %>'></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style6">作者：<asp:Literal ID="Literal4" runat="server" Text='<%# Eval("Author") %>'></asp:Literal>
                            </td>
                        </tr>
                    </table>
                    <br />
                </ItemTemplate>
            </asp:FormView>
        </p>
        <p>
            <asp:Button ID="Button_Close" runat="server" OnClick="Button_Close_Click" Text="关闭" />
        </p>
    <div>
    
    </div>
    </form>
</body>
</html>
