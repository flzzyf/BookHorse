<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Common/MasterPage.master" AutoEventWireup="true" CodeFile="OrderFind.aspx.cs" Inherits="Web_Member_OrderFind" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div style="text-align: center">
        <br />
        <b>订单列表</b>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None" HorizontalAlign="Center" AutoGenerateColumns="False" 
            DataSourceID="ObjectDataSource1" Width="474px" AllowPaging="True" 
            DataKeyNames="ID" onrowcommand="GridView1_RowCommand" PageSize="4">
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <Columns>
                <asp:ButtonField CommandName="ShowDetail" DataTextField="ID" HeaderText="订单号" 
                    Text="按钮" />
                <asp:BoundField DataField="Date" HeaderText="订购时间" SortExpression="Date" 
                    DataFormatString="{0:yyyy年MM月dd日}" />
                <asp:TemplateField HeaderText="状态" SortExpression="State">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("State") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# "已发货" %>' 
                            Visible='<%# ((int)Eval("state"))==1 %>'></asp:Label>
                        <asp:Label ID="Label2" runat="server" Text='<%# "未发货" %>' 
                            Visible='<%# ((int)Eval("state"))==0 %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="FindBsOrders" TypeName="BsOrderBLL">
            <SelectParameters>
                <asp:Parameter DefaultValue="" Name="username" Type="String" />
                <asp:Parameter DefaultValue="-1" Name="state" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        <asp:Label ID="Label3" runat="server" Text="" Font-Bold="True"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" 
            Width="524px">
            <RowStyle BackColor="#EFF3FB" />
            <Columns>
                <asp:BoundField DataField="OrderID" HeaderText="订单号" />
                <asp:BoundField DataField="BookID" HeaderText="图书号" />
                <asp:TemplateField HeaderText="书名">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" 
                            Text='<%# ((BsBook)Eval("BsBook")).Name %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Quantity" HeaderText="数量" />
                <asp:BoundField DataField="Price" HeaderText="单价" />
            </Columns>
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content_Bottom" Runat="Server">
</asp:Content>

