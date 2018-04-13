using System;
using System.Collections.Generic;
public interface IBsCategoryDAL
{
    int AddBsCategory(BsCategory bsCategory); //添加分类
    int DeleteBsCategory(int id); //删除分类
    int EditBsCategory(BsCategory bsCategory); //修改分类

    IList<BsCategory> FindBsCategories(); //查所有分类
    IList<BsCategory> FindBsCategories(int _id = -1); //查所有分类
}
