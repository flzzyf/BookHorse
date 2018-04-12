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
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BookStoreConnectionString %>" DeleteCommand="DELETE FROM [BsCategory] WHERE [ID] = @ID" InsertCommand="INSERT INTO [BsCategory] ([Name]) VALUES (@Name)" SelectCommand="SELECT * FROM [BsCategory]" UpdateCommand="UPDATE [BsCategory] SET [Name] = @Name WHERE [ID] = @ID">
                    <DeleteParameters>
                        <asp:Parameter Name="ID" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="Name" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Name" Type="String" />
                        <asp:Parameter Name="ID" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                <asp:GridView ID="GridView3" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    </Columns>
                </asp:GridView>
                <br />
            </asp:Panel>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
