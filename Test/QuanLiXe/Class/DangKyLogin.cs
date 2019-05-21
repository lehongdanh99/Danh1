using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace QuanLiXe
{
    class DangKyLogin
    {
        MY_DB mydb = new MY_DB();
        public bool insertLogin(string user,string pass,string type)
        {
            SqlCommand cmd = new SqlCommand("insert into LOGIN(username,password,type)"+
                "values (@user,@pass,@type)",mydb.getConnection);
            cmd.Parameters.Add("@user", SqlDbType.NChar).Value = user;
            cmd.Parameters.Add("@pass", SqlDbType.NChar).Value = pass;
            cmd.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        
        public bool usernameExist(string user)
        {
            SqlCommand cmd = new SqlCommand("select * from LOGIN where username =@user", mydb.getConnection);

            cmd.Parameters.Add("@user", SqlDbType.NChar).Value = user;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
