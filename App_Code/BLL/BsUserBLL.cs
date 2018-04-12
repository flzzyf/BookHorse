using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
public class BsUserBLL : IBsUserBLL
{
    private IBsUserDAL bsUserDAL = new BsUserDAL();
    public int AddBsUser(BsUser bsUser)
    {
        return bsUserDAL.AddBsUser(bsUser);
    }
    public int EditBsUser(BsUser bsUser)
    {
        return bsUserDAL.EditBsUser(bsUser);
    }
    public void DeleteBsUser(int id)
    {
        bsUserDAL.DeleteBsUser(id);
    }
    public BsUser FindBsUser(string username, string password)
    {
        return bsUserDAL.FindBsUser(username, password);
    }
    public BsUser FindBsUser(int id)
    {
        return bsUserDAL.FindBsUser(id);
    }
    public IList<BsUser> findBsUsers(string username)
    {
        return bsUserDAL.findBsUsers(username);
    }
}
