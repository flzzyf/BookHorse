using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// DBConnect 的摘要说明
/// </summary>
public class DBConnect
{
    public static SqlConnection connection;

    public static void StartConnection(string uid = "sa", string pwd = "123", string db = "BookStore")
    {
        string connectString = "uid=" + uid + ";pwd=" + pwd + ";database=" + db;
        connection = new SqlConnection(connectString);
        connection.Open();
    }

    public static void EndConnection()
    {
        connection.Close();
    }
    public static SqlDataReader ExecuteSql(string _sql)
    {
        SqlCommand cmd = new SqlCommand(_sql, connection);

        SqlDataReader dr = cmd.ExecuteReader();

        return dr;
    }

}