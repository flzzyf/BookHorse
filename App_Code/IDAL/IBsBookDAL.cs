using System;
using System.Collections.Generic;
public interface IBsBookDAL
{
    int AddBsBook(BsBook bsBook); //添加图书
    int DeleteBsBook(int id); //删除图书
    int EditBsBook(BsBook bsBook); //修改图书
    BsBook FindBsBook(int id); //按ID查询图书
    IList<BsBook> FindBsBooks(int catID, string name, string author,
    string sortExpression, int startRowIndex, int maximumRows); //分页查询图书

    IList<BsBook> FindBsBooks(); //查询图书
    int FindCount(int catID, string name, string author);//查询记录数
}

