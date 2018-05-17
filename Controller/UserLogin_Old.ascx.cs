using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controller_UserLogin : System.Web.UI.UserControl
{
    private BsUserBLL userBLL = new BsUserBLL();

    string url_MainWeb = "~/Web/MainWeb.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        //Session["user"] = null;

        if (!IsPostBack) //受控件加载
        {
            BsUser user = (BsUser)Session["user"];
            if (user == null)
            {
                if (Request.Cookies["userID"] != null)
                {
                    string id = Request.Cookies["userID"].Value;

                    tb_username.Text = id;
                    user = userBLL.FindBsUser(id);
                    Session["user"] = user;
                }
            }
        }
        if (Session["user"] != null)
        {
            BsUser user = (BsUser)Session["user"];
            Label1.Text = "欢迎" + user.Realname + "进入";
            MultiView1.ActiveViewIndex = 1;
        }
        else
        {
            MultiView1.ActiveViewIndex = 0;
        }
    }

    protected void bt_login_Click(object sender, EventArgs e)
    {
        BsUser user = userBLL.FindBsUser(tb_username.Text, tb_password.Text);
        if (user != null)
        {
            if (CheckBox1.Checked)
            {
                HttpCookie cookie = new HttpCookie("userID");
                cookie.Path = "/";
                cookie.Value = user.ID.ToString();
                cookie.Expires = DateTime.MaxValue;
                Response.Cookies.Add(cookie);
            }
            Session["user"] = user;
            Response.Redirect(url_MainWeb);
        }
        else
        {
            this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "", 
                "alert('登录失败');window.location.href='" + url_MainWeb + "'", true);
        }
    }

    protected void bt_logout_Click(object sender, EventArgs e) //注销
    {
        Session.Abandon();
        ClearCookie();

        Response.Redirect(url_MainWeb);
    }

    protected void LinkButton1_Click(object sender, EventArgs e) //删除Cookie
    {
        ClearCookie();

        Response.Redirect(url_MainWeb);
    }

    void ClearCookie()
    {
        HttpCookie cookie = new HttpCookie("userID");
        cookie.Expires = DateTime.Now.AddDays(-30);
        Response.Cookies.Add(cookie);
    }
}