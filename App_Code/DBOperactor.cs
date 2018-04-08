using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// DBOperactor 的摘要说明
/// </summary>
public class DBOperactor
{
    public static DBOperactor instance;

    public static void Init()
    {
        instance = new DBOperactor();
    }
    public DBOperactor()
    {

    }
    public List<List<Object>> Search(string _s, string _tbName, string _columnName)
    {
        DBConnect.StartConnection();

        string sql = "select * from " + _tbName + " where " + _columnName + " like '%" + _s + "%'";

        SqlDataReader dr = DBConnect.ExecuteSql(sql);

        List<List<Object>> list = new List<List<object>>();

        int a = 0;

        while (dr.Read())
        {
            Console.WriteLine(dr.Depth);

            for (int i = 0; i < dr.FieldCount; i++)
            {
                list[a][i] = dr.GetValue(i);

            }

            a++;

        }

        dr.Close();
        DBConnect.EndConnection();

        return list;
    }
}