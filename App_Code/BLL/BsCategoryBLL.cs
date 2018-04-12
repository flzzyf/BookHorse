using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
public class BsCategoryBLL : IBsCategoryBLL
{
    private IBsCategoryDAL bsCategoryDAL = new BsCategoryDAL();
    public int AddBsCategory(BsCategory bsCategory)
    {
        return bsCategoryDAL.AddBsCategory(bsCategory);
    }
    public int EditBsCategory(BsCategory bsCategory)
    {
        return bsCategoryDAL.EditBsCategory(bsCategory);
    }
    public int DeleteBsCategory(int id)
    {
        return bsCategoryDAL.DeleteBsCategory(id);
    }
    public IList<BsCategory> FindBsCategories()
    {
        return bsCategoryDAL.FindBsCategories();
    }
}
