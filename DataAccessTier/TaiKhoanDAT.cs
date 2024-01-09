using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data;
using System.Text;
using CNPM.DataTransferObject;

namespace CNPM.DataAccessTier
{
    class TaiKhoanDAT
    {
        public TaiKhoanDAT() { }

        public TaiKhoan GetTaiKhoan(string tenTaiKhoan)
        {
            DBConnection conn = DBConnection.Instance;
            conn.getConn().Open();
            TaiKhoan res = null;
            OleDbCommand cmd = new OleDbCommand("Select * from TAIKHOAN where TenTaiKhoan = ?", conn.getConn());
            cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
            OleDbDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                res = new TaiKhoan();
                res.TenTaiKhoan = rd["TenTaiKhoan"].ToString();
                res.MatKhau = rd["MatKhau"].ToString();
                rd.Close();
            }
            conn.getConn().Close();
            return res;
        }
    }
}
