using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.DesignPatterns
{
      interface IKhachHangBuilder
    {
        IKhachHangBuilder SetTenKhachHang(string tenKhachHang);
        IKhachHangBuilder SetDienThoaiKhachHang(string dienThoai);
        IKhachHangBuilder SetEmailKhachHang(string email);
        IKhachHangBuilder SetDiaChiKhachHang(string diaChi);

        KhachHang Build();
    }
     class KhachHangBuilder : IKhachHangBuilder
    {

        public int MaKhachHang, SoTienNo;
        public string TenKhachHang, DienThoai, DiaChi, Email;

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

        // ... Thêm các phương thức setter khác

        public KhachHang Build()
        {
            return new KhachHang(MaKhachHang, TenKhachHang, DienThoai, Email, DiaChi, SoTienNo);
        }
    }
}
