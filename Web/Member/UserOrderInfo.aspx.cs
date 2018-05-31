using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Web_Member_UserOtherInfo : System.Web.UI.Page
{
    private BsOrderBLL orderBLL = new BsOrderBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        //非第一次提交则自动填写上次
        if (!IsPostBack && !String.IsNullOrEmpty(Profile.OtherInfo.Realname))
        {
            AddOrder();
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Profile.OtherInfo.Realname = TextBox1.Text;
        Profile.OtherInfo.Phone = TextBox2.Text;
        Profile.OtherInfo.Address = TextBox3.Text;
        Profile.OtherInfo.Zipcode = TextBox4.Text;
        Profile.Save();
        AddOrder();
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Web/User/CartBrowse.aspx");
    }
    private void AddOrder()
    {
        Panel1.Visible = false;
        MembershipUser user = Membership.GetUser(Page.User.Identity.Name);
        BsOrder order = new BsOrder();
        order.UserID = (Guid)user.ProviderUserKey;
        //Console.WriteLine(order.UserID);
        order.State = 1;
        //System.Diagnostics.Debug.WriteLine(order.UserID);
        int orderID = orderBLL.AddBsOrder(order, Profile.BsCartBLL.FindItems());

        //清空购物车
        Profile.BsCartBLL.DeleteAll();
        Profile.Save();

        Literal1.Text = "结账成功!订单号为：" + orderID + "&nbsp;<a href='" + "OrderFind.aspx?userID=" + (Guid)user.ProviderUserKey + "'>查询订单</a>";
    }
}