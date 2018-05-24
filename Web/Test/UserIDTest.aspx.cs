using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Web_UserIDTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //34000000-0000-0000-0000-000000000001
        BsUser bsUser = null;
        string sql = String.Format("select * from BsUser where ID='13000000-0000-0000-0000-000000000000'");
        SqlDataReader sdr = SqlHelper.ExecuteReader(sql);

        if (sdr.Read())
        {
            bsUser = new BsUser(sdr.GetGuid(0), sdr.GetString(1), sdr.GetString(2), sdr.GetString(3), sdr.GetString(4), sdr.GetString(5), sdr.GetString(6), sdr.GetString(7), sdr.GetInt32(8));

            Label1.Text = bsUser.ID.ToString();
        }
        sdr.Close();
    }
}