using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiXe
{
    class NhanVien
    {
        MY_DB mydb = new MY_DB();
        #region Giai Đoạn 1
        public bool insertNhanVien(string manv, string fname, string lname, string gender, DateTime bdate, string phone,
            string address, string cmnd, MemoryStream ava, string type)
        {
            SqlCommand cmd = new SqlCommand("insert into NhanVien(MaNV,fName,lName,gender,Birthday,Phone,Address,Cmnd,Ava,type)" +
                "values (@makh,@fname,@lname,@gender,@bdate,@phone,@add,@cmnd,@ava,@type)", mydb.getConnection);
            cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = manv;
            cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@add", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = cmnd;
            cmd.Parameters.Add("@ava", SqlDbType.Image).Value = ava.ToArray();
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;

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
        public DataTable getAllCus()
        {
            SqlCommand cmd = new SqlCommand("select *from NhanVien", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getAllTho()
        {
            SqlCommand cmd = new SqlCommand("select * from NhanVien where type='Tho'", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getAllVanPhong()
        {
            SqlCommand cmd = new SqlCommand("select * from NhanVien where type='Van Phong'", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getAllGS()
        {
            SqlCommand cmd = new SqlCommand("select * from NhanVien where type='Giam Sat'", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable refresh()
        {
            SqlCommand cmd = new SqlCommand("select * from NhanVien", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion
        public bool UpdateNhanVien(string manv, string fname, string lname, string gender, DateTime birthday, string phone, string address, string cmnd, MemoryStream pt, string type)
        {
            SqlCommand cmd = new SqlCommand("update NhanVien set fName=@fname,lName=@lName,Gender=@gender,Birthday=@birthday,Phone=@Phone," +
                "Address=@address,Cmnd=@cmnd,Ava=@ava,type=@type where MaNV=@manv", mydb.getConnection);
            cmd.Parameters.Add("@manv", SqlDbType.VarChar).Value = manv;
            cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@birthday", SqlDbType.DateTime).Value = birthday;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = cmnd;
            cmd.Parameters.Add("@ava", SqlDbType.Image).Value = pt.ToArray();
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
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
        public bool insertVanPhong(string manv, string type, string note, string mahd)
        {
            SqlCommand cmd = new SqlCommand("insert into Tho(MaNV,MaHD,Note,MaHD)" +
                "values (@makh,@type,@note,@mahd)", mydb.getConnection);
            cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = manv;
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = note;
            cmd.Parameters.Add("@mahd", SqlDbType.VarChar).Value = mahd;

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
        public bool DeleteNhanVien(string manv)
        {
            SqlCommand cmd = new SqlCommand("delete from NhanVien where MaNV=@manv", mydb.getConnection);
            cmd.Parameters.Add("@manv", SqlDbType.VarChar).Value = manv;
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
        public bool insertTho(string manv, string type, string note, string mahd)
        {
            SqlCommand cmd = new SqlCommand("insert into Tho(MaNV,Type,Note,MaHD)" +
                "values (@makh,@type,@note,@mahd)", mydb.getConnection);
            cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = manv;
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = note;
            cmd.Parameters.Add("@mahd", SqlDbType.VarChar).Value = mahd;

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
        public DataTable search(SqlCommand cmd)
        {
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }
        public DataTable getAllNV()
        {
            SqlCommand cmd = new SqlCommand("select *from NhanVien", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable chiaCa()
        {
            SqlCommand cmd = new SqlCommand("Select NHANVIEN.maNV,Thu2,Thu3,Thu4,Thu5,Thu6,Thu7 from NHANVIEN,ChiaLichTuan where NHANVIEN.maNV=ChiaLichTuan.maNV", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool insertLuong(string manv, string luong)
        {
            SqlCommand cmd = new SqlCommand("update  NHANVIEN set luong= @lg where maNV=@makh"
              , mydb.getConnection);
            cmd.Parameters.Add("@makh", SqlDbType.NChar).Value = manv;
            cmd.Parameters.Add("@lg", SqlDbType.NChar).Value = luong;
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
        public DataTable getCa(string ca)
        {
            SqlCommand cmd = new SqlCommand("select * from Chiaca where ca=@ca ", mydb.getConnection);
            cmd.Parameters.Add("@ca", SqlDbType.NChar).Value = ca;
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }
        public bool insertLich(string manv, string thu2, string thu3, string thu4, string thu5, string thu6, string thu7)
        {
            SqlCommand cmd = new SqlCommand("insert into Chiaca(maNV,Thu2,Thu3,Thu4,Thu5,Thu6,Thu7 where maNV=@makh)" +
                "values (@makh,@type,@luong,@note,@mahd,@day,@month)", mydb.getConnection);
            cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = manv;
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = thu2;
            cmd.Parameters.Add("@luong", SqlDbType.VarChar).Value = thu3;
            cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = thu4;
            cmd.Parameters.Add("@mahd", SqlDbType.VarChar).Value = thu5;
            cmd.Parameters.Add("@day", SqlDbType.VarChar).Value = thu6;
            cmd.Parameters.Add("@month", SqlDbType.VarChar).Value = thu7;
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
        public bool insertLichNV(string manv)
        {
            SqlCommand cmd = new SqlCommand("insert into ChiaLichTuan(maNV)" + "values (@makh)", mydb.getConnection);
            cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = manv;
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
        public string LoaiNV(string manv)
        {
            SqlCommand cmd = new SqlCommand("select NHANVIEN.type from NHANVIEN where maNV=@nv", mydb.getConnection);
            cmd.Parameters.Add("@nv", SqlDbType.VarChar).Value = manv;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string type = dt.Rows[0][0].ToString();
            return type;
        }
        public bool insertLich(string manv, string thu)
        {

            string query = "";

            if (thu == "Sang 2" || thu == "Chieu 2" || thu == "Toi 2")
            {
                query = "update ChiaLichTuan set Thu2 = @Thu  where maNV=@makh";

            }
            else if (thu == "Sang 3" || thu == "Chieu 3" || thu == "Toi 3")
            {
                query = "update ChiaLichTuan set Thu3 = @Thu  where maNV=@makh";
            }
            else if (thu == "Sang 4" || thu == "Chieu 4" || thu == "Toi 4")
            {
                query = "update ChiaLichTuan set Thu4 = @Thu  where maNV=@makh";
            }
            else if (thu == "Sang 5" || thu == "Chieu 5" || thu == "Toi 5")
            {
                query = "update ChiaLichTuan set Thu5 = @Thu  where maNV=@makh";
            }
            else if (thu == "Sang 6" || thu == "Chieu 6" || thu == "Toi 6")
            {
                query = "update ChiaLichTuan set Thu6 = @Thu  where maNV=@makh";
            }
            else if (thu == "Sang 7" || thu == "Chieu 7" || thu == "Toi 7")
            {
                query = "update ChiaLichTuan set Thu7 = @Thu  where maNV=@makh";
            }

            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            cmd.Parameters.Add("@Thu", SqlDbType.VarChar).Value = thu;
            cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = manv;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public DataTable getNVprofile(string manv)
        {
            SqlCommand cmd = new SqlCommand("select *from NhanVien where manv=@ma", mydb.getConnection);
            cmd.Parameters.Add("@ma", SqlDbType.NChar).Value = manv;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getLuongNV()
        {
            SqlCommand cmd = new SqlCommand("select ChiaLichTuan.maNV,Thu2,Thu3,Thu4,Thu5,Thu6,Thu7,NHANVIEN.luong from ChiaLichTuan,NHANVIEN where ChiaLichTuan.maNV=NHANVIEN.maNV", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}