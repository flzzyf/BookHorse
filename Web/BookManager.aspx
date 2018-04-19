<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookManager.aspx.cs" Inherits="Web_BookManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="DeleteBsBook" SelectCountMethod="FindCount" SelectMethod="FindBsBooks" SortParameterName="sortExpression" TypeName="BsBookBLL">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <SelectParameters>
                <asp:Parameter Name="catID" Type="Int32" />
                <asp:SessionParameter Name="name" SessionField="bookName" Type="String" />
                <asp:SessionParameter Name="author" SessionField="bookAuthor" Type="String" />
                <asp:Parameter Name="sortExpression" Type="String" />
                <asp:Parameter Name="startRowIndex" Type="Int32" />
                <asp:Parameter Name="maximumRows" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" AllowSorting="True" DataKeyNames="ID" HorizontalAlign="Center">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="/BookShow.aspx?id={0}" DataTextField="ID" HeaderText="ID">
                <HeaderStyle Width="40px" />
                </asp:HyperLinkField>
                <asp:TemplateField HeaderText="类别" SortExpression="CatID">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("CatID") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# ((BsCategory)Eval("BsCategory")).Name %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle Width="40px" />
                </asp:TemplateField>
                <asp:BoundField DataField="Name" HeaderText="书名" SortExpression="Name" >
                    <HeaderStyle Width="300px" Height="40px" />
                <ItemStyle Height="40px" />
                </asp:BoundField>
                <asp:BoundField DataField="Price" HeaderText="价格" SortExpression="Price">
                <HeaderStyle Width="40px" />
                </asp:BoundField>
                <asp:BoundField DataField="Author" HeaderText="作者" SortExpression="Author" >
                    <HeaderStyle Width="120px" />
                </asp:BoundField>

                <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="BookEdit.aspx?id={0}" Text="编辑" >
                <HeaderStyle Width="40px" />
                </asp:HyperLinkField>
                <asp:CommandField ShowDeleteButton="True" >
                <HeaderStyle Width="40px" />
                </asp:CommandField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerSettings FirstPageText="首页" LastPageText="尾页" Mode="NextPreviousFirstLast" NextPageText="下一页" PreviousPageText="上一页" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
