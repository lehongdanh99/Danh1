using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuanLiXe
{
    class Contract
    {
        MY_DB mydb = new MY_DB();
        public bool insertCon(string maHD, string makh, string thoihan
            , DateTime ngaybatdau, string tien, string note, string type, string userid)
        {
            SqlCommand cmd = new SqlCommand("insert into HopDong(MaHD,MaKH,ThoiHan,NgayBatDau,Tien,note,Type,userid) "
                + "values(@mahd,@makh,@thoihan,@ngaybd,@tien,@note,@type,@uid)", mydb.getConnection);
            cmd.Parameters.Add("@mahd", SqlDbType.VarChar).Value = maHD;
            cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = makh;
            cmd.Parameters.Add("@thoihan", SqlDbType.VarChar).Value = thoihan;
            cmd.Parameters.Add("@ngaybd", SqlDbType.DateTime).Value = ngaybatdau;
            cmd.Parameters.Add("@tien", SqlDbType.VarChar).Value = tien;
            cmd.Parameters.Add("@note", SqlDbType.NVarChar).Value = note;
            cmd.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
            cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = userid;

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
        public bool updateCon(string maHD, string makh, string thoihan
          , DateTime ngaybatdau, DateTime ngaykethuc, string tien, string note, string type, string userid)
        {
            SqlCommand cmd = new SqlCommand("update HopDong set MaKH=@makh,ThoiHan=@thoihan" +
                ",NgayBatDau=@ngaybd,NgayKetThuc=@ngaykt,Tien=@tien,note=@note,Type=@type,userid=@uid where Mahd=@mahd)", mydb.getConnection);

            cmd.Parameters.Add("@mahd", SqlDbType.VarChar).Value = maHD;
            cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = makh;
            cmd.Parameters.Add("@thoihan", SqlDbType.VarChar).Value = thoihan;
            cmd.Parameters.Add("@ngaybd", SqlDbType.DateTime).Value = ngaybatdau;
            cmd.Parameters.Add("@ngaykt", SqlDbType.DateTime).Value = ngaykethuc;
            cmd.Parameters.Add("@tien", SqlDbType.VarChar).Value = tien;
            cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = note;
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = userid;

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
        //Lấy dữ liệu của hợp đồng
        public DataTable getAllContract()
        {
            SqlCommand cmd = new SqlCommand("select * from HopDong", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        //Lấy dữ liệu từ DataTable theo Mã Hợp Đồng
        public DataTable getContractbyID(string maHD)
        {
            SqlCommand cmd = new SqlCommand("select * from HopDong where MaHD = @mahd", mydb.getConnection);
            cmd.Parameters.Add("@mahd", SqlDbType.VarChar).Value = maHD;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        //Insert vào Hợp Đồng THuê
        public bool insertThue(string mahd, string bienso, string theloai)
        {
            SqlCommand cmd = new SqlCommand("insert into HDT(MaHD,BienSo,TheLoai)"
                + "values (@mahd,@bienso,@theloai)", mydb.getConnection);
            cmd.Parameters.Add("@mahd", SqlDbType.VarChar).Value = mahd;
            cmd.Parameters.Add("@bienso", SqlDbType.VarChar).Value = bienso;
            cmd.Parameters.Add("@theloai", SqlDbType.NVarChar).Value = theloai;
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
        public bool updateThue(string mahd, string bienso, string theloai)
        {
            SqlCommand cmd = new SqlCommand("update" +
                " HDT set MaHD=@mahd,BienSo=@bienso,TheLoai=@theloai ", mydb.getConnection);
            cmd.Parameters.Add("@mahd", SqlDbType.VarChar).Value = mahd;
            cmd.Parameters.Add("@bienso", SqlDbType.VarChar).Value = bienso;
            cmd.Parameters.Add("@theloai", SqlDbType.NVarChar).Value = theloai;
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
        public DataTable getBienSoThue(string mahd)
        {
            SqlCommand cmd = new SqlCommand("select * from HDT where MaHD = @mahd", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Insert vào Hợp Đồng Gửi
        public bool insertGui(string mahd, string bienso, string theloai)
        {
            SqlCommand cmd = new SqlCommand("insert into HDCT(MaHD,BienSo,TheLoai)"
                + "values (@mahd,@bienso,@theloai)", mydb.getConnection);
            cmd.Parameters.Add("@mahd", SqlDbType.VarChar).Value = mahd;
            cmd.Parameters.Add("@bienso", SqlDbType.VarChar).Value = bienso;
            cmd.Parameters.Add("@theloai", SqlDbType.VarChar).Value = theloai;
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
        public bool updateGui(string mahd, string bienso, string theloai)
        {
            SqlCommand cmd = new SqlCommand("update" +
                " HDCT set MaHD=@mahd,BienSo=@bienso,TheLoai=@theloai ", mydb.getConnection);
            cmd.Parameters.Add("@mahd", SqlDbType.VarChar).Value = mahd;
            cmd.Parameters.Add("@bienso", SqlDbType.VarChar).Value = bienso;
            cmd.Parameters.Add("@theloai", SqlDbType.VarChar).Value = theloai;
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
        public DataTable getBienSoGui(string mahd)
        {
            SqlCommand cmd = new SqlCommand("select * from HDCT where MaHD = @mahd", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Lay the loai xe
        public DataTable getLoaiXe()
        {
            SqlCommand cmd = new SqlCommand("select * from LoaiXeHOPDONG", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
