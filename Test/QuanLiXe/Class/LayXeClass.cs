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
        public int phiGuiXe(string vitri, string loaixe, string yeucau, int ngay, int gio, int phut)
        {
            SqlCommand command = new SqlCommand("select * from GIAGUIXE", mydb.getConnection);
            SqlDataAdapter dagia = new SqlDataAdapter(command);
            DataTable dtgia = new DataTable();
            dagia.Fill(dtgia);
            //mydb.closeConnection();
            //SqlCommand cmd = new SqlCommand("select * from QUANLIXERAVAO where vitri = @vitri", mydb.getConnection);
            //cmd.Parameters.Add("@vitri", SqlDbType.NChar).Value = vitri;
            //SqlDataAdapter da = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            int tongphi = 0;
            switch (loaixe.Trim())
            {
                #region case "Ô tô"
                case "Ô tô":
                    if (yeucau == "Hour")
                    {
                        if (ngay != 0)
                        {
                            if (ngay < 7)
                            {
                                tongphi = Convert.ToInt32(dtgia.Rows[2][2].ToString()) * ngay * 2;
                            }
                            else if (ngay >= 7 && ngay < 30)
                            {
                                tongphi = Convert.ToInt32(dtgia.Rows[2][4].ToString()) * 2;
                            }
                            else
                            {
                                tongphi = Convert.ToInt32(dtgia.Rows[2][4].ToString()) * 12;
                            }
                        }
                        else
                        {
                            if (gio == 0)
                            {
                                tongphi = Convert.ToInt32(dtgia.Rows[2][1].ToString());
                            }
                            else 
                            {
                                if (phut < 30)
                                {
                                    tongphi = Convert.ToInt32(dtgia.Rows[2][1].ToString()) * gio;
                                }
                                else
                                {
                                    gio++;
                                    tongphi = Convert.ToInt32(dtgia.Rows[2][1].ToString()) * gio;
                                }
                            }
                        }
                    }
                    else if (yeucau == "Day")
                    {
                        if (ngay == 0)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[2][2].ToString());
                        }
                        else if (ngay > 0 && ngay < 7)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[2][3].ToString());
                        }
                        else if (ngay >= 7 && ngay < 30)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[2][4].ToString());
                        }
                        else
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[2][4].ToString()) * 12;
                        }
                    }
                    else if (yeucau == "Week")
                    {
                        if (ngay < 7)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[2][3].ToString());
                        }
                        else if (ngay > 7 && ngay < 10)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[2][3].ToString()) * 2;
                        }
                        else if (ngay > 10 && ngay < 30)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[2][4].ToString());
                        }
                        else
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[2][4].ToString()) * 12;
                        }
                    }
                    else
                    {
                        if (ngay <= 30)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[2][4].ToString());
                        }
                        else if (ngay > 30 && ngay < 30 * 6)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[2][4].ToString()) * 6;
                        }
                        else
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[2][4].ToString()) * 12;
                        }
                    }
                    break;
                #endregion
                #region case "Xe máy"
                case "Xe máy":
                    if (yeucau == "Hour")
                    {
                        if (ngay != 0)
                        {
                            if (ngay < 7)
                            {
                                tongphi = Convert.ToInt32(dtgia.Rows[1][2].ToString()) * ngay * 2;
                            }
                            else if (ngay >= 7 && ngay < 30)
                            {
                                tongphi = Convert.ToInt32(dtgia.Rows[1][4].ToString()) * 2;
                            }
                            else
                            {
                                tongphi = Convert.ToInt32(dtgia.Rows[1][4].ToString()) * 12;
                            }
                        }
                        else
                        {
                            if (gio == 0)
                            {
                                tongphi = Convert.ToInt32(dtgia.Rows[1][1].ToString());
                            }
                            else
                            {
                                if (phut < 30)
                                {
                                    tongphi = Convert.ToInt32(dtgia.Rows[1][1].ToString()) * gio;
                                }
                                else
                                {
                                    gio++;
                                    tongphi = Convert.ToInt32(dtgia.Rows[1][1].ToString()) * gio;
                                }
                            }
                        }
                    }
                    else if (yeucau == "Day")
                    {
                        if (ngay == 0)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[1][2].ToString());
                        }
                        else if (ngay > 0 && ngay < 7)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[1][3].ToString());
                        }
                        else if (ngay >= 7 && ngay < 30)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[1][4].ToString());
                        }
                        else
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[1][4].ToString()) * 12;
                        }
                    }
                    else if (yeucau == "Week")
                    {
                        if (ngay < 7)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[1][3].ToString());
                        }
                        else if (ngay > 7 && ngay < 10)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[1][3].ToString()) * 2;
                        }
                        else if (ngay > 10 && ngay < 30)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[1][4].ToString());
                        }
                        else
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[1][4].ToString()) * 12;
                        }
                    }
                    else
                    {
                        if (ngay <= 30)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[1][4].ToString());
                        }
                        else if (ngay > 30 && ngay < 30 * 6)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[1][4].ToString()) * 6;
                        }
                        else
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[1][4].ToString()) * 12;
                        }
                    }
                    break;
                #endregion
                #region case "Xe đạp"
                case "Xe đạp":
                    if (yeucau == "Hour")
                    {
                        if (ngay != 0)
                        {
                            if (ngay < 7)
                            {
                                tongphi = Convert.ToInt32(dtgia.Rows[0][2].ToString()) * ngay * 2;
                            }
                            else if (ngay >= 7 && ngay < 30)
                            {
                                tongphi = Convert.ToInt32(dtgia.Rows[0][4].ToString()) * 2;
                            }
                            else
                            {
                                tongphi = Convert.ToInt32(dtgia.Rows[0][4].ToString()) * 12;
                            }
                        }
                        else
                        {
                            if (gio == 0)
                            {
                                tongphi = Convert.ToInt32(dtgia.Rows[0][1].ToString());
                            }
                            else
                            {
                                if (phut < 30)
                                {
                                    tongphi = Convert.ToInt32(dtgia.Rows[0][1].ToString()) * gio;
                                }
                                else
                                {
                                    gio++;
                                    tongphi = Convert.ToInt32(dtgia.Rows[0][1].ToString()) * gio;
                                }
                            }
                        }
                    }
                    else if (yeucau == "Day")
                    {
                        if (ngay == 0)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[0][2].ToString());
                        }
                        else if (ngay > 0 && ngay < 7)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[0][3].ToString());
                        }
                        else if (ngay >= 7 && ngay < 30)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[0][4].ToString());
                        }
                        else
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[0][4].ToString()) * 12;
                        }
                    }
                    else if (yeucau == "Week")
                    {
                        if (ngay < 7)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[0][3].ToString());
                        }
                        else if (ngay > 7 && ngay < 10)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[0][3].ToString()) * 2;
                        }
                        else if (ngay > 10 && ngay < 30)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[0][4].ToString());
                        }
                        else
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[0][4].ToString()) * 12;
                        }
                    }
                    else
                    {
                        if (ngay <= 30)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[0][4].ToString());
                        }
                        else if (ngay > 30 && ngay < 30 * 6)
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[0][4].ToString()) * 6;
                        }
                        else
                        {
                            tongphi = Convert.ToInt32(dtgia.Rows[0][4].ToString()) * 12;
                        }
                    }
                    break;
                    #endregion
            }
            return tongphi;
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