using BLL;
using DTO;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using UEH_ChaCorner.Common;

namespace UEH_ChaCorner
{
    public partial class FAccount : Form
    {
        private readonly NHANVIEN_BLL _nhanvienBll = new NHANVIEN_BLL();
        private readonly TAIKHOAN_BLL _accountBll = new TAIKHOAN_BLL();
        private string _quyennv = "", _tennv = "", _tentk = "", _manv = "", _sdt = "", _gioitinh = "", _ngaysinh = "";

        public FAccount()
        {
            InitializeComponent();
        }

        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string Quyen { get; set; }
        public string TenTK { get; set; }

        private void FAccount_Load(object sender, EventArgs e)
        {
            // Lấy thông tin tài khoản
            _quyennv = Quyen;
            _tennv = TenNV;
            _manv = MaNV;
            _tentk = TenTK;
            var searchResults = _nhanvienBll.TIM_TenNV_hoatdong(new NHANVIEN_DTO { TenNV = _tennv });
            _sdt = searchResults.Rows[0]["SDT"].ToString().Trim();
            _gioitinh = searchResults.Rows[0]["GioiTinh"].ToString().Trim();
            _ngaysinh = searchResults.Rows[0]["NgaySinh"].ToString().Trim();

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
            txtFullname.Text = _tennv;
            txtPhone.Text = _sdt;
            txtGender.Text = _gioitinh;
            txtDOB.Text = _ngaysinh;
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            var nhanvien = new NHANVIEN_DTO
            {
                MaNV = _manv,
                TenNV = txtFullname.Text.Trim(),
                SDT = txtPhone.Text.Trim(),
                GioiTinh = txtGender.Text.Trim(),
                NgaySinh = Convert.ToDateTime(txtDOB.Text.Trim())
            };

            if (!ValidateInputs())
            {
                return;
            }
            try
            {
                int result = _nhanvienBll.update_nhanvien(nhanvien);
                if (result == 1)
                {
                    Utils.ShowSuccess("Cập nhật thông tin thành công.");
                    _tennv = TenNV = txtFullname.Text.Trim();
                    lbName.Text = TenNV;
                    FHomepage.MainMenu.setVisible(_quyennv, _tennv, _tentk, _manv);
                }
                else
                {
                    Utils.ShowError("Cập nhật thông tin thất bại.");
                }
            }
            catch (Exception ex)
            {
                Utils.ShowError($"{ex.Message}");
            }
        }

        public void FAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Reset thông tin tài khoản
            _quyennv = _tennv = _tentk = _manv = _sdt = _gioitinh = _ngaysinh = "";

            // Chuyển về trang chủ
            FHomepage.MainMenu.setVisible(_quyennv, _tennv, _tentk, _manv);
        }

        private void btChangePassword_Click(object sender, EventArgs e)
        {
            var account = new TAIKHOAN_DTO
            {
                TenTK = _tentk,
                MatKhau = txtOldPassword.Text.Trim(),
                Quyen = _quyennv,
                MaNV = _manv
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
                            txtConfirmPassword.Clear();
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

        private bool ValidateInputs()
        {
            if (txtFullname.TextLength == 0)
            {
                ShowWarning(@"Chưa điền họ và tên.");
                return false;
            }
            if (txtFullname.TextLength >= 100)
            {
                ShowWarning(@"Họ và tên quá dài.");
                return false;
            }
            if (txtDOB.Value.Year == DateTime.Today.Year)
            {
                ShowWarning(@"Chưa chọn ngày sinh.");
                return false;
            }
            if (txtPhone.TextLength == 0)
            {
                ShowWarning(@"Chưa điền số điện thoại.");
                return false;
            }
            if (txtPhone.TextLength != txtPhone.Text.Where(char.IsDigit).Count())
            {
                ShowWarning(@"Số điện thoại không hợp lệ.");
                return false;
            }
            if (txtPhone.TextLength >= 12)
            {
                ShowWarning(@"Số điện thoại quá dài.");
                return false;
            }
            if (string.IsNullOrEmpty(txtDOB.Text))
            {
                ShowWarning(@"Chưa chọn giới tính.");
                return false;
            }
            var now = DateTime.Now;
            if (!DateTime.TryParse(txtDOB.Text, out var dob))
            {
                ShowWarning("Ngày sinh không hợp lệ. Vui lòng nhập đúng định dạng.");
                return false;
            }
            var age = now.Year - dob.Year;
            if (dob > now.AddYears(-age))
            {
                age--;
            }
            if (age < 18)
            {
                ShowWarning("Ngày sinh không được quá ngày hiện tại và tuổi phải ít nhất là 18.");
                return false;
            }
            return true;
        }

        private void ShowWarning(string message)
        {
            MessageBox.Show(message, @"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}