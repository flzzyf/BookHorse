using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web_Test_Test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BsOrder order = new BsOrder();
        order.State = -1;
    }
}