using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
public class BsUserDAL : IBsUserDAL
{
    public int AddBsUser(BsUser bsUser)
    {
        string sql = String.Format("insert into BsUser(username,password,realname,email,phone,address,zipcode) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", bsUser.Username, bsUser.Password, bsUser.Realname, bsUser.Email, bsUser.Phone, bsUser.Address, bsUser.Zipcode);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    public int EditBsUser(BsUser bsUser)
    {
        string sql = String.Format("update BsUser set username='{0}',password='{1}',realname='{2}',email='{3}',phone='{4}',address='{5}',ipcode='{6}',role={7} where id={8}", bsUser.Username, bsUser.Password, bsUser.Realname, bsUser.Email, bsUser.Phone, bsUser.Address, bsUser.Role, bsUser.Zipcode, bsUser.ID);
        return SqlHelper.ExecuteNonQuery(sql);
    }
    public void DeleteBsUser(int id)
    {
        string sql = String.Format("delete BsUser where id={0}", id);
        SqlHelper.ExecuteNonQuery(sql);
    }
    public BsUser FindBsUser(string username, string password)
    {
        BsUser bsUser = null;
        string sql = String.Format("select * from BsUser where username='{0}' and password='{1}'", username, password);
        SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
        if (sdr.Read())
        {
            bsUser = new BsUser(sdr.GetGuid(0), sdr.GetString(1), sdr.GetString(2), sdr.GetString(3), sdr.GetString(4), sdr.GetString(5), sdr.GetString(6), sdr.GetString(7), sdr.GetInt32(8));
        }
        sdr.Close();
        return bsUser;
    }
    public BsUser FindBsUser(int id)
    {
        BsUser bsUser = null;
        string sql = String.Format("select * from BsUser where id={0}", id);
        SqlDataReader sdr = SqlHelper.ExecuteReader(sql);
        if (sdr.Read())
        {
            bsUser = new BsUser(sdr.GetGuid(0), sdr.GetString(1), sdr.GetString(2), sdr.GetString(3), sdr.GetString(4), sdr.GetString(5), sdr.GetString(6), sdr.GetString(7), sdr.GetInt32(8));
        }
        sdr.Close();
        return bsUser;
    }
    public IList<BsUser> findBsUsers(string username)
    {
        IList<BsUser> list = new List<BsUser>();
        string sql = String.Format("select * from BsUser where username like '{0}'", "%" + username + "%");
        DataTable dt = SqlHelper.ExecuteQuery(sql);
        if (dt != null)
        {
            BsUser bsUser = null;
            foreach (DataRow row in dt.Rows)
            {
                bsUser = new BsUser();
                bsUser.ID = (Guid)row["id"];
                bsUser.Username = row["username"].ToString();
                bsUser.Password = row["password"].ToString();
                bsUser.Realname = row["realname"].ToString();
                bsUser.Email = row["email"].ToString();
                bsUser.Phone = row["phone"].ToString();
                bsUser.Address = row["address"].ToString();
                bsUser.Zipcode = row["zipcode"].ToString();
                bsUser.Role = Int32.Parse(row["role"].ToString());
                list.Add(bsUser);
            }
        }
        return list;
    }
}
