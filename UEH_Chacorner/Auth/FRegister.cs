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
        // Đối tượng xử lý nghiệp vụ liên quan đến nhân viên và tài khoản
        private readonly NHANVIEN_BLL _nvBll = new NHANVIEN_BLL();
        private readonly TAIKHOAN_BLL _tkBll = new TAIKHOAN_BLL();

        private int _manv; // Biến lưu số thứ tự của nhân viên mới
        private string _quyen = @"NHANVIEN"; // Mặc định quyền của tài khoản là nhân viên

        public FRegister()
        {
            // Cho phép gọi các thao tác không an toàn trên các thread khác nhau
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent(); // Khởi tạo giao diện form
        }

        private void Tatlbtrangthai()
        {
            // Tạm dừng trong 2 giây
            Thread.Sleep(2000);
        }

        private void FRegister_Load(object sender, EventArgs e)
        {
            // Đặt chế độ cho ComboBox "Giới tính" chỉ cho phép chọn từ danh sách
            txtGender.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Insertnhanvien()
        {
            // Thêm thông tin nhân viên vào cơ sở dữ liệu
            var nvPublic = new NHANVIEN_DTO();
            _manv = _nvBll.count_nhanvien(); // Lấy số lượng nhân viên hiện tại để tạo mã mới

            nvPublic.MaNV = "NV" + _manv; // Tạo mã nhân viên mới
            nvPublic.TenNV = txtFullname.Text; // Lấy tên nhân viên từ ô nhập liệu
            nvPublic.NgaySinh = DateTime.Parse(txtDOB.Text); // Lấy ngày sinh
            nvPublic.SDT = txtPhone.Text; // Lấy số điện thoại
            nvPublic.GioiTinh = txtGender.Text; // Lấy giới tính

            _nvBll.insert_nhanvien(nvPublic); // Gọi phương thức thêm nhân viên
        }

        private void Inserttaikhoan()
        {
            // Thêm thông tin tài khoản vào cơ sở dữ liệu
            var tkPublic = new TAIKHOAN_DTO
            {
                TenTK = txtUsername.Text, // Tên tài khoản
                MatKhau = txtPassword.Text, // Mật khẩu
                Quyen = _quyen, // Quyền mặc định là nhân viên
                MaNV = "NV" + _manv // Gắn mã nhân viên cho tài khoản
            };
            _tkBll.insert_taikhoan(tkPublic); // Gọi phương thức thêm tài khoản
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Quay lại trang đăng nhập
            Hide();
            var fLogin = new FLogin();
            fLogin.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập có hợp lệ không
            if (!ValidateInputs())
            {
                var t = new Thread(Tatlbtrangthai) { IsBackground = false }; // Hiển thị trạng thái lỗi trong 2 giây
                t.Start();
                return;
            }
            try
            {
                // Thêm thông tin nhân viên và tài khoản vào cơ sở dữ liệu
                Insertnhanvien();
                Inserttaikhoan();

                // Hiển thị thông báo đăng ký thành công
                MessageBox.Show(@"Đăng ký thành công.", @"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Chuyển về trang đăng nhập
                Hide();
                var fLogin = new FLogin();
                fLogin.Show();
            }
            catch (SqlException loi)
            {
                // Nếu lỗi do trùng tên tài khoản, hiển thị thông báo và xóa nhân viên vừa thêm
                if (loi.Message.Contains("Violation of PRIMARY KEY constraint 'PK_TENTK'"))
                {
                    MessageBox.Show(@"Tên tài khoản bị trùng.", @"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DeleteNhanVien_Loi();
                }
            }
        }

        private bool ValidateInputs()
        {
            // Kiểm tra các điều kiện nhập liệu

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

            return true; // Dữ liệu hợp lệ
        }

        private void ShowWarning(string message)
        {
            // Hiển thị thông báo lỗi với nội dung message
            MessageBox.Show(message, @"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void DeleteNhanVien_Loi()
        {
            // Xóa thông tin nhân viên trong trường hợp lỗi
            var nhanvienPublic = new NHANVIEN_DTO { MaNV = "NV" + _manv };
            _nvBll.delete_nhanvien(nhanvienPublic);
        }
    }
}
