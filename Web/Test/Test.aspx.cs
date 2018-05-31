using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Web_Test_Test : System.Web.UI.Page
{
    private BsOrderBLL orderBLL = new BsOrderBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        BsOrder order = new BsOrder();
        order.State = 1;
        MembershipUser user = Membership.GetUser(Page.User.Identity.Name); ;
        order.UserID = (Guid)user.ProviderUserKey;

        int orderID = orderBLL.AddBsOrder(order, Profile.BsCartBLL.FindItems());
    }
}