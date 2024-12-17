using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using DTO;

namespace UEH_ChaCorner.Home
{
    public partial class FStaff : Form
    {
        // Khai báo các đối tượng BLL 
        private readonly NHANVIEN_BLL _nhanvienBll = new NHANVIEN_BLL();
        private readonly TAIKHOAN_BLL _taikhoanBll = new TAIKHOAN_BLL();

        private DataTable _staffData;

        public FStaff()
        {
            InitializeComponent();
        }
        #region Method
        private bool KiemTraTenHopLe(string ten)
        {
            // Tên chỉ chứa chữ cái 
            var regex = new Regex(@"^[\p{L}\s]+$");
            return regex.IsMatch(ten.Trim());
        }

        // Tải danh sách nhân viên vào DataGridView
        private void LoadStaffList()
        {
            _staffData = _nhanvienBll.load_nhanvien();
            DataView activeEmployees = _staffData.DefaultView;
            activeEmployees.RowFilter = "TrangThai = 1";
            dgvStaff.DataSource = activeEmployees.ToTable();

            // Đặt lại tiêu đề cột
            if (dgvStaff.Columns.Contains("MaNV"))
                dgvStaff.Columns["MaNV"].HeaderText = @"Mã";

            if (dgvStaff.Columns.Contains("TenNV"))
                dgvStaff.Columns["TenNV"].HeaderText = @"Họ tên";

            if (dgvStaff.Columns.Contains("NgaySinh"))
            {
                dgvStaff.Columns["NgaySinh"].HeaderText = @"DOB";
                dgvStaff.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvStaff.Columns.Contains("SDT"))
                dgvStaff.Columns["SDT"].HeaderText = @"SĐT";

            if (dgvStaff.Columns.Contains("GioiTinh"))
                dgvStaff.Columns["GioiTinh"].HeaderText = @"Giới tính";

            if (dgvStaff.Columns.Contains("Quyen"))
                dgvStaff.Columns["Quyen"].HeaderText = @"Chức vụ";


            // Ẩn các cột không cần thiết
            if (dgvStaff.Columns.Contains("MatKhau"))
                dgvStaff.Columns["MatKhau"].Visible = false;

            if (dgvStaff.Columns.Contains("TenTK"))
                dgvStaff.Columns["TenTK"].Visible = false;

            if (dgvStaff.Columns.Contains("TrangThai"))
                dgvStaff.Columns["TrangThai"].Visible = false;
        }

        public bool KiemTraSoDienThoai(string sdt, string maNV)
        {   
            DataTable dtNhanVien = _nhanvienBll.load_nhanvien();
            // Kiểm tra số điện thoại trùng (ngoại trừ nhân viên đang chỉnh sửa)
            foreach (DataRow row in dtNhanVien.Rows)
            {
                string sdtRow = row["SDT"].ToString().Trim();
                string maNVRow = row["MaNV"].ToString().Trim();

                if (sdtRow == sdt.Trim() && maNVRow != maNV.Trim())
                {
                    return true;
                }
            }
            return false;
        }


        private void EditEmployee()
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                string maNV = dgvStaff.SelectedRows[0].Cells["MaNV"].Value.ToString();
                string tenNV = txtTenNV.Text;
                string gioiTinh = txtGioiTinh.Text.Trim().ToLower();
                gioiTinh = char.ToUpper(gioiTinh[0]) + gioiTinh.Substring(1); // Viết hoa chữ đầu

                // Lấy thông tin hiện tại của nhân viên từ DataGridView
                string oldTenNV = dgvStaff.SelectedRows[0].Cells["TenNV"].Value.ToString().Trim();
                DateTime oldNgaySinh = DateTime.Parse(dgvStaff.SelectedRows[0].Cells["NgaySinh"].Value.ToString());
                string oldSDT = dgvStaff.SelectedRows[0].Cells["SDT"].Value.ToString().Trim();
                string oldGioiTinh = dgvStaff.SelectedRows[0].Cells["GioiTinh"].Value.ToString().Trim();

                // So sánh thông tin cũ và mới
                if (oldTenNV == tenNV &&
                    oldNgaySinh.Date == dtpNgaySinh.Value.Date &&
                    oldSDT == txtSDT.Text.Trim() &&
                    oldGioiTinh == gioiTinh)
                {
                    MessageBox.Show("Bạn chưa thay đổi thông tin gì.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Kiểm tra các trường dữ liệu
                if (string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                    string.IsNullOrWhiteSpace(txtSDT.Text) ||
                    string.IsNullOrWhiteSpace(txtGioiTinh.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi chỉnh sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra tên nhân viên chỉ chứa chữ cái
                if (!KiemTraTenHopLe(tenNV))
                {
                    MessageBox.Show("Tên nhân viên chỉ được chứa chữ cái.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra typing giới tính
                if (gioiTinh != "Nam" && gioiTinh != "Nữ")
                {
                    MessageBox.Show("Giới tính chỉ được nhập là 'Nam' hoặc 'Nữ'.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra ngày sinh không vượt quá ngày hiện tại
                if (dtpNgaySinh.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra số điện thoại chỉ chứa số
                if (!long.TryParse(txtSDT.Text, out _) || txtSDT.Text.Length < 9 || txtSDT.Text.Length > 12)
                {
                    MessageBox.Show("Số điện thoại phải đủ 10 ký tự là số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sdtInput = txtSDT.Text.Trim();
                string maNVInput = maNV.Trim();
                // Kiểm tra số điện thoại có bị trùng không
                bool isPhoneDuplicate = KiemTraSoDienThoai(sdtInput, maNVInput);
                if (isPhoneDuplicate)
                {
                    MessageBox.Show("Số điện thoại này đã được sử dụng bởi nhân viên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Tạo đối tượng nhân viên
                var employee = new NHANVIEN_DTO
                {
                    MaNV = maNV,
                    TenNV = txtTenNV.Text,
                    NgaySinh = dtpNgaySinh.Value,
                    SDT = txtSDT.Text,
                    GioiTinh = gioiTinh
                };

                // Gọi phương thức cập nhật
                int result = _nhanvienBll.update_nhanvien(employee);
                if (result > 0)
                {
                    MessageBox.Show("Thông tin nhân viên đã được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStaffList();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chọn nhân viên cần chỉnh sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadStaffList();
        }
        #endregion

        #region Event
        // Load form
        private void FManageStaff_Load(object sender, EventArgs e)
        {
            LoadStaffList();
        }

        // Nút tìm kiếm
        private void btnSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                DataTable searchResults = _nhanvienBll.TIM_TenNV_hoatdong(new NHANVIEN_DTO { TenNV = searchTerm });
                dgvStaff.DataSource = searchResults;
            }
            else
            {
                LoadStaffList();
            }

        }

        // Nút xóa nhân viên
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                string maNV = dgvStaff.SelectedRows[0].Cells["MaNV"].Value.ToString();
                var employee = new NHANVIEN_DTO { MaNV = maNV };
                var account = new TAIKHOAN_DTO { MaNV = maNV };

                // Xóa tài khoản liên kết trong bảng TàiKhoan
                int result2 = _taikhoanBll.DELETE_TaiKhoanwithMaNV(account);

                // Xóa nhân viên trong bảng NhanVien
                int result1 = _nhanvienBll.DELETE_NhanVien_TrangThai(employee);

                if (result1 > 0 && result2 > 0)
                {
                    MessageBox.Show("Nhân viên và tài khoản đã được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStaffList();
                }
                else
                {
                    MessageBox.Show("Không thể xóa nhân viên hoặc tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chọn nhân viên cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        // Nút sửa thông tin
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditEmployee();
        }

        // CellClick DataGridView 
        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStaff.Rows[e.RowIndex];
                txtTenNV.Text = row.Cells["MaNV"].Value.ToString();
                txtTenNV.Text = row.Cells["TenNV"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                txtSDT.Text = row.Cells["SDT"].Value.ToString();

                string gioiTinh = row.Cells["GioiTinh"].Value.ToString();
                if (!string.IsNullOrEmpty(gioiTinh))
                {
                    // Check if the ComboBox contains the value
                    if (string.Equals(gioiTinh, "Nam", StringComparison.OrdinalIgnoreCase))
                    {
                        txtGioiTinh.SelectedItem = gioiTinh;
                        txtGioiTinh.Text = gioiTinh;
                        txtGioiTinh.SelectedIndex = 0;
                    }
                    else if (gioiTinh == "Nữ ")
                    {
                        txtGioiTinh.SelectedItem = gioiTinh;
                        txtGioiTinh.Text = gioiTinh;
                        txtGioiTinh.SelectedIndex = 1;
                    }
                    else
                    {
                        txtGioiTinh.SelectedIndex = -1; 
                    }
                }
            }
            txtTenNV.Focus();
        }
        #endregion
    }
}




