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


    protected void DetailsView1_ModeChanging(object sender, DetailsViewModeEventArgs e)
    {
        if(e.CancelingEdit)
        {
            Response.Redirect("BookManager.aspx");
        }
    }


    protected void ObjectDataSource1_Inserted(object sender, ObjectDataSourceStatusEventArgs e)
    {
        e.AffectedRows = (int)e.ReturnValue;
    }

    protected void DetailsView1_ItemInserting(object sender, DetailsViewInsertEventArgs e)
    {

        string saveDir = @"\Web\Common\BookImages\";
        string appPath = Request.PhysicalApplicationPath;
        FileUpload upload = ((FileUpload)DetailsView1.FindControl("FileUpload1"));
        if (upload.HasFile)
        {
            int fileSize = upload.PostedFile.ContentLength;
            if (fileSize < 2100000) //文件大小大约2M
            {
                string ext = System.IO.Path.GetExtension(upload.FileName);
                if ((ext == ".jpg") || (ext == ".gif"))
                {
                    String filename = DateTime.Now.Ticks.ToString() + ext;//以时间戳作为文件名
                    string savePath = appPath + saveDir + filename;
                    upload.SaveAs(savePath);
                    e.Values.Add("Image", filename);
                }
                else
                {
                    this.ClientScript.RegisterClientScriptBlock(this.GetType(), "", "alert('添加失败,上传图片扩展名必须是.jpg或.gif');", true);
                    e.Cancel = true;
                }
            }
            else
            {
                this.ClientScript.RegisterClientScriptBlock(this.GetType(), "", "alert('添加失败,上传图片文件大小不能超过2MB.');", true);
                e.Cancel = true;
            }
        }
        else
        {
            this.ClientScript.RegisterClientScriptBlock(this.GetType(), "", "alert('添加失败,上传图片文件不能为空.');", true);
            e.Cancel = true;
        }
    }

    protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
    {
        if (e.Exception == null)
        {
            if (e.AffectedRows > 0)
            {
                this.ClientScript.RegisterClientScriptBlock(this.GetType(), "", "alert('添加成功');window.location.href='BookManager.aspx'", true);
                return;
            }
        }
        this.ClientScript.RegisterClientScriptBlock(this.GetType(), "", "alert('添加失败');", true);
    }





}