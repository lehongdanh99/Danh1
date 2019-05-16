using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuanLiXe.Class
{
    class Contract
    {
        MY_DB mydb = new MY_DB();
        public bool insertCon(string maHD,string makh, string thoihan,string loaixe,int soluong
            ,DateTime ngaybatdau,DateTime ngaykethuc,string tien, string note)
        {
            SqlCommand cmd = new SqlCommand("insert into HopDong(Mahd,MaKH,ThoiHan,LoaiXe,SoLuong,NgayBatDau,NgayKetThuc,Tien,note)" +
                "values(@mahd,@makh,@thoihan,@loaixe,@soluong,@ngaybd,@ngaykt,@tien,@note)", mydb.getConnection);
            cmd.Parameters.Add("@mahd", SqlDbType.VarChar).Value = maHD;
            cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = makh;
            cmd.Parameters.Add("@thoihan", SqlDbType.VarChar).Value = thoihan;
            cmd.Parameters.Add("@loaixe", SqlDbType.VarChar).Value = loaixe;
            cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
            cmd.Parameters.Add("@ngaybd", SqlDbType.DateTime).Value = ngaybatdau;
            cmd.Parameters.Add("@ngaykt", SqlDbType.DateTime).Value = ngaykethuc;
            cmd.Parameters.Add("@tien", SqlDbType.VarChar).Value = tien;
            cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = note;
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
        public bool updateCon(string maHD, string makh, string thoihan, string loaixe, int soluong
          , DateTime ngaybatdau, DateTime ngaykethuc, string tien, string note)
        {
            SqlCommand cmd = new SqlCommand("update HopDong set MaKH=@makh,ThoiHan=@thoihan" +
                ",LoaiXe=@loaixe,SoLuong=@soluong,NgayBatDau=@ngaybd,NgayKetThuc=@ngaykt,Tien=@tien,note=@note where Mahd=@mahd)", mydb.getConnection);
                
            cmd.Parameters.Add("@mahd", SqlDbType.VarChar).Value = maHD;
            cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = makh;
            cmd.Parameters.Add("@thoihan", SqlDbType.VarChar).Value = thoihan;
            cmd.Parameters.Add("@loaixe", SqlDbType.VarChar).Value = loaixe;
            cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
            cmd.Parameters.Add("@ngaybd", SqlDbType.DateTime).Value = ngaybatdau;
            cmd.Parameters.Add("@ngaykt", SqlDbType.DateTime).Value = ngaykethuc;
            cmd.Parameters.Add("@tien", SqlDbType.VarChar).Value = tien;
            cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = note;
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
        public DataTable getAllContract()
        {
            SqlCommand cmd = new SqlCommand("select * from HopDong", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public DataTable getContractbyID(string maHD)
        {
            SqlCommand cmd = new SqlCommand("select * from HopDong where mahd = @mahd", mydb.getConnection);
            cmd.Parameters.Add("@mahd", SqlDbType.VarChar).Value = maHD;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}
