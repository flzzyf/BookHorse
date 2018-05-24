using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web_CookieTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["lemon"] != null)
        {
            string id = Request.Cookies["lemon"].Value;

            Label1.Text = id.ToString();
        }
        else
        {
            HttpCookie cookie = new HttpCookie("lemon");
            cookie.Path = "/";
            cookie.Value = "123";
            cookie.Expires = DateTime.MaxValue;
            Response.Cookies.Add(cookie);
        }
    }
}