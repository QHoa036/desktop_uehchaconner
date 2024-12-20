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
            InitializeComponent(); // Khởi tạo giao diện
        }

        // Thuộc tính để lưu thông tin tài khoản
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string Quyen { get; set; }
        public string TenTK { get; set; }

        private void FAccount_Load(object sender, EventArgs e)
        {
            _quyennv = _tennv = _tentk = _manv = _sdt = _gioitinh = _ngaysinh = "";

            // Lấy thông tin tài khoản từ các thuộc tính
            _quyennv = Quyen;
            _tennv = TenNV;
            _manv = MaNV;
            _tentk = TenTK;

            // Tìm thông tin nhân viên từ cơ sở dữ liệu
            var searchResults = _nhanvienBll.TIM_TenNV_hoatdong(new NHANVIEN_DTO { TenNV = _tennv });
            _sdt = searchResults.Rows[0]["SDT"].ToString().Trim(); // Lấy số điện thoại
            _gioitinh = searchResults.Rows[0]["GioiTinh"].ToString().Trim(); // Lấy giới tính
            _ngaysinh = searchResults.Rows[0]["NgaySinh"].ToString().Trim(); // Lấy ngày sinh

            // Hiển thị thông tin nhân viên trên giao diện
            lbName.Text = _tennv; // Hiển thị tên
            lbRole.Text = _quyennv == "ADMIN" ? "Quản trị viên" : "Nhân viên"; // Hiển thị vai trò
            txtFullname.Text = _tennv;
            txtPhone.Text = _sdt;
            txtGender.Text = _gioitinh;
            txtDOB.Text = _ngaysinh;
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng nhân viên để cập nhật thông tin
            var nhanvien = new NHANVIEN_DTO
            {
                MaNV = _manv,
                TenNV = txtFullname.Text.Trim(),
                SDT = txtPhone.Text.Trim(),
                GioiTinh = txtGender.Text.Trim(),
                NgaySinh = Convert.ToDateTime(txtDOB.Text.Trim())
            };

            // Kiểm tra dữ liệu nhập vào có hợp lệ hay không
            if (!ValidateInputs())
            {
                return;
            }

            try
            {
                // Gửi yêu cầu cập nhật thông tin nhân viên
                int result = _nhanvienBll.update_nhanvien(nhanvien);
                if (result == 1)
                {
                    Utils.ShowSuccess("Cập nhật thông tin thành công."); // Thông báo thành công
                    _tennv = TenNV = txtFullname.Text.Trim(); // Cập nhật lại thông tin trên giao diện
                    lbName.Text = TenNV;
                    FHomepage.MainMenu.setVisible(_quyennv, _tennv, _tentk, _manv);
                }
                else
                {
                    Utils.ShowError("Cập nhật thông tin thất bại."); // Thông báo thất bại
                }
            }
            catch (Exception ex)
            {
                Utils.ShowError($"{ex.Message}"); // Thông báo lỗi
            }
        }

        public void FAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Đặt lại các biến thông tin tài khoản
            _quyennv = _tennv = _tentk = _manv = _sdt = _gioitinh = _ngaysinh = "";

            // Chuyển về trang chủ
            FHomepage.MainMenu.setVisible(_quyennv, _tennv, _tentk, _manv);
        }

        private void btChangePassword_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng tài khoản để xử lý đổi mật khẩu
            var account = new TAIKHOAN_DTO
            {
                TenTK = _tentk,
                MatKhau = txtOldPassword.Text.Trim(), // Mật khẩu cũ
                Quyen = _quyennv,
                MaNV = _manv
            };

            try
            {
                // Kiểm tra tài khoản với mật khẩu cũ
                int checkPass = _accountBll.check_taikhoan(account);
                if (checkPass == 1)
                {
                    var roleAndName = _accountBll.get_tenvaquyen_taikhoan(account);
                    if (roleAndName.Rows.Count > 0)
                    {
                        // Lấy lại thông tin tài khoản
                        _quyennv = roleAndName.Rows[0]["Quyen"].ToString().Trim();
                        _tennv = roleAndName.Rows[0]["TenNV"].ToString().Trim();
                        _manv = roleAndName.Rows[0]["MaNV"].ToString().Trim();

                        // Cập nhật mật khẩu mới
                        account.MatKhau = txtNewPassword.Text.Trim();
                        int result = _accountBll.update_taikhoan(account);
                        if (result == 1)
                        {
                            Utils.ShowSuccess("Đổi mật khẩu thành công."); // Thông báo thành công
                            txtOldPassword.Clear();
                            txtNewPassword.Clear();
                            txtConfirmPassword.Clear();
                        }
                        else
                        {
                            Utils.ShowError("Đổi mật khẩu thất bại."); // Thông báo thất bại
                        }
                    }
                    else
                    {
                        Utils.ShowError("Không tìm thấy tài khoản."); // Không tìm thấy tài khoản
                    }
                }
                else
                {
                    Utils.ShowError("Sai tài khoản hay mật khẩu."); // Sai thông tin
                    txtOldPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                Utils.ShowError($"{ex.Message}"); // Thông báo lỗi
            }
        }

        private bool ValidateInputs()
        {
            // Kiểm tra họ và tên
            if (txtFullname.TextLength == 0)
            {
                ShowWarning("Chưa điền họ và tên.");
                return false;
            }
            if (txtFullname.TextLength >= 100)
            {
                ShowWarning("Họ và tên quá dài.");
                return false;
            }

            // Kiểm tra ngày sinh
            if (txtDOB.Value.Year == DateTime.Today.Year)
            {
                ShowWarning("Chưa chọn ngày sinh.");
                return false;
            }

            // Kiểm tra số điện thoại
            if (txtPhone.TextLength == 0)
            {
                ShowWarning("Chưa điền số điện thoại.");
                return false;
            }
            if (txtPhone.TextLength != txtPhone.Text.Where(char.IsDigit).Count())
            {
                ShowWarning("Số điện thoại không hợp lệ.");
                return false;
            }
            if (txtPhone.TextLength >= 12)
            {
                ShowWarning("Số điện thoại quá dài.");
                return false;
            }

            // Kiểm tra ngày sinh hợp lệ
            if (string.IsNullOrEmpty(txtDOB.Text))
            {
                ShowWarning("Chưa chọn giới tính.");
                return false;
            }

            if (!DateTime.TryParse(txtDOB.Text, out var dob))
            {
                ShowWarning("Ngày sinh không hợp lệ. Vui lòng nhập đúng định dạng.");
                return false;
            }

            // Kiểm tra tuổi
            var now = DateTime.Now;
            var age = now.Year - dob.Year;
            if (dob > now.AddYears(-age))
            {
                age--;
            }
            if (age < 18)
            {
                ShowWarning("Tuổi phải ít nhất là 18.");
                return false;
            }

            return true; // Dữ liệu hợp lệ
        }

        private void ShowWarning(string message)
        {
            // Hiển thị thông báo lỗi
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
