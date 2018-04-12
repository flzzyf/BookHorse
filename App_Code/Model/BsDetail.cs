using System;
public class BsDetail
{
    private int _orderID;
    private int _bookID;
    private int _quantity;
    private decimal _price;

    public int OrderID
    {
        get { return _orderID; }
        set { _orderID = value; }
    }

    public int BookID
    {
        get { return _bookID; }
        set { _bookID = value; }
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
}
