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
        DBOperactor.Init();
    }

    protected void bt_search_Click(object sender, EventArgs e)
    {
        string s = tb_search.Text;

        //Search(s);
        //Insert(s);

        //Label1.Text = s;
        //Search(s);

        List<List<Object>> list = DBOperactor.instance.Search("z", "Book2", "name");
        Label1.Text = list[0][0].ToString();
    }

    void Insert(string _s)
    {
        DBConnect.StartConnection();

        string sql = "insert into Book2 (name) values ('" + _s + "')";
        DBConnect.ExecuteSql(sql);

        DBConnect.EndConnection();
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        BsCategoryDAL bsCat = new BsCategoryDAL();
        GridView1.DataSource = bsCat.FindBsCategories();
        GridView1.DataBind();

        //ObjectDataSource1.
    }
}