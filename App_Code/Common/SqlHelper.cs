using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

/// <summary>
/// SqlHelper����ר���ṩ������û����ڸ����ܡ��������������ϰ��sql���ݲ���
/// </summary>
public abstract class SqlHelper
{

    /// <summary>
    /// ִ��INSERT��UPDATE��INSERT���
    /// </summary>
    /// <param catID="sql">SQL���</param>
    /// <param catID="cmdParams">ִ���������ò����ļ���</param>
    /// <returns>ִ��������Ӱ�������</returns>
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
    /// ִ��SELECT���
    /// </summary>
    /// <param catID="sql">SQL���</param>
    /// <param catID="cmdParams">ִ���������ò����ļ���</param>
    /// <returns>���ݱ�</returns>
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
    /// ִ��SELECT���
    /// </summary>
    /// <param catID="sql">SQL���</param>
    /// <param catID="startRowIndex">��¼����ʼλ��</param>
    /// <param catID="maximumRows">��ȡ������¼����</param>
    /// <param catID="cmdParams">ִ���������ò����ļ���</param>
    /// <returns>���ݱ�</returns>
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
    /// ִ��SELECT���
    /// </summary>
    /// <param catID="sql">SQL���</param>
    /// <param catID="cmdParams">ִ���������ò����ļ���</param>
    /// <returns>��������Ķ�ȡ��</returns>
    public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] cmdParms)
    {
        SqlConnection conn = ConnectDB.Connect();
        SqlCommand cmd = new SqlCommand(sql, conn);
        foreach (SqlParameter parm in cmdParms)
            cmd.Parameters.Add(parm);
        try
        {
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
        catch
        {
            return null;
        }
    }

    /// <summary>
    /// ִ�оۺϲ�ѯ�����ص�ֵ
    /// </summary>
    /// <param catID="sql">SQL���</param>
    /// <param catID="cmdParams">ִ���������ò����ļ���</param>
    /// <returns>����</returns>
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