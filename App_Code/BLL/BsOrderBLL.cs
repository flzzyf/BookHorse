using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

/// <summary>
///BsOrderBLL 的摘要说明
/// </summary>
public class BsOrderBLL
{
    private BsOrderDAL orderDAL = new BsOrderDAL();
    public int AddBsOrder(BsOrder order, ICollection<CartItem> items)
    {
        return orderDAL.AddBsOrder(order, items);
    }

    public int EditBsOrder(BsOrder order)
    {
        return orderDAL.EditBsOrder(order);
    }

    public int DeleteBsOrder(int id)
    {
        return orderDAL.DeleteBsOrder(id);
    }

    public BsOrder FindBsOrder(int id)
    {
        return orderDAL.FindBsOrder(id);
    }

    public IList<BsOrder> FindBsOrders(string username, int state)
    {
        return orderDAL.FindBsOrders(username, state);
    }
}
