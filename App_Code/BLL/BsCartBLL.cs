using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
///CartBLL 的摘要说明
/// </summary> 
[Serializable]
public class BsCartBLL : IBsCartBLL
{
    private Dictionary<int, CartItem> cartItems = new Dictionary<int, CartItem>();
    public void AddItem(CartItem cartItem)
    {
        CartItem cartItem1;
        if (!cartItems.TryGetValue(cartItem.ID, out cartItem1))
        {
            cartItems.Add(cartItem.ID, cartItem);
        }
        else
        {
            cartItem1.Quantity += cartItem.Quantity;
        }
    }
    public void EditItem(int id,int quantity)
    {
        CartItem cartItem1;
        if (!cartItems.TryGetValue(id, out cartItem1))
        {
            if (quantity > 0)
                cartItem1.Quantity = quantity;
            else
                DeleteItem(id);
        } 
    }
    public void DeleteItem(int id)
    {
        cartItems.Remove(id);
    }
    
    public ICollection<CartItem> FindItems()
    {
        return cartItems.Values;
    }
    public void DeleteAll()
    {
        cartItems.Clear();
    }
    public decimal FindTotal()
    {
        decimal total = 0;
        foreach (CartItem item in cartItems.Values)
            total += item.Price * item.Quantity;
        return total;
    }
    public int FindCount()
    {
        return cartItems.Count;
    }
}
