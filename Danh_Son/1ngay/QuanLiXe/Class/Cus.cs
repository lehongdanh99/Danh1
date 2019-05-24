﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace QuanLiXe
{
    class Cus
    {
        MY_DB mydb = new MY_DB();
        public bool insertCus(string MaKH, string fname, string lname, string gender, DateTime bdate
                   , string phone, string address, string cmnd, MemoryStream Ava)
        {
            SqlCommand cmd = new SqlCommand("insert into KHACHHANG(maKH,fName,lName,gender,birthday,phone,address,cmnd,ava)" +
                "values (@makh,@fname,@lname,@gender,@bdate,@phone,@add,@cmnd,@ava)", mydb.getConnection);
            cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = MaKH;
            cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@add", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = cmnd;
            cmd.Parameters.Add("@ava", SqlDbType.Image).Value = Ava.ToArray();

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
        public DataTable getAllCus(string makh)
        {
            SqlCommand cmd = new SqlCommand("select *from KhachHang", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool updateCus(string MaKH, string fname, string lname, DateTime bdate
            , string phone, string address, string cmnd, MemoryStream Ava)
        {
            SqlCommand cmd = new SqlCommand("update KhachHang set fName=@fname,lName=@lname,Birthday=@bdate" +
                ",Phone=@phone,Address=@add,Cmnd=@cmnd,Ava=@ava where MaKH=@makh)", mydb.getConnection);
            cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = MaKH;
            cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@add", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = cmnd;
            cmd.Parameters.Add("@ava", SqlDbType.Image).Value = Ava.ToArray();

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


        //Giai đoạn 2

        public DataTable getThongTinKH(string username)
        {
            SqlCommand cmd = new SqlCommand("select * from KHACHHANG where maKH = @makh", mydb.getConnection);
            cmd.Parameters.Add("@makh", SqlDbType.NChar).Value = Global.username;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool UpdateThongTinKhach(string user, string fname, string lname, string gender, DateTime birthday, string phone, string address, string cmnd, MemoryStream ava)
        {
            SqlCommand cmd = new SqlCommand("update KHACHHANG set fname=@fname,lName=@lname,gender=@gender,birthday=@birthday,phone=@phone,address=@address,cmnd=@cmnd,ava=@ava where makh=@user", mydb.getConnection);
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = Global.username;
            cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
            cmd.Parameters.Add("@birthday", SqlDbType.DateTime).Value = birthday;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = cmnd;
            cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@ava", SqlDbType.Image).Value = ava.ToArray();
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