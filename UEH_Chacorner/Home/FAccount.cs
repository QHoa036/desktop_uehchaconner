using BLL;
using DTO;

using System;
using System.Windows.Forms;

using UEH_ChaCorner.Common;

namespace UEH_ChaCorner
{
    public partial class FAccount : Form
    {
        private readonly TAIKHOAN_BLL _accountBll = new TAIKHOAN_BLL();
        private string _quyennv = "", _tennv = "", _manv = "";

        public FAccount()
        {
            InitializeComponent();
        }

        public string MaNV { get; set; }

        public string TenNV { get; set; }

        public string Quyen { get; set; }

        private void FAccount_Load(object sender, EventArgs e)
        {
            // Lấy thông tin tài khoản
            _quyennv = Quyen;
            _tennv = TenNV;
            _manv = MaNV;

            // Hiển thị thông tin tài khoản
            lbName.Text = _tennv;
            if (_quyennv == "ADMIN")
            {
                lbRole.Text = "Quản trị viên";
            }
            else
            {
                lbRole.Text = "Nhân viên";
            }
        }

        public void FAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            FHomepage.MainMenu.setVisible(_quyennv, _tennv, _manv);
        }

        private void btChangePassword_Click(object sender, EventArgs e)
        {
            var account = new TAIKHOAN_DTO
            {
                TenTK = TenNV,
                MatKhau = txtOldPassword.Text.Trim()
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

                        // Đổi mật khẩu
                        account.MatKhau = txtNewPassword.Text.Trim();
                        int result = _accountBll.update_taikhoan(account);
                        if (result == 1)
                        {
                            Utils.ShowSuccess("Đổi mật khẩu thành công.");
                            txtOldPassword.Clear();
                            txtNewPassword.Clear();
                            txtOldPassword.Focus();
                        }
                        else
                        {
                            Utils.ShowError("Đổi mật khẩu thất bại.");
                        }
                    }
                    else
                    {
                        Utils.ShowError("Không tìm thấy tài khoản.");
                    }
                }
                else
                {
                    Utils.ShowError("Sai tài khoản hay mật khẩu.");
                    txtOldPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                Utils.ShowError($"{ex.Message}");
            }
        }
    }
}