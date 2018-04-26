using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
public class BsBookDAL : IBsBookDAL
{
    public int AddBsBook(BsBook bsBook)
    {
        string sql = String.Format("insert into BsBook(catID,name,image,price,summary,author) values ({0},'{1}','{2}',{3},'{4}','{5}')", bsBook.CatID, bsBook.Name, bsBook.Image, bsBook.Price, bsBook.Summary, bsBook.Author);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    public int EditBsBook(BsBook bsBook)
    {
        string sql = String.Format("update BsBook set catID={0},name='{1}',price={2},summary='{3}',author='{4}' where id={5}", bsBook.CatID, bsBook.Name, bsBook.Price, bsBook.Summary, bsBook.Author, bsBook.ID);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    public int DeleteBsBook(int id)
    {
        string sql = String.Format("delete from BsBook where id={0}", id);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    public BsBook FindBsBook(int id)
    {
        BsBook bsBook = null;
        string sql = String.Format("select a.name as CatName,b.* from BsCategory a, BsBook b where a.id=b.catID and b.id={0}", id);
        SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
        if (sdr.Read())
        {
            bsBook = new BsBook(sdr.GetString(0), sdr.GetInt32(1), sdr.GetInt32(2), sdr.GetString(3), sdr.GetString(4), sdr.GetDecimal(5), sdr.GetString(6), sdr.GetString(7));
        }
        sdr.Close();
        return bsBook;
    }
    public IList<BsBook> FindBsBooks(int catID, string name, string author, string sortExpression, int startRowIndex, int maximumRows)
    {
        IList<BsBook> list = new List<BsBook>();
        string sort = "";
        if (!String.IsNullOrEmpty(sortExpression))
        {
            sort = string.Format("order by b.{0}", sortExpression);
        }
        string sql = String.Format("select a.name as CatName,b.* from BsCategory a,BsBook b where a.id=b.catID and {0} b.catID like '%{1}%' and b.author like '%{2}%' {3}", (catID == 0 ? "" : "b.catID=" + catID + " and"), name, author, sort);
        DataTable dt = SqlHelper.ExecuteQuery(sql, startRowIndex, maximumRows);
        if (dt != null)
        {
            BsBook bsBook = null;
            foreach (DataRow row in dt.Rows)
            {
                bsBook = new BsBook();
                bsBook.BsCategory.Name = row["CatName"].ToString();
                bsBook.ID = Int32.Parse(row["id"].ToString());
                bsBook.CatID = Int32.Parse(row["catID"].ToString());
                bsBook.Name = row["name"].ToString();
                bsBook.Image = row["image"].ToString();
                bsBook.Price = decimal.Parse(row["price"].ToString());
                bsBook.Summary = row["summary"].ToString();
                bsBook.Author = row["author"].ToString();
                list.Add(bsBook);
            }
        }
        return list;
    }

    public IList<BsBook> FindBsBooks()
    {
        IList<BsBook> list = new List<BsBook>();
        string sort = "";

        string sql = String.Format("select * from BsBook");
        DataTable dt = SqlHelper.ExecuteQuery(sql);
        if (dt != null)
        {
            BsBook bsBook = null;
            foreach (DataRow row in dt.Rows)
            {
                bsBook = new BsBook();
                bsBook.BsCategory.Name = row["CatName"].ToString();
                bsBook.ID = Int32.Parse(row["id"].ToString());
                bsBook.CatID = Int32.Parse(row["catID"].ToString());
                bsBook.Name = row["name"].ToString();
                bsBook.Image = row["image"].ToString();
                bsBook.Price = decimal.Parse(row["price"].ToString());
                bsBook.Summary = row["summary"].ToString();
                bsBook.Author = row["author"].ToString();
                list.Add(bsBook);
            }
        }
        return list;
    }
    public int FindCount(int catID, string name, string author)
    {
        string sql = String.Format("select count(*) from BsBook where {0} catID like '%{1}%' and author like '%{2}%'", (catID == 0 ? "" : "catID=" + catID + " and"), name, author);
        return (int)SqlHelper.ExecuteScalar(sql);
    }
}
