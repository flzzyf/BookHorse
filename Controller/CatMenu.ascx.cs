using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controller_CatMenu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {
        Session["catID"] = e.CommandArgument;
        Response.Redirect("~/Web/MainWeb.aspx");
    }
}