using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.DesignPatterns
{
    interface IKhachHangBuilder
    {
        void reset();
        void SetMaKhachHang(int maKhachHang);
        void SetTenKhachHang(string tenKhachHang);
        void SetDienThoai(string dienThoai);
        void SetDiaChi(string diaChi);
        void SetEmail(string email);
        void SetSoTienNo(int soTienNo);
    }

    class KhachHangBuilder : IKhachHangBuilder
    {
        private KhachHang khachHang = new KhachHang();

        public void reset()
        {
            khachHang = new KhachHang();
        }

        public void SetMaKhachHang(int maKhachHang)
        {
            khachHang.MaKhachHang = maKhachHang;
        }

        public void SetTenKhachHang(string tenKhachHang)
        {
            khachHang.TenKhachHang = tenKhachHang;
        }

        public void SetDienThoai(string dienThoai)
        {
            khachHang.DienThoai = dienThoai;
        }

        public void SetEmail(string email)
        {
            khachHang.Email = email;
        }

        public void SetDiaChi(string diaChi)
        {
            khachHang.DiaChi = diaChi;
        }

        public void SetSoTienNo(int soTienNo)
        {
            khachHang.SoTienNo = soTienNo;
        }

        public KhachHang Build()
        {
            KhachHang result = this.khachHang;
            this.reset();
            return result;
        }
    }

    class KhachHangVIPBuilder : IKhachHangBuilder
    {
        private KhachHangVIP khachHang = new KhachHangVIP();

        public void reset()
        {
            khachHang = new KhachHangVIP();
        }

        public void SetMaKhachHang(int maKhachHang)
        {
            khachHang.MaKhachHang = maKhachHang;
        }

        public void SetTenKhachHang(string tenKhachHang)
        {
            khachHang.TenKhachHang = tenKhachHang;
        }

        public void SetDienThoai(string dienThoai)
        {
            khachHang.DienThoai = dienThoai;  
        }

        public void SetEmail(string email)
        {
            khachHang.Email = email;
        }

        public void SetDiaChi(string diaChi)
        {
            khachHang.DiaChi = diaChi;
        }

        public void SetSoTienNo(int soTienNo)
        {
            khachHang.SoTienNo = soTienNo;
        }

        public void SetDiemThuong(int DiemThuong)
        {
            khachHang.DiemThuong = DiemThuong;
        }

        public KhachHangVIP Build()
        {
            KhachHangVIP result = this.khachHang;
            this.reset();
            return result;
        }
    }

    class KhachHangDoanhNghiepBuilder : IKhachHangBuilder
    {
        private KhachHangDoanhNghiep khachHang = new KhachHangDoanhNghiep();

        public void reset()
        {
            khachHang = new KhachHangDoanhNghiep();
        }

        public void SetMaKhachHang(int maKhachHang)
        {
            khachHang.MaKhachHang = maKhachHang;
        }

        public void SetTenKhachHang(string tenKhachHang)
        {
            khachHang.TenKhachHang = tenKhachHang;
        }

        public void SetDienThoai(string dienThoai)
        {
            khachHang.DienThoai = dienThoai;
            
        }

        public void SetEmail(string email)
        {
            khachHang.Email = email;
        }

        public void SetDiaChi(string diaChi)
        {
            khachHang.DiaChi = diaChi; 
        }

        public void SetSoTienNo(int soTienNo)
        {
            khachHang.SoTienNo = soTienNo;
        }

        public void SetChietKhau(double ChietKhau)
        {
            khachHang.ChietKhau = ChietKhau;
        }

        public void SetTenCongTy(string TenCongTy)
        {
            khachHang.TenCongTy = TenCongTy;
        }

        public void SetMaSoThue(string MaSoThue)
        {
            khachHang.MaSoThue = MaSoThue;
        }

        public KhachHangDoanhNghiep Build()
        {
            KhachHangDoanhNghiep result = this.khachHang;
            this.reset();
            return result;
        }
    }
}
