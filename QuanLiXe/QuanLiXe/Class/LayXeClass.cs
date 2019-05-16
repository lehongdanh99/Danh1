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
    class LayXeClass
    {
        MY_DB mydb = new MY_DB();
        public DataTable getLayXe()
        {
            SqlCommand cmd = new SqlCommand("select * from QLLAYXE", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            mydb.closeConnection();
            return table;
        }
        public bool deleteCus(string vitri)
        {
            SqlCommand cmd = new SqlCommand("delete from QLLAYXE where vitri = @vitri", mydb.getConnection); //**
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
        public bool insertXe(string vitri, string loaixe, MemoryStream anhbienso, MemoryStream anhnguoigui, DateTime ngaygui, 
            TimeSpan giogui, DateTime ngaylay, TimeSpan giolay, string tongtime, string yeucau, int tongtien, int userid)
        {
            SqlCommand cmd = new SqlCommand("insert into QLLAYXE (vitri, loaixe, bienso, ava, ngayguixe, gioguixe, ngaylayxe, giolayxe, tongtime, timeyeucau, tongtien, userid)" +
                "values(@vitri, @loaixe, @pic, @pic1, @ngaygui, @giogui, @ngaylay, @giolay, @tongtime, @yeucau, @tien, @userid)", mydb.getConnection); 
            cmd.Parameters.Add("@vitri", SqlDbType.VarChar).Value = vitri;
            cmd.Parameters.Add("@loaixe", SqlDbType.NVarChar).Value = loaixe;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = anhbienso.ToArray();
            cmd.Parameters.Add("@pic1", SqlDbType.Image).Value = anhnguoigui.ToArray();
            cmd.Parameters.Add("@ngaygui", SqlDbType.DateTime).Value = ngaygui;
            cmd.Parameters.Add("@giogui", SqlDbType.Time).Value = giogui;
            cmd.Parameters.Add("@ngaylay", SqlDbType.DateTime).Value = ngaylay;
            cmd.Parameters.Add("@giolay", SqlDbType.Time).Value = giolay;
            cmd.Parameters.Add("@tongtime", SqlDbType.NVarChar).Value = tongtime;
            cmd.Parameters.Add("@yeucau", SqlDbType.VarChar).Value = yeucau;
            cmd.Parameters.Add("@tien", SqlDbType.Int).Value = tongtien;
            cmd.Parameters.Add("@userid", SqlDbType.Int).Value = userid;
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
        public DataTable SearchXe(string vitri)
        {
            SqlCommand cmd = new SqlCommand("select * from QUANLIXERAVAO where vitri=@vitri", mydb.getConnection);
            cmd.Parameters.Add("@vitri", SqlDbType.VarChar).Value = vitri;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            mydb.closeConnection();
            return table;
        }
    }
}