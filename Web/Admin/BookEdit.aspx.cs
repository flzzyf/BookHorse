using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web_Admin_BookEdit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    string bookManager = "~/Web/Admin/BookManager.aspx";
    string bookManagerAbs = "BookManager.aspx";

    protected void ObjectDataSource1_Updated(object sender, ObjectDataSourceStatusEventArgs e)
    {
        e.AffectedRows = (int)e.ReturnValue;

        Label3.Text = "qwe";
    }

    protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    {
        if(e.Exception == null)
        {
            if(e.AffectedRows > 0)
            {
                this.ClientScript.RegisterClientScriptBlock(this.GetType(), "",
                "alert('修改成功');window.location.href='" + bookManagerAbs + "'", true);
                return;
            }
        }
        this.ClientScript.RegisterClientScriptBlock(this.GetType(), "", "alert('修改失败');", true);
    }

    protected void DetailsView1_ModeChanging(object sender, DetailsViewModeEventArgs e)
    {
        if(e.CancelingEdit)
        {
            Response.Redirect("~/Web/Admin/BookManager.aspx");
        }
    }


    
}