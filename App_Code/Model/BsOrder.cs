using System;
public class BsOrder
{
    private int _id;
    private string _userID;
    private DateTime _date;
    private int _state;

    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }

    public string UserID
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
