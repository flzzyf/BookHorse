using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
public class BsBookBLL : IBsBookBLL
{
    private IBsBookDAL bsBookDAL = new BsBookDAL();
    public int AddBsBook(BsBook bsBook)
    {
        return bsBookDAL.AddBsBook(bsBook);
    }
    public int EditBsBook(BsBook bsBook)
    {
        return bsBookDAL.EditBsBook(bsBook);
    }
    public int DeleteBsBook(int id)
    {
        return bsBookDAL.DeleteBsBook(id);
    }
    public BsBook FindBsBook(int id)
    {
        return bsBookDAL.FindBsBook(id);
    }
    public IList<BsBook> FindBsBooks(int catID, string name, string author,string sortExpression, int startRowIndex, int maximumRows)
    {
        return bsBookDAL.FindBsBooks(catID, name, author, sortExpression,startRowIndex, maximumRows);
    }

    public IList<BsBook> FindBsBooks()
    {
        return bsBookDAL.FindBsBooks();
    }
    public int FindCount(int catID, string name, string author)
    {
        return bsBookDAL.FindCount(catID, name, author);
    }
    /*
    public int FindCount(int catID, string name, string author, string sortExpression, int startRowIndex, int maximumRows)
    {
        return bsBookDAL.FindCount(catID, name, author);
    }*/
}
