<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DBTest.aspx.cs" Inherits="Web_DBTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server">
            <asp:TextBox ID="tb_search" runat="server"></asp:TextBox>
            <asp:Button ID="bt_search" runat="server" OnClick="bt_search_Click" Text="搜索" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" SelectMethod="Select" TypeName="BsCategory" UpdateMethod="Update">
                <DeleteParameters>
                    <asp:Parameter Name="a" Type="Int32" />
                </DeleteParameters>
                <SelectParameters>
                    <asp:Parameter Name="a" Type="Int32" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="a" Type="Int32" />
                </UpdateParameters>
            </asp:ObjectDataSource>
            <asp:Panel ID="Panel2" runat="server">
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Button" />
                <br />
                <br />
                <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2">
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                        <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    </Columns>
                </asp:GridView>
                <br />
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DataObjectTypeName="BsCategory" DeleteMethod="DeleteBsCategory" InsertMethod="AddBsCategory" SelectMethod="FindBsCategories" TypeName="BsCategoryBLL" UpdateMethod="EditBsCategory">
                    <DeleteParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                    </DeleteParameters>
                </asp:ObjectDataSource>
                <br />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:BookStoreConnectionString %>" DeleteCommand="DELETE FROM [BsBook] WHERE [ID] = @original_ID AND [CatID] = @original_CatID AND [Name] = @original_Name AND (([Image] = @original_Image) OR ([Image] IS NULL AND @original_Image IS NULL)) AND [Price] = @original_Price AND [Summary] = @original_Summary AND [Author] = @original_Author" InsertCommand="INSERT INTO [BsBook] ([CatID], [Name], [Image], [Price], [Summary], [Author]) VALUES (@CatID, @Name, @Image, @Price, @Summary, @Author)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [BsBook]" UpdateCommand="UPDATE [BsBook] SET [CatID] = @CatID, [Name] = @Name, [Image] = @Image, [Price] = @Price, [Summary] = @Summary, [Author] = @Author WHERE [ID] = @original_ID AND [CatID] = @original_CatID AND [Name] = @original_Name AND (([Image] = @original_Image) OR ([Image] IS NULL AND @original_Image IS NULL)) AND [Price] = @original_Price AND [Summary] = @original_Summary AND [Author] = @original_Author">
                    <DeleteParameters>
                        <asp:Parameter Name="original_ID" Type="Int32" />
                        <asp:Parameter Name="original_CatID" Type="Int32" />
                        <asp:Parameter Name="original_Name" Type="String" />
                        <asp:Parameter Name="original_Image" Type="String" />
                        <asp:Parameter Name="original_Price" Type="Decimal" />
                        <asp:Parameter Name="original_Summary" Type="String" />
                        <asp:Parameter Name="original_Author" Type="String" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="CatID" Type="Int32" />
                        <asp:Parameter Name="Name" Type="String" />
                        <asp:Parameter Name="Image" Type="String" />
                        <asp:Parameter Name="Price" Type="Decimal" />
                        <asp:Parameter Name="Summary" Type="String" />
                        <asp:Parameter Name="Author" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="CatID" Type="Int32" />
                        <asp:Parameter Name="Name" Type="String" />
                        <asp:Parameter Name="Image" Type="String" />
                        <asp:Parameter Name="Price" Type="Decimal" />
                        <asp:Parameter Name="Summary" Type="String" />
                        <asp:Parameter Name="Author" Type="String" />
                        <asp:Parameter Name="original_ID" Type="Int32" />
                        <asp:Parameter Name="original_CatID" Type="Int32" />
                        <asp:Parameter Name="original_Name" Type="String" />
                        <asp:Parameter Name="original_Image" Type="String" />
                        <asp:Parameter Name="original_Price" Type="Decimal" />
                        <asp:Parameter Name="original_Summary" Type="String" />
                        <asp:Parameter Name="original_Author" Type="String" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                <asp:GridView ID="GridView3" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                        <asp:BoundField DataField="CatID" HeaderText="CatID" SortExpression="CatID" />
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                        <asp:BoundField DataField="Image" HeaderText="Image" SortExpression="Image" />
                        <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                        <asp:BoundField DataField="Summary" HeaderText="Summary" SortExpression="Summary" />
                        <asp:BoundField DataField="Author" HeaderText="Author" SortExpression="Author" />
                    </Columns>
                </asp:GridView>
                <br />
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Web/addcategory.aspx">add</asp:HyperLink>
            </asp:Panel>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
