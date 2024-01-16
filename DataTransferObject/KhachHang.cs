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

    public class KhachHangVIP: KhachHang
    {
        public int DiemThuong;
        public KhachHangVIP() : base()
        {
            DiemThuong = 0;
        }
        public KhachHangVIP(int MaKhachHang, string TenKhachHang, string DienThoai, 
            string DiaChi, string Email, int SoTienNo, int DiemThuong) : base(MaKhachHang, TenKhachHang, DienThoai, DiaChi, Email, SoTienNo)
        {
            this.DiemThuong = DiemThuong;
        }
    }

    public class KhachHangDoanhNghiep : KhachHang
    {
        public double ChietKhau;
        public string TenCongTy;
        public string MaSoThue;

        public KhachHangDoanhNghiep() : base()
        {
            ChietKhau = 0;
            TenCongTy = "";
            MaSoThue = "";
        }
        public KhachHangDoanhNghiep(int MaKhachHang, string TenKhachHang, string DienThoai,
            string DiaChi, string Email, int SoTienNo, double ChietKhau, string TenCongTy, string MaSoThue) : base(MaKhachHang, TenKhachHang, DienThoai, DiaChi, Email, SoTienNo)
        {
            this.ChietKhau = ChietKhau;
            this.TenCongTy = TenCongTy;
            this.MaSoThue = MaSoThue;
        }
    }
}
