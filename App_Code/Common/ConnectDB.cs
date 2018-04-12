using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data.OleDb;
/// <summary>
///ConnectDB 的摘要说明
/// </summary>
public class ConnectDB
{
    private static String connectString = ConfigurationManager.ConnectionStrings["connectString"].ConnectionString;
    //public static SqlConnection connect()
    //public static OleDbConnection connect()
    public static SqlConnection Connect()
    {
        try
        {
            //OracleConnection con = new OracleConnection();
            //con.ConnectionString = "Data Source=WWW-E2BDCCB29F0;uid=system;pwd=oracle;Integrated Security=no";

            SqlConnection con = new SqlConnection(connectString);
          
            //con.ConnectionString = "Persist Security Info=False;Integrated Security=SSPI;database=bookstore;server=WWW-E2BDCCB29F0\\SQLEXPRESS;Connect Timeout=30";

            //con.ConnectionString = "server=WWW-E2BDCCB29F0\\SQLEXPRESS;uid=yang;pwd=1234;database=bookstore";
            //OleDbConnection con = new OleDbConnection();
            //con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|pho.mdb";
            //con.ConnectionString = "Driver={Microsoft Access Driver(*.mdb)};DBQ=|DataDirectory|pho.mdb";
            //con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password=;User ID=Admin;Data Source=|DataDirectory|pho.mdb";

            //con.Open();
            return con;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return null;
        }
    }
}
