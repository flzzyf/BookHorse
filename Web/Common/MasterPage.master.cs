using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Label1.Text = "Copyright &copy; 2011-2015 YSL. All Rights Reserved.<br />";
        //Label1.Text += "访问人数：" + Application["AccessCount"] + "&nbsp;&nbsp;当前在线：" + Membership.GetNumberOfUsersOnline() + "<br />版权所有";
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        //Label1.Text = "Copyright &copy; 2011-2015 YSL. All Rights Reserved.<br />";
        //Label1.Text += "访问人数：" + Application["AccessCount"] + "&nbsp;&nbsp;当前在线：" + Membership.GetNumberOfUsersOnline() + "<br />版权所有";
    }
}
