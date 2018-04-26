using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controller_SearchBook : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void search_bt_Click(object sender, EventArgs e)
    {
        Session["catID"] = "";
        Session["bookName"] = "";
        Session["bookAuthor"] = "";

        if (search_radio.SelectedIndex == 0)
        {
            Session["bookName"] = search_tb.Text; 
        }
        else
        {
            Session["bookAuthor"] = search_tb.Text;

        }
        Response.Redirect("~/Web/MainWeb.aspx");

    }
}