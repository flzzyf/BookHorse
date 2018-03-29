using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controller_UserLogin : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["user"] != null)
        {
            BookUser user = (BookUser)Session["user"];
            string username = user.username;
            Username.Text = username + "登录成功";
            MultiView1.ActiveViewIndex = 1;
        }else
        {
            MultiView1.ActiveViewIndex = 0;
        }
        
    }

    protected void bt_login_Click(object sender, EventArgs e)
    {
        if(tb_username.Text == "zyf" && tb_password.Text == "123")
        {
            BookUser user = new BookUser("Zyf");
            Session["user"] = user;
            Response.Redirect(Request.Url.ToString());
        }
    }

    protected void bt_logout_Click(object sender, EventArgs e)
    {
        Session["user"] = null;
        Response.Redirect(Request.Url.ToString());
    }
}