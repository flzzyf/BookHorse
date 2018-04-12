using System;
using System.Collections.Generic;
public interface IBsUserDAL
{
    int AddBsUser(BsUser bsUser); //添加用户
    void DeleteBsUser(int id); //删除用户
    int EditBsUser(BsUser bsUser); //修改用户
    BsUser FindBsUser(int id); //按ID查询用户
    BsUser FindBsUser(string username, string password); //按用户名和密码查询
    IList<BsUser> findBsUsers(string username); //查询用户
}
