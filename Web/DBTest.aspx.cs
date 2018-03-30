using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Web_DBTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void bt_search_Click(object sender, EventArgs e)
    {
        string s = tb_search.Text;

        Search(s);
    }

    void Search(string _s)
    {
        DBConnect.StartConnection();

        string sql = "select * from Book where name like '%" + _s + "%'";

        SqlDataReader dr = DBConnect.ExecuteSql(sql);

        string s = "";
        while (dr.Read())
        {
            s += dr.GetInt32(0);
            s += " ";

            s += dr.GetString(1);
            s += "</br>";

        }

        Label1.Text = s;

        dr.Close();
        DBConnect.EndConnection();
    }
}