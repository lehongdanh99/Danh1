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
    class KhachHang
    {
        MY_DB mydb = new MY_DB();

        public DataTable getPhiGuiXe()
        {
            SqlCommand cmd = new SqlCommand("select * from GIAGUIXE", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }
        //public bool updatePhiGuiXe(string xedap, string xemay, string oto)
        public bool updateBaiXe(string num, string vitri)
        {
            SqlCommand cmd = new SqlCommand("update BAIXE set khuA=@num where vitriXe=@vitri ", mydb.getConnection);
            cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = num;

            cmd.Parameters.Add("@vitri", SqlDbType.VarChar).Value = vitri;
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
        public bool updateBaiXe2(string num, string vitri)
        {
            SqlCommand cmd = new SqlCommand("update BAIXE set khuB=@num where vitriXe=@vitri ", mydb.getConnection);
            cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = num;

            cmd.Parameters.Add("@vitri", SqlDbType.VarChar).Value = vitri;
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
        public bool updateBaiXe3(string num, string vitri)
        {
            SqlCommand cmd = new SqlCommand("update BAIXE set khuC=@num where vitriXe=@vitri ", mydb.getConnection);
            cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = num;

            cmd.Parameters.Add("@vitri", SqlDbType.VarChar).Value = vitri;
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
        public bool updateBaiXe4(string num, string vitri)
        {
            SqlCommand cmd = new SqlCommand("update BAIXE set khuD=@num where vitriXe=@vitri ", mydb.getConnection);
            cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = num;

            cmd.Parameters.Add("@vitri", SqlDbType.VarChar).Value = vitri;
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
        public bool updateBaiXe5(string num, string vitri)
        {
            SqlCommand cmd = new SqlCommand("update BAIXE set khuE=@num where vitriXe=@vitri ", mydb.getConnection);
            cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = num;

            cmd.Parameters.Add("@vitri", SqlDbType.VarChar).Value = vitri;
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
        public bool updateBaiXe6(string num, string vitri)
        {
            SqlCommand cmd = new SqlCommand("update BAIXE set khuF=@num where vitriXe=@vitri ", mydb.getConnection);
            cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = num;

            cmd.Parameters.Add("@vitri", SqlDbType.VarChar).Value = vitri;
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
        public bool updateBaiXe7(string num, string vitri)
        {
            SqlCommand cmd = new SqlCommand("update BAIXE set khuG=@num where vitriXe=@vitri ", mydb.getConnection);
            cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = num;

            cmd.Parameters.Add("@vitri", SqlDbType.VarChar).Value = vitri;
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
        public bool updateBaiXe8(string num, string vitri)
        {
            SqlCommand cmd = new SqlCommand("update BAIXE set khuH=@num where vitriXe=@vitri ", mydb.getConnection);
            cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = num;

            cmd.Parameters.Add("@vitri", SqlDbType.VarChar).Value = vitri;
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
        public bool updateBaiXe9(string num, string vitri)
        {
            SqlCommand cmd = new SqlCommand("update BAIXE set khuK=@num where vitriXe=@vitri ", mydb.getConnection);
            cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = num;

            cmd.Parameters.Add("@vitri", SqlDbType.VarChar).Value = vitri;
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
        //Them Khach Hang,cần bổ sung biến
        public bool insertCus(string vitri, string loaixe, MemoryStream anhbienso, MemoryStream anhxe, DateTime ngaygui, TimeSpan giogui, string yeucau)// Cần thêm các biến

        {
            SqlCommand cmd = new SqlCommand("insert into QUANLIXERAVAO (vitri, loaixe, bienso, ava, ngayguixe, gioguixe, timeyeucau)" +
                "values(@vitri, @loaixe, @pic, @pic1, @ngaygui, @giogui, @yeucau)", mydb.getConnection); // Cần biến kết nối data base
            cmd.Parameters.Add("@vitri", SqlDbType.VarChar).Value = vitri;
            cmd.Parameters.Add("@loaixe", SqlDbType.NVarChar).Value = loaixe;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = anhbienso.ToArray();
            cmd.Parameters.Add("@pic1", SqlDbType.Image).Value = anhxe.ToArray();
            cmd.Parameters.Add("@ngaygui", SqlDbType.DateTime).Value = ngaygui;
            cmd.Parameters.Add("@giogui", SqlDbType.Time).Value = giogui;
            cmd.Parameters.Add("@yeucau", SqlDbType.VarChar).Value = yeucau;
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
        //Lấy thông tin, cần bổ sung biến
        public DataTable getCus()
        {
            SqlCommand cmd = new SqlCommand("select * from BAIXE", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            mydb.closeConnection();
            return table;
        }
        public DataTable search(SqlCommand cmd)
        {
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        }
        public DataTable getQLXRV()
        {
            SqlCommand cmd = new SqlCommand("select * from QUANLIXERAVAO", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }
        //Xóa Thông Tin, cần bổ sung biến // **
        public bool deleteCus(string vitri)
        {
            SqlCommand cmd = new SqlCommand("delete from QUANLIXERAVAO where vitri = @vitri", mydb.getConnection); //**
            cmd.Parameters.Add("@vitri", SqlDbType.VarChar).Value = vitri;
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
        public bool updateCus(string vitri, string loaixe, MemoryStream anhbienso, MemoryStream anhxe, DateTime ngaygui, TimeSpan giogui, string yeucau)
        {
            SqlCommand cmd = new SqlCommand("update QUANLIXERAVAO set vitri=@vitri, loaixe=@loaixe, bienso=@anhbienso, ava=@anhxe, ngayguixe=@ngaygui, gioguixe=@giogui, timeyeucau=@yeucau ", mydb.getConnection);
            cmd.Parameters.Add("@vitri", SqlDbType.VarChar).Value = vitri;
            cmd.Parameters.Add("@loaixe", SqlDbType.VarChar).Value = loaixe;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = anhbienso.ToArray();
            cmd.Parameters.Add("@pic1", SqlDbType.Image).Value = anhxe.ToArray();
            cmd.Parameters.Add("@ngaygui", SqlDbType.DateTime).Value = ngaygui;
            cmd.Parameters.Add("@giogui", SqlDbType.Time).Value = giogui;
            cmd.Parameters.Add("@yeucau", SqlDbType.VarChar).Value = yeucau;
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
        public bool updateLayXe(string vitri, DateTime ngaylay, TimeSpan giolay, string tongtime)
        {
            SqlCommand cmd = new SqlCommand("update QUANLIXERAVAO set ngaylayxe=@ngay, giolayxe=@gio, tongtime=@tong where vitri=@vt ", mydb.getConnection);
            cmd.Parameters.Add("@ngay", SqlDbType.DateTime).Value = ngaylay;
            cmd.Parameters.Add("@gio", SqlDbType.Time).Value = giolay;
            cmd.Parameters.Add("@tong", SqlDbType.NVarChar).Value = tongtime;
            cmd.Parameters.Add("@vt", SqlDbType.VarChar).Value = vitri;
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

        public bool updateGiaoDienChinh(string vitri, string loaixe, MemoryStream ava, MemoryStream bienso, DateTime ngaygui, TimeSpan giogui, string yeucau)
        {
            SqlCommand cmd = new SqlCommand("update QUANLIXERAVAO set loaixe=@loaixe, ava=@ava, bienso=@bienso, ngayguixe=@ngaygui, gioguixe=@giogui, timeyeucau=@yeucau where vitri=@vt ", mydb.getConnection);
            cmd.Parameters.Add("@loaixe", SqlDbType.NVarChar).Value = loaixe;
            cmd.Parameters.Add("@ava", SqlDbType.Image).Value = ava.ToArray();
            cmd.Parameters.Add("@bienso", SqlDbType.Image).Value = bienso.ToArray();
            cmd.Parameters.Add("@ngaygui", SqlDbType.Date).Value = ngaygui;
            cmd.Parameters.Add("@giogui", SqlDbType.Time).Value = giogui;
            cmd.Parameters.Add("@yeucau", SqlDbType.NChar).Value = yeucau;
            cmd.Parameters.Add("@vt", SqlDbType.VarChar).Value = vitri;
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
        
        //Lấy Thông Tin Khách Hàng để Load Lên MenuStrip
        public DataTable getThongTinKH(string username)
        {
            SqlCommand cmd = new SqlCommand("select *from KHACHHANG where maKH = @makh",mydb.getConnection);
            cmd.Parameters.Add("@makh", SqlDbType.NChar).Value = Global.username;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}