using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CNPM.DataAccessTier;
using CNPM.DataTransferObject;

namespace CNPM.BusinessLogicTier
{
    interface iAuthentication
    {
        bool Authenticate(string username, string password);
    }

    class TaiKhoanBLT : iAuthentication
    {
        public bool Authenticate(string username, string password)
        {
            TaiKhoanDAT taiKhoanDAT = new TaiKhoanDAT();
            TaiKhoan taiKhoan = taiKhoanDAT.GetTaiKhoan(username);
            if (taiKhoan != null && taiKhoan.MatKhau == password)
            {
                // Đăng nhập thành công
                return true;
            }
            // Đăng nhập thất bại
            return false;
        }
    }

    class AuthenticationProxy:iAuthentication
    {
        private TaiKhoanBLT taiKhoanBLT;

        public AuthenticationProxy(TaiKhoanBLT taiKhoanBLT)
        {
            this.taiKhoanBLT = taiKhoanBLT;
        }

        public bool Authenticate(string username, string password)
        {
            //logging proxy
            Console.WriteLine($"[{DateTime.Now}] Đang xác thực người dùng: {username}");

            //kiểm tra mật khẩu
            if (string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Lỗi: Mật khẩu không được để trống.");
                return false;
            }


            //real
            bool isAuthenticated = taiKhoanBLT.Authenticate(username, password);

            // Log sau khi xác thực
            Console.WriteLine(isAuthenticated ? "Đăng nhập thành công." : "Đăng nhập thất bại.");

            return isAuthenticated;
        }
    }
}
