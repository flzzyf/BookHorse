using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// 图书数据访问层实现类
/// </summary>
public class BsOrderDAL : IBsOrderDAL
{
    public int AddBsOrder(BsOrder order, ICollection<CartItem> items)
    {
        string sql = String.Format("insert into BsOrder(UserID) values ('{0}');", order.UserID);
        foreach (CartItem item in items)
        {
            sql += String.Format("insert into BsDetail(OrderID,BookID,Quantity,Price) values (IDENT_CURRENT( 'BsOrder' ),{0},{1},{2});", item.ID,item.Quantity,item.Price);
        }
        SqlHelper.ExecuteNonQuery(sql);

        sql = String.Format("select top 1 ID from BsOrder where UserID='{0}' order by ID desc;", order.UserID);
        return (int)SqlHelper.ExecuteScalar(sql);
    }

    public int EditBsOrder(BsOrder order)
    {
        string sql = String.Format("update BsOrder set State={0} where id={1}",order.State,order.ID);
        return SqlHelper.ExecuteNonQuery(sql);
    }

    public int DeleteBsOrder(int id)
    {
        string sql = String.Format("delete from BsOrder where id={0};delete from BsDetail where id={0}", id);
        return SqlHelper.ExecuteNonQuery(sql);
    }

    public BsOrder FindBsOrder(int id)
    {
        BsOrder bsOrder = null;
        string sql = String.Format("select ID,UserID,Date,State from BsOrder where id={0}", id);
        SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
        if (sdr.Read())
        {
            bsOrder = new BsOrder(sdr.GetInt32(0), sdr.GetGuid(1), sdr.GetDateTime(2), sdr.GetInt32(3));
        }
        sdr.Close();
        return bsOrder;
    }

    public IList<BsOrder> FindBsOrders(string username, int state)
    {
        IList<BsOrder> list = new List<BsOrder>(); 
        string sql = String.Format("select a.UserName,b.* from aspnet_users a,BsOrder b where a.UserId=b.UserId and {0} a.UserName like '%{1}%'", (state == -1 ? "" : "b.state=" + state + " and"), username);
        DataTable dt = SqlHelper.ExecuteQuery(sql);
        if (dt != null)
        {
            BsOrder bsOrder = null;
            foreach (DataRow row in dt.Rows)
            {
                bsOrder = new BsOrder();
                bsOrder.ID = Int32.Parse(row["ID"].ToString());
                bsOrder.UserID = new Guid(row["UserId"].ToString());
                bsOrder.Date = DateTime.Parse(row["date"].ToString());
                bsOrder.State = Int32.Parse(row["State"].ToString());
                list.Add(bsOrder);
            }
        }
        return list;
    }
    public IList<BsOrder> FindBsOrders(Guid UserId, int state)
    {
        IList<BsOrder> list = new List<BsOrder>(); ;
        string sql = String.Format("select * from BsOrder where {0} UserId='{1}'", (state == -1 ? "" : "b.state=" + state + " and"), UserId);
        DataTable dt = SqlHelper.ExecuteQuery(sql);
        if (dt != null)
        {
            BsOrder bsOrder = null;
            foreach (DataRow row in dt.Rows)
            {
                bsOrder = new BsOrder();
                bsOrder.ID = Int32.Parse(row["ID"].ToString());
                bsOrder.UserID = new Guid(row["UserId"].ToString());
                bsOrder.Date = DateTime.Parse(row["date"].ToString());
                bsOrder.State = Int32.Parse(row["State"].ToString());
                list.Add(bsOrder);
            }
        }
        return list;
    }
}

