using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CNPM.DataAccessTier;
using CNPM.DataTransferObject;
using CNPM.BusinessLogicTier;
using System.Windows.Forms;

namespace CNPM.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = account.Text;
            string matKhau = password.Text;
            TaiKhoanBLT taiKhoanBLT = new TaiKhoanBLT();
            AuthenticationProxy authProxy = new AuthenticationProxy(taiKhoanBLT);

            //xác thực thông qua proxy
            bool isAuthenticated = authProxy.Authenticate(tenTaiKhoan, matKhau);

            if (isAuthenticated)
            {
                // Đăng nhập thành công
                MessageBox.Show("Đăng Nhập Thành Công.");
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                // Thông báo lỗi
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng.");
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra xem MainForm có đang mở không
            if (Application.OpenForms.OfType<MainForm>().Any())
            {
                // Nếu MainForm mở, chỉ đóng form này
                e.Cancel = true;
                this.Hide();
            }
            else
            {
                // Nếu không, thoát ứng dụng
                Application.Exit();
            }
        }
    }
}
