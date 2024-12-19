using BLL;
using DTO;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace UEH_ChaCorner
{
    public partial class FRegister : Form
    {
        private readonly NHANVIEN_BLL _nvBll = new NHANVIEN_BLL();
        private readonly TAIKHOAN_BLL _tkBll = new TAIKHOAN_BLL();

        private int _manv;
        private string _quyen = @"NHANVIEN";

        public FRegister()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void Tatlbtrangthai()
        {
            Thread.Sleep(2000);
        }

        private void FRegister_Load(object sender, EventArgs e)
        {
            txtGender.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Insertnhanvien()
        {
            var nvPublic = new NHANVIEN_DTO();
            _manv = _nvBll.count_nhanvien();

            nvPublic.MaNV = "NV" + _manv;
            nvPublic.TenNV = txtFullname.Text;
            nvPublic.NgaySinh = DateTime.Parse(txtDOB.Text);
            nvPublic.SDT = txtPhone.Text;
            nvPublic.GioiTinh = txtGender.Text;

            _nvBll.insert_nhanvien(nvPublic);
        }

        private void Inserttaikhoan()
        {
            var tkPublic = new TAIKHOAN_DTO
            {
                TenTK = txtUsername.Text,
                MatKhau = txtPassword.Text,
                Quyen = _quyen,
                MaNV = "NV" + _manv
            };
            _tkBll.insert_taikhoan(tkPublic);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            var fLogin = new FLogin();
            fLogin.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                var t = new Thread(Tatlbtrangthai) { IsBackground = false };
                t.Start();
                return;
            }
            try
            {
                // Thêm nhân viên và tài khoản
                Insertnhanvien();
                Inserttaikhoan();

                // Thông báo thành công
                MessageBox.Show(@"Đăng ký thành công.", @"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Chuyển về trang đăng nhập
                Hide();
                var fLogin = new FLogin();
                fLogin.Show();
            }
            catch (SqlException loi)
            {
                // Xóa nhân viên nếu tạo tài khoản thất bại
                if (loi.Message.Contains("Violation of PRIMARY KEY constraint 'PK_TENTK'"))
                {
                    MessageBox.Show(@"Tên tài khoản bị trùng.", @"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DeleteNhanVien_Loi();
                }
            }
        }

        private bool ValidateInputs()
        {
            if (txtUsername.TextLength == 0)
            {
                ShowWarning(@"Chưa điền tên tài khoản.");
                return false;
            }
            if (txtUsername.TextLength <= 3)
            {
                ShowWarning(@"Tên tài khoản quá ngắn.");
                return false;
            }
            if (txtUsername.TextLength >= 50)
            {
                ShowWarning(@"Tên tài khoản quá dài.");
                return false;
            }
            if (txtPassword.TextLength == 0)
            {
                ShowWarning(@"Chưa điền mật khẩu.");
                return false;
            }
            if (txtPassword.TextLength <= 6)
            {
                ShowWarning(@"Mật khẩu quá ngắn.");
                return false;
            }
            if (txtPassword.TextLength >= 20)
            {
                ShowWarning(@"Mật khẩu quá dài.");
                return false;
            }
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

        private void DeleteNhanVien_Loi()
        {
            var nhanvienPublic = new NHANVIEN_DTO { MaNV = "NV" + _manv };
            _nvBll.delete_nhanvien(nhanvienPublic);
        }
    }
}