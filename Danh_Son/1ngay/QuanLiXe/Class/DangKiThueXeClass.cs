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
    class DangKiThueXeClass
    {
        MY_DB mydb = new MY_DB();
        public DataTable getLoaixe()
        {
            SqlCommand cmd = new SqlCommand("select * from loaixehopdong", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            mydb.closeConnection();
            return table;
        }
        public bool insertThongTinXe(string cavet, MemoryStream bienso, MemoryStream somay, MemoryStream anhxe, string mausac, string hangxe, string sokm, string dichvu, string loaixe, string makh)
        {
            SqlCommand cmd = new SqlCommand("insert into THONGTINXE (cavet, bienso, somay, anhxe, mau, hangxe, sokm, dichvu, loaixe, makh)" +
                "values(@cavet, @bienso, @somay, @anhxe, @mausac, @hangxe, @sokm, @dichvu, @loaixe, @makh)", mydb.getConnection);
            cmd.Parameters.Add("@cavet", SqlDbType.VarChar).Value = cavet;
            cmd.Parameters.Add("@bienso", SqlDbType.Image).Value = bienso.ToArray();
            cmd.Parameters.Add("@somay", SqlDbType.Image).Value = somay.ToArray();
            cmd.Parameters.Add("@anhxe", SqlDbType.Image).Value = anhxe.ToArray();
            cmd.Parameters.Add("@mausac", SqlDbType.NVarChar).Value = mausac;
            cmd.Parameters.Add("@hangxe", SqlDbType.NVarChar).Value = hangxe;
            cmd.Parameters.Add("@sokm", SqlDbType.VarChar).Value = sokm;
            cmd.Parameters.Add("@dichvu", SqlDbType.NVarChar).Value = dichvu;
            cmd.Parameters.Add("@loaixe", SqlDbType.NVarChar).Value = loaixe;
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
        public bool insertDichVuDK(string cavet, DateTime ngaybd, DateTime ngaykt, string thoihan, string tien, string tinhtrang)
        {
            SqlCommand cmd = new SqlCommand("insert into DICHVUDANGKY (cavet, ngaybd, ngaykt, thoihan, tien, tinhtrang)" +
                "values(@cavet, @ngaybd, @ngaykt, @thoihan, @tien, @tt)", mydb.getConnection);
            cmd.Parameters.Add("@cavet", SqlDbType.VarChar).Value = cavet;
            cmd.Parameters.Add("@ngaybd", SqlDbType.Date).Value = ngaybd;
            cmd.Parameters.Add("@ngaykt", SqlDbType.Date).Value = ngaybd;
            cmd.Parameters.Add("@thoihan", SqlDbType.NVarChar).Value = thoihan;
            cmd.Parameters.Add("@tien", SqlDbType.VarChar).Value = tien;
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
    }
}