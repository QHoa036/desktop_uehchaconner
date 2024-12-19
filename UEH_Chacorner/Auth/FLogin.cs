using System;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using DTO;

using UEH_ChaCorner.Common;

namespace UEH_ChaCorner
{
    public partial class FLogin : Form
    {
        public static FHomepage MainMenu = new FHomepage();

        private readonly TAIKHOAN_BLL _accountBll = new TAIKHOAN_BLL();
        private string _quyennv = "", _tennv = "", _manv = "";

        public FLogin()
        {
            InitializeComponent();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            AcceptButton = btnLogin;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbClearFields_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var account = new TAIKHOAN_DTO
            {
                TenTK = txtUsername.Text.Trim(),
                MatKhau = txtPassword.Text.Trim()
            };

            try
            {
                // Kiểm tra tài khoản
                int checkPass = _accountBll.check_taikhoan(account);
                if (checkPass == 1)
                {
                    var roleAndName = _accountBll.get_tenvaquyen_taikhoan(account);
                    if (roleAndName.Rows.Count > 0)
                    {
                        // Lấy thông tin tài khoản
                        _quyennv = roleAndName.Rows[0]["Quyen"].ToString().Trim();
                        _tennv = roleAndName.Rows[0]["TenNV"].ToString().Trim();
                        _manv = roleAndName.Rows[0]["MaNV"].ToString().Trim();

                        // Tắt form đăng nhập
                        Hide();

                        // Chuyển sang trang Loading
                        //await ShowSplashScreenAsync();

                        // Mở form chính
                        MainMenu.setVisible(_quyennv, _tennv, txtUsername.Text.Trim(), _manv);
                        MainMenu.ShowDialog();
                    }
                    else
                    {
                        Utils.ShowError("Không tìm thấy tài khoản.");
                    }
                }
                else
                {
                    Utils.ShowError("Sai tài khoản hay mật khẩu.");
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                Utils.ShowError($"{ex.Message}");
            }
        }

        private Task ShowSplashScreenAsync()
        {
            return Task.Run(() =>
            {
                using (var splashScreen = new FLoading())
                {
                    splashScreen.ShowDialog();
                }
            });
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hide();
            var fRegister = new FRegister();
            fRegister.ShowDialog();
        }
    }
}