using System;
/// <summary>
/// User 的摘要说明
/// </summary>
public class BsUser
{
    private Guid  _ID;
    private String _Username;
    private String _Password;
    private String _Realname;
    private String _Email;
    private String _Phone;
    private String _Address;
    private String _Zipcode;
    private int _Role;
    public BsUser()
    { }
    public BsUser(Guid id, string username, string password, string realname, string email, string phone, string address, string zipcode, int role)
    {
        _ID = id;
        _Username = username;
        _Password = password;
        _Realname = realname;
        _Email = email;
        _Phone = phone;
        _Address = address;
        _Zipcode = zipcode;
        _Role = role;
    }
    public Guid ID
    {
        get { return _ID; }
        set { _ID = value; }
    }
    public String Username
    {
        get { return _Username; }
        set { _Username = value; }
    }
    public String Password
    {
        get { return _Password; }
        set { _Password = value; }
    }
    public String Realname
    {
        get { return _Realname; }
        set { _Realname = value; }
    }
    
    public String Email
    {
        get { return _Email; }
        set { _Email = value; }
    }
    public String Phone
    {
        get { return _Phone; }
        set { _Phone = value; }
    }
    public String Address
    {
        get { return _Address; }
        set { _Address = value; }
    }
    public String Zipcode
    {
        get { return _Zipcode; }
        set { _Zipcode = value; }
    }
   
    public int Role
    {
        get { return _Role; }
        set { _Role = value; }
    }
}
