using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CNPM
{
    public class KhachHang
    {
        public int MaKhachHang, SoTienNo;
        public string TenKhachHang, DienThoai, DiaChi, Email;

        public KhachHang()
        {
            MaKhachHang = 0;
            SoTienNo = 0;
            TenKhachHang = "";
            DienThoai = "";
            DiaChi = "";
            Email = "";
        }
        public KhachHang(int MaKhachHang, string TenKhachHang, string DienThoai, string DiaChi, string Email, int SoTienNo)
        {
            this.MaKhachHang = MaKhachHang;
            this.TenKhachHang = TenKhachHang;
            this.DienThoai = DienThoai;
            this.Email = Email;
            this.DiaChi = DiaChi;
            this.SoTienNo = SoTienNo;
        }
    }
}
