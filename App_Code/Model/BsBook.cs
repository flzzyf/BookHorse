using System;
using System.Data;
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
///Book 的摘要说明
/// </summary>
public class BsBook 
{
    private int _ID;
    private int _CatID;
    private BsCategory _BsCategory;
    private string _Name;
    private string _Image;
    private decimal _Price;
    private string _Summary;
    private string _Author;
    public BsBook()
    {
        _BsCategory = new BsCategory();
    }
    public BsBook(string catName,int id, int catID, string name, string image, decimal price, string summary, string author)
    {
        _BsCategory = new BsCategory();
        _BsCategory.ID = catID;
        _BsCategory.Name = catName;
        _ID = id;
        _CatID = catID;
        _Name = name;
        _Image = image;
        _Price = price;
        _Summary = summary;
        _Author = author;
    }

    public int ID
    {
        get { return _ID; }
        set { _ID = value; }
    }
    public int CatID
    {
        get { return _CatID; }
        set { _CatID = value; }
    }
    public BsCategory BsCategory
    {
        get { return _BsCategory; }
        set { _BsCategory = value; }
    }
    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }
    public string Image
    {
        get { return _Image; }
        set { _Image = value; }
    }
    public decimal Price
    {
        get { return _Price; }
        set { _Price = value; }
    }
    public string Summary
    {
        get { return _Summary; }
        set { _Summary = value; }
    }
    public string Author
    {
        get { return _Author; }
        set { _Author = value; }
    }

}
