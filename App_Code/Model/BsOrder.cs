using System;
public class BsOrder
{
    private int _id;
    private Guid _userID;
    private DateTime _date;
    private int _state;

    public BsOrder()
    {
    }
    public BsOrder(int id, Guid userID, DateTime date, int state)
    {
        _id = id;
        _userID = userID;
        _date = date;
        _state = state;
    }
    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }

    public Guid UserID
    {
        get { return _userID; }
        set { _userID = value; }
    }

    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public int State
    {
        get { return _state; }
        set { _state = value; }
    }
}
