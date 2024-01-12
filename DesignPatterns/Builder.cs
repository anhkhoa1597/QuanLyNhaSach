using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.DesignPatterns
{
    interface IKhachHangBuilder
    {
        IKhachHangBuilder SetMaKhachHang(int maKhachHang);
        IKhachHangBuilder SetTenKhachHang(string tenKhachHang);
        IKhachHangBuilder SetDienThoaiKhachHang(string dienThoai);
        IKhachHangBuilder SetEmailKhachHang(string email);
        IKhachHangBuilder SetDiaChiKhachHang(string diaChi);
        IKhachHangBuilder SetSoTienNo(int soTienNo);

        KhachHang Build();
    }

    class KhachHangBuilder : IKhachHangBuilder
    {
        private int MaKhachHang, SoTienNo;
        private string TenKhachHang, DienThoai, DiaChi, Email;

        public IKhachHangBuilder SetMaKhachHang(int maKhachHang)
        {
            this.MaKhachHang = maKhachHang;
            return this;
        }

        public IKhachHangBuilder SetTenKhachHang(string tenKhachHang)
        {
            this.TenKhachHang = tenKhachHang;
            return this;
        }

        public IKhachHangBuilder SetDienThoaiKhachHang(string dienThoai)
        {
            this.DienThoai = dienThoai;
            return this;
        }

        public IKhachHangBuilder SetEmailKhachHang(string email)
        {
            this.Email = email;
            return this;
        }

        public IKhachHangBuilder SetDiaChiKhachHang(string diaChi)
        {
            this.DiaChi = diaChi;
            return this;
        }

        public IKhachHangBuilder SetSoTienNo(int soTienNo)
        {
            this.SoTienNo = soTienNo;
            return this;
        }

        public KhachHang Build()
        {
            return new KhachHang(MaKhachHang, TenKhachHang, DienThoai, Email, DiaChi, SoTienNo);
        }
    }

}
