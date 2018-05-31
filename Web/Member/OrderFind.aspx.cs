using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Web_Member_OrderFind : System.Web.UI.Page
{
    private BsOrderBLL orderBLL = new BsOrderBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        ObjectDataSource1.SelectParameters[0].DefaultValue = Page.User.Identity.Name;
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "ShowDetail")
        {
            int row = Int32.Parse(e.CommandArgument.ToString());
            int orderID = Int32.Parse(GridView1.DataKeys[row].Value.ToString());
            Label3.Text = orderID + "号订单的细目";
            //GridView2.DataSource = (orderBLL.FindBsOrder(orderID)).BsDetail;

            string sql = String.Format("select * from BsDetail where OrderID = {0}", orderID);
            DataTable dt = SqlHelper.ExecuteQuery(sql);
            GridView2.DataSource = dt;

            GridView2.DataBind();
        }
    }
}