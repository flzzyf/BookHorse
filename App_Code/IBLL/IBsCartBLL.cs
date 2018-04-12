using System;
using System.Collections.Generic;
public interface IBsCartBLL
{
    void AddItem(CartItem cartItem); //添加条目
    void DeleteAll(); //清空
    void DeleteItem(int id); //删除条目
    void EditItem(int id, int quantity); //修改数量
    ICollection<CartItem> FindItems(); //查询所有条目
    decimal FindTotal(); //查询总价
}
