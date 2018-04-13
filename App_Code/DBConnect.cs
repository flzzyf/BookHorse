using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// DBConnect 的摘要说明
/// </summary>
public class DBConnect
{
    public static SqlConnection connection;

    private static String connectionString = 
        ConfigurationManager.ConnectionStrings["BookStoreConnectionString"].ConnectionString;

    public static void StartConnection()
    {
        connection = new SqlConnection(connectionString);
        connection.Open();
    }
    public static void StartConnection(string uid, string pwd, string db)
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