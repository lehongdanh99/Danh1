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
    class ThueXeClass
    {
        MY_DB mydb = new MY_DB();
        public DataTable getThueXe()
        {
            SqlCommand cmd = new SqlCommand("select THONGTINXE.Cavet, BienSo, SoMay, AnhXe, Mau, HangXe, SoKM, LoaiXe, thoihan, THONGTINXE.tinhtrang from THUEXE, THONGTINXE WHERE THUEXE.Cavet = THONGTINXE.Cavet", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            mydb.closeConnection();
            return table;
        }

        public bool updateHoaDonThueXe(string cavet, DateTime ngaybatdau, DateTime ngayketthuc, string thoihan, string tien, string tinhtrang)
        {
            SqlCommand cmd = new SqlCommand("update THUEXE set ngaybd=@bd,ngaykt=@kt,thoihan=@th,tien=@tien,tinhtrang=@tt where Cavet=@cv", mydb.getConnection);
            cmd.Parameters.Add("@cv", SqlDbType.NChar).Value = cavet;
            cmd.Parameters.Add("@bd", SqlDbType.Date).Value = ngaybatdau;
            cmd.Parameters.Add("@kt", SqlDbType.Date).Value = ngayketthuc;
            cmd.Parameters.Add("@th", SqlDbType.NChar).Value = thoihan;
            cmd.Parameters.Add("@tien", SqlDbType.NChar).Value = tien;
            cmd.Parameters.Add("@tt", SqlDbType.NVarChar).Value = tinhtrang;
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
        public bool updateTinhTrangThueXe(string cavet, string tinhtrang)
        {
            SqlCommand cmd = new SqlCommand("update ThueXe set tinhtrang=@tt where Cavet=@cv", mydb.getConnection);
            cmd.Parameters.Add("@cv", SqlDbType.NVarChar).Value = cavet;
            cmd.Parameters.Add("@tt", SqlDbType.NVarChar).Value = tinhtrang;
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
        public bool updateTinhTrangThongTinXe(string cavet, string tinhtrang)
        {
            SqlCommand cmd = new SqlCommand("update THONGTINXE set tinhtrang=@tt where Cavet=@cv", mydb.getConnection);
            cmd.Parameters.Add("@cv", SqlDbType.NVarChar).Value = cavet;
            cmd.Parameters.Add("@tt", SqlDbType.NVarChar).Value = tinhtrang;
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
        public bool insertThueXe(string cavet, DateTime ngaybd, DateTime ngaykt, string thoihan, string tien, string tinhtrang, string makh)
        {
            SqlCommand cmd = new SqlCommand("insert into THUEXE (cavet, ngaybd, ngaykt, thoihan, tien, tinhtrang, makh)" +
                "values(@cavet, @ngaybd, @ngaykt, @thoihan, @tien, @tt, @makh)", mydb.getConnection);
            cmd.Parameters.Add("@cavet", SqlDbType.VarChar).Value = cavet;
            cmd.Parameters.Add("@ngaybd", SqlDbType.Date).Value = ngaybd;
            cmd.Parameters.Add("@ngaykt", SqlDbType.Date).Value = ngaykt;
            cmd.Parameters.Add("@thoihan", SqlDbType.NVarChar).Value = thoihan;
            cmd.Parameters.Add("@tien", SqlDbType.VarChar).Value = tien;
            cmd.Parameters.Add("@tt", SqlDbType.NVarChar).Value = tinhtrang;
            cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = makh;
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
        public DataTable getHoaDonThueXe()
        {
            SqlCommand cmd = new SqlCommand("select THONGTINXE.Cavet, BienSo, SoMay, AnhXe, Mau, HangXe, SoKM, LoaiXe, ngaybd, ngaykt, thoihan, tien, THUEXE.tinhtrang from THUEXE, THONGTINXE WHERE THUEXE.Cavet = THONGTINXE.Cavet", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            mydb.closeConnection();
            return table;
        }
        public DataTable getTongTien()
        {
            SqlCommand cmd = new SqlCommand("select sum(convert (int,tien))as tongtien from THUEXE where tinhtrang=N'Chờ duyệt'", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            mydb.closeConnection();
            return table;
        }
        public bool deleteHoaDon(string cavet)
        {
            SqlCommand cmd = new SqlCommand("delete from THUEXE where cavet = @cv", mydb.getConnection);
            cmd.Parameters.Add("@cv", SqlDbType.VarChar).Value = cavet;
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
    }
}