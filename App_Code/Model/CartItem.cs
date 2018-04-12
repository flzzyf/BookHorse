using System;
[Serializable]
public class CartItem
{
    private int _id;
    private string _name;
    private int _quantity;
    private decimal _price;

    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }

    public decimal Price
    {
        get { return _price; }
        set { _price = value; }
    }
    public decimal Total
    {
        get { return _price * _quantity; }
    }
}
