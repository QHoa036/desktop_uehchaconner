using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using DTO;

using UEH_ChaCorner.Common;

namespace UEH_ChaCorner
{
    public partial class FLogin : Form
    {
        private readonly TAIKHOAN_BLL _accountBll = new TAIKHOAN_BLL();
        private string _quyen = "", _ten = "", _manv = "";

        public FLogin()
        {
            InitializeComponent();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            AcceptButton = btnLogin;
        }

        public void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            FHomepage.Mainmenu.EnableQuyen(_quyen, _ten, _manv);
        }

        private void ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
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
                        _quyen = roleAndName.Rows[0]["Quyen"].ToString().Trim();
                        _ten = roleAndName.Rows[0]["TenNV"].ToString().Trim();
                        _manv = roleAndName.Rows[0]["MaNV"].ToString().Trim();

                        // Chuyển sang trang Loading
                        //await ShowSplashScreenAsync();
                        Close();
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
                Utils.ShowError($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private void ShowSplashScreen()
        {
            Application.Run(new FLoading());
        }

        private Task ShowSplashScreenAsync()
        {
            return Task.Run(() =>
            {
                var splashThread = new Thread(new ThreadStart(ShowSplashScreen));
                splashThread.Start();
                Thread.Sleep(5600);
                splashThread.Join();
            });
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Close();
            var dk = new FRegister();
            dk.ShowDialog();
        }
    }
}