using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web_UpdateCategory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request["index"] != null)
        {
            int id = int.Parse(Request["index"]);
            Label1.Text = Request["index"];

            //DetailsView1.

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int index = DropDownList1.SelectedIndex;

        Response.Redirect("UpdateCategory.aspx?index=" + index);
    }
}