using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

/// <summary>
/// SqlHelper类是专门提供给广大用户用于高性能、可升级和最佳练习的sql数据操作
/// </summary>
public abstract class SqlHelper
{

    /// <summary>
    /// 执行INSERT、UPDATE或INSERT语句
    /// </summary>
    /// <param catID="sql">SQL语句</param>
    /// <param catID="cmdParams">执行命令所用参数的集合</param>
    /// <returns>执行命令所影响的行数</returns>
    public static int ExecuteNonQuery(String sql, params SqlParameter[] cmdParms)
    {
        SqlConnection conn = ConnectDB.Connect();
        SqlCommand cmd = new SqlCommand(sql, conn);
        foreach (SqlParameter parm in cmdParms)
            cmd.Parameters.Add(parm);
        try
        {
            conn.Open();
            return cmd.ExecuteNonQuery();
        }
        catch 
        {
            return 0;
        }
        finally
        {
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }
    /// <summary>
    /// 执行SELECT语句
    /// </summary>
    /// <param catID="sql">SQL语句</param>
    /// <param catID="cmdParams">执行命令所用参数的集合</param>
    /// <returns>数据表</returns>
    public static DataTable ExecuteQuery(String sql,params SqlParameter[] cmdParms)
    {
        SqlConnection conn = ConnectDB.Connect();
        SqlCommand cmd = new SqlCommand(sql, conn);
        foreach (SqlParameter parm in cmdParms)
            cmd.Parameters.Add(parm);
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        try
        {
            da.Fill(dt);
        }
        catch
        {
            return null;
        }
        finally
        {
            da.Dispose();
            cmd.Dispose();
        }
        return dt;
    }
    /// <summary>
    /// 执行SELECT语句
    /// </summary>
    /// <param catID="sql">SQL语句</param>
    /// <param catID="startRowIndex">记录的起始位置</param>
    /// <param catID="maximumRows">读取的最大记录个数</param>
    /// <param catID="cmdParams">执行命令所用参数的集合</param>
    /// <returns>数据表</returns>
    public static DataTable ExecuteQuery(String sql, int startRowIndex, int maximumRows, params SqlParameter[] cmdParms)
    {
        SqlConnection conn = ConnectDB.Connect();
        SqlCommand cmd = new SqlCommand(sql, conn);
        foreach (SqlParameter parm in cmdParms)
            cmd.Parameters.Add(parm);
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        try
        {
            da.Fill(startRowIndex, maximumRows, dt);
        }
        catch
        {
            return null;
        }
        finally
        {
            da.Dispose();
            cmd.Dispose();
        }
        return dt;
    }


    /// <summary>
    /// 执行SELECT语句
    /// </summary>
    /// <param catID="sql">SQL语句</param>
    /// <param catID="cmdParams">执行命令所用参数的集合</param>
    /// <returns>包含结果的读取器</returns>
    public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] cmdParms)
    {
        DBConnect.StartConnection();
        SqlConnection conn = DBConnect.connection;
        SqlCommand cmd = new SqlCommand(sql, conn);
        foreach (SqlParameter parm in cmdParms)
            cmd.Parameters.Add(parm);
        try
        {
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return dr;
        }
        catch
        {
            return null;
        }

    }

    /// <summary>
    /// 执行聚合查询，返回单值
    /// </summary>
    /// <param catID="sql">SQL语句</param>
    /// <param catID="cmdParams">执行命令所用参数的集合</param>
    /// <returns>对象</returns>
    public static object ExecuteScalar(string sql, params SqlParameter[] cmdParms)
    {
        SqlConnection conn = ConnectDB.Connect();
        SqlCommand cmd = new SqlCommand(sql, conn);
        try
        {
            conn.Open();
            object val = cmd.ExecuteScalar();
            return val;
        }
        catch(Exception ee)
        {
            Console.WriteLine(ee.Message);
            return null;
        }
        finally
        {
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

}