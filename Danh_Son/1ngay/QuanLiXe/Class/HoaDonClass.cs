using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace QuanLiXe
{
    class HoaDonClass
    {
        MY_DB mydb = new MY_DB();
        public DataTable getHoaDon()
        {
            SqlCommand cmd = new SqlCommand("select THONGTINXE.Cavet, BienSo, SoMay, AnhXe, Mau, HangXe, SoKM, LoaiXe, MaKH, ngaybd, ngaykt, thoihan, tien, DICHVUDANGKY.tinhtrang from DICHVUDANGKY, THONGTINXE WHERE DICHVUDANGKY.Cavet = THONGTINXE.Cavet", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            mydb.closeConnection();
            return table;
        }
        public DataTable getTongTien()
        {
            SqlCommand cmd = new SqlCommand("select sum(convert (int,tien))as tongtien from DICHVUDANGKY where tinhtrang=N'Chờ duyệt'", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            mydb.closeConnection();
            return table;
        }
        public bool updateThongTinXe(string cavet,MemoryStream bienso, MemoryStream somay, MemoryStream anhxe, string mausac, string hangxe, string sokm,string loaixe)
        {
            SqlCommand cmd = new SqlCommand("update THONGTINXE set bienso=@bs,somay=@sm,anhxe=@ax,mau=@ms,hangxe=@hx,sokm=@km,loaixe=@lx where cavet=@cv", mydb.getConnection);
            cmd.Parameters.Add("@cv", SqlDbType.NChar).Value = cavet;
            cmd.Parameters.Add("@bs", SqlDbType.Image).Value = bienso.ToArray();
            cmd.Parameters.Add("@sm", SqlDbType.Image).Value = somay.ToArray();
            cmd.Parameters.Add("@ax", SqlDbType.Image).Value = anhxe.ToArray();
            cmd.Parameters.Add("@ms", SqlDbType.NVarChar).Value = mausac;
            cmd.Parameters.Add("@hx", SqlDbType.NVarChar).Value = hangxe;
            cmd.Parameters.Add("@km", SqlDbType.NChar).Value = sokm;
            cmd.Parameters.Add("@lx", SqlDbType.NVarChar).Value = loaixe;
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
        public bool updateDichVuDK(string cavet, DateTime ngaybatdau,DateTime ngayketthuc,string thoihan, string tien,string tinhtrang)
        {
            SqlCommand cmd = new SqlCommand("update DICHVUDANGKY set ngaybd=@bd,ngaykt=@kt,thoihan=@th,tien=@tien,tinhtrang=@tt where Cavet=@cv", mydb.getConnection);
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
        public bool deleteThongTinXe(string cavet)
        {
            SqlCommand cmd = new SqlCommand("delete from THONGTINXE where cavet = @cv", mydb.getConnection);
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
        public bool deleteDichVuDK(string cavet)
        {
            SqlCommand cmd = new SqlCommand("delete from DICHVUDANGKY where cavet = @cv", mydb.getConnection); 
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