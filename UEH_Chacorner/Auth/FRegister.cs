using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

using BLL;
using DTO;

namespace UEH_ChaCorner
{
    public partial class FRegister : Form
    {
        private readonly NHANVIEN_BLL _nvBll = new NHANVIEN_BLL();
        private readonly TAIKHOAN_BLL _tkBll = new TAIKHOAN_BLL();

        private int _manv;
        private string _quyen = "";

        public FRegister()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        #region Method

        private void Tatlbtrangthai()
        {
            Thread.Sleep(2000);
            lbtrangthai.Text = "";
        }

        private void Insertnhanvien()
        {
            var nvPublic = new NHANVIEN_DTO();
            _manv = _nvBll.count_nhanvien();

            nvPublic.MaNV = "NV" + _manv;
            nvPublic.TenNV = txthovaten.Text;
            nvPublic.NgaySinh = DateTime.Parse(datengaysinh.Text);
            nvPublic.SDT = txtsdt.Text;
            nvPublic.GioiTinh = cbgioitinh.Text;

            _nvBll.insert_nhanvien(nvPublic);
        }

        private void Inserttaikhoan()
        {
            var tkPublic = new TAIKHOAN_DTO
            {
                TenTK = txttentk.Text,
                MatKhau = txtmatkhau.Text,
                Quyen = _quyen,
                MaNV = "NV" + _manv
            };
            _tkBll.insert_taikhoan(tkPublic);
        }

        #endregion

        #region Event

        private void FRegister_Load(object sender, EventArgs e)
        {
            cbgioitinh.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btdangky_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                var t = new Thread(Tatlbtrangthai) { IsBackground = false };
                t.Start();
                return;
            }

            try
            {
                Insertnhanvien();
                Inserttaikhoan();
                Close();
            }
            catch (SqlException loi)
            {
                if (loi.Message.Contains("Violation of PRIMARY KEY constraint 'PK_TENTK'"))
                {
                    MessageBox.Show(@"Tên tài khoản bị trùng.", @"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DeleteNhanVien_Loi();
                }
            }
        }

        private bool ValidateInputs()
        {
            if (txttentk.TextLength == 0)
            {
                ShowWarning(@"Chưa điền tên tài khoản.");
                return false;
            }
            if (txttentk.TextLength <= 3)
            {
                ShowWarning(@"Tên tài khoản quá ngắn.");
                return false;
            }
            if (txttentk.TextLength >= 50)
            {
                ShowWarning(@"Tên tài khoản quá dài.");
                return false;
            }
            if (txtmatkhau.TextLength == 0)
            {
                ShowWarning(@"Chưa điền mật khẩu.");
                return false;
            }
            if (txtmatkhau.TextLength <= 6)
            {
                ShowWarning(@"Mật khẩu quá ngắn.");
                return false;
            }
            if (txtmatkhau.TextLength >= 20)
            {
                ShowWarning(@"Mật khẩu quá dài.");
                return false;
            }
            if (txthovaten.TextLength == 0)
            {
                ShowWarning(@"Chưa điền họ và tên.");
                return false;
            }
            if (txthovaten.TextLength >= 100)
            {
                ShowWarning(@"Họ và tên quá dài.");
                return false;
            }
            if (datengaysinh.Value.Year == DateTime.Today.Year)
            {
                ShowWarning(@"Chưa chọn ngày sinh.");
                return false;
            }
            if (txtsdt.TextLength == 0)
            {
                ShowWarning(@"Chưa điền số điện thoại.");
                return false;
            }
            if (txtsdt.TextLength >= 12)
            {
                ShowWarning(@"Số điện thoại quá dài.");
                return false;
            }
            if (string.IsNullOrEmpty(cbgioitinh.Text))
            {
                ShowWarning(@"Chưa chọn giới tính.");
                return false;
            }
            if (!rdadmin.Checked && !rdnhanvien.Checked)
            {
                ShowWarning(@"Chưa chọn quyền của tài khoản.");
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
            var nhanvienPublic = new NHANVIEN_DTO {MaNV = "NV" + _manv};
            _nvBll.delete_nhanvien(nhanvienPublic);
        }

        private void rdadmin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdadmin.Checked) _quyen = @"ADMIN";
        }

        private void rdnhanvien_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnhanvien.Checked) _quyen = @"NHANVIEN";
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') e.Handled = true;
            if (e.KeyChar == '.' && ((TextBox) sender).Text.IndexOf('.') > -1) e.Handled = true;
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Hide();
            var fLogin = new FLogin();
            fLogin.Show();
        }

        #endregion
    }
}