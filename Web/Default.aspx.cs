using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Web_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "1";
        TextBox2.Text = "1";
        Console.WriteLine("2");
        Console.WriteLine("1");
        /*
        string username = TextBox1.Text;
        string password = TextBox2.Text;

        MembershipUser user = Membership.CreateUser(username, password);

        //if(Membership.ValidateUser)
        */
    }
}