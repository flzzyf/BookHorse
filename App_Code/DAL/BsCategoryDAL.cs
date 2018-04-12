using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
public class BsCategoryDAL : IBsCategoryDAL
{
    public int AddBsCategory(BsCategory bsCategory)
    {
        DBConnect.StartConnection();

        string sql = String.Format("insert into BsCategory(name) values('{0}')", bsCategory.Name);
        SqlCommand cmd = new SqlCommand(sql, DBConnect.connection);
        int num = cmd.ExecuteNonQuery();

        DBConnect.EndConnection();
        return num;
    }
    public int EditBsCategory(BsCategory bsCategory)
    {
        DBConnect.StartConnection();

        string sql = String.Format("update BsCategory set name='{0}' where id={1}", bsCategory.Name, bsCategory.ID);
        SqlCommand cmd = new SqlCommand(sql, DBConnect.connection);
        int num = cmd.ExecuteNonQuery();
        DBConnect.EndConnection();

        return num;
    }
    public int DeleteBsCategory(int id)
    {
        DBConnect.StartConnection();

        string sql = String.Format("delete from BsCategory where id={0}", id);
        SqlCommand cmd = new SqlCommand(sql, DBConnect.connection);
        int num = cmd.ExecuteNonQuery();

        DBConnect.EndConnection();
        return num;
    }
    public IList<BsCategory> FindBsCategories()
    {
        DBConnect.StartConnection();

        IList<BsCategory> list = new List<BsCategory>();
        string sql = "select * from BsCategory";
        SqlCommand cmd = new SqlCommand(sql, DBConnect.connection);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt != null)
        {
            BsCategory c = null;
            foreach (DataRow row in dt.Rows)
            {
                c = new BsCategory();
                c.ID = Int32.Parse(row["id"].ToString());
                c.Name = row["name"].ToString();
                list.Add(c);
            }
        }
        DBConnect.EndConnection();

        return list;
    }
}
