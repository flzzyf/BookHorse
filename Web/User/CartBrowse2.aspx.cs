using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web_User_CartBrowse2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
    }

    void bind()
    {
        Label1.Text = "总价：" + Profile.BsCartBLL.FindTotal();
        GridView1.DataSource = Profile.BsCartBLL.FindItems();
        GridView1.DataBind();
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        bind();
    }


    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        bind();
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int id = Int32.Parse(GridView1.DataKeys[e.RowIndex].Value.ToString());
        int quantity = Int32.Parse(((TextBox)GridView1.Rows[e.RowIndex].Cells[3].FindControl("TextBox1")).Text);
        Profile.BsCartBLL.EditItem(id, quantity);
        Profile.Save();
        GridView1.EditIndex = -1;
        bind();
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Int32.Parse(GridView1.DataKeys[e.RowIndex].Value.ToString());
        Profile.BsCartBLL.DeleteItem(id);
        Profile.Save();
        bind();
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        bind();
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Profile.BsCartBLL.DeleteAll();
        Profile.Save();
        bind();
    }
}