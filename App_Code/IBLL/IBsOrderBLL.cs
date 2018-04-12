using System;
using System.Collections.Generic;
public interface IBsOrderBLL
{
    int AddBsOrder(BsOrder bsOrder, ICollection<CartItem> items); //添加订单
    int DeleteBsOrder(int id); //删除订单
    int EditBsOrder(BsOrder bsOrder); //修改订单
    BsOrder FindBsOrder(int id); //按ID查询订单
    IList<BsOrder> FindBsOrders(string username, int state); //查询订单
    IList<BsDetail> FindBsDetails(int orderID); //查询订单细目
}
