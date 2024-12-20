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
        // Biến tĩnh để lưu form chính của ứng dụng
        public static FHomepage MainMenu = new FHomepage();

        // Khởi tạo đối tượng xử lý nghiệp vụ liên quan đến tài khoản
        private readonly TAIKHOAN_BLL _accountBll = new TAIKHOAN_BLL();
        private string _quyennv = "", _tennv = "", _manv = ""; // Lưu thông tin quyền, tên, mã nhân viên

        public FLogin()
        {
            InitializeComponent(); // Khởi tạo giao diện
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            // Thiết lập focus vào ô nhập tài khoản và nút Enter để đăng nhập
            txtUsername.Focus();
            AcceptButton = btnLogin;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Đóng ứng dụng khi nhấn nút "Thoát"
            Application.Exit();
        }

        private void lbClearFields_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu trong các ô nhập và focus lại vào ô nhập tài khoản
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng tài khoản với thông tin nhập từ giao diện
            var account = new TAIKHOAN_DTO
            {
                TenTK = txtUsername.Text.Trim(),
                MatKhau = txtPassword.Text.Trim()
            };

            try
            {
                // Kiểm tra tài khoản và mật khẩu
                int checkPass = _accountBll.check_taikhoan(account);
                if (checkPass == 1)
                {
                    // Nếu thông tin hợp lệ, lấy quyền và thông tin tài khoản từ cơ sở dữ liệu
                    var roleAndName = _accountBll.get_tenvaquyen_taikhoan(account);
                    if (roleAndName.Rows.Count > 0)
                    {
                        // Lưu thông tin quyền, tên, mã nhân viên
                        _quyennv = roleAndName.Rows[0]["Quyen"].ToString().Trim();
                        _tennv = roleAndName.Rows[0]["TenNV"].ToString().Trim();
                        _manv = roleAndName.Rows[0]["MaNV"].ToString().Trim();

                        // Ẩn form đăng nhập
                        Hide();

                        // Hiển thị màn hình loading
                        //await ShowSplashScreenAsync();

                        // Hiển thị form chính và chuyển quyền truy cập
                        MainMenu.setVisible(_quyennv, _tennv, txtUsername.Text.Trim(), _manv);
                        MainMenu.ShowDialog();
                    }
                    else
                    {
                        Utils.ShowError("Không tìm thấy tài khoản."); // Thông báo lỗi nếu tài khoản không tồn tại
                    }
                }
                else
                {
                    Utils.ShowError("Sai tài khoản hay mật khẩu."); // Thông báo lỗi nếu tài khoản hoặc mật khẩu không hợp lệ
                    txtUsername.Focus(); // Đặt lại focus vào ô nhập tài khoản
                }
            }
            catch (Exception ex)
            {
                Utils.ShowError($"{ex.Message}"); // Hiển thị lỗi nếu có ngoại lệ xảy ra
            }
        }

        private Task ShowSplashScreenAsync()
        {
            // Hiển thị màn hình loading trong một luồng khác
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
            // Mở form đăng ký khi nhấn nút "Đăng ký"
            Hide();
            var fRegister = new FRegister();
            fRegister.ShowDialog();
        }
    }
}
