using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Category 的摘要说明
/// </summary>
public class BsCategory
{
    private int _ID;
    private string _Name;
    public BsCategory()
    { }
    public BsCategory(int id, string name)
    {
        _ID = id;
        _Name = name;
    }
    public int ID
    {
        get { return _ID; }
        set { _ID = value; }
    }

    public String Name
    {
        get { return _Name; }
        set { _Name = value; }
    }

    public DataSet Select(int a)
    {
        DataSet data = new DataSet();

        return data;
    }

    public void Update(int a)
    {

    }

    public void Delete(int a)
    {

    }
}
