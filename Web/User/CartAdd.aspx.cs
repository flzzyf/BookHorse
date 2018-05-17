using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web_User_CartAdd : System.Web.UI.Page
{
    IBsBookBLL bsBookBLL = new BsBookBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Int32.Parse(Request.QueryString["id"]);

        BsBook bsBook = bsBookBLL.FindBsBook(id);

        CartItem item = new CartItem();
        item.ID = id;
        item.Name = bsBook.Name;
        item.Price = bsBook.Price;
        item.Quantity = 1;
        Profile.BsCartBLL.AddItem(item);
        Profile.Save();
        Response.Redirect("~/Web/User/CartBrowse.aspx");
    }
}