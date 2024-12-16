﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using DTO;

namespace UEH_Chacorner.Home
{
    public partial class FManageStaff : Form
    {
        // Khai báo các đối tượng BLL 
        private readonly NHANVIEN_BLL _nhanvienBll = new NHANVIEN_BLL();
        private readonly TAIKHOAN_BLL _taikhoanBll = new TAIKHOAN_BLL();

        private DataTable _staffData;

        public FManageStaff()
        {
            InitializeComponent();
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
                dgvStaff.Columns["MaNV"].HeaderText = @"Mã nhân viên";

            if (dgvStaff.Columns.Contains("TenNV"))
                dgvStaff.Columns["TenNV"].HeaderText = @"Tên nhân viên";

            if (dgvStaff.Columns.Contains("NgaySinh"))
            {
                dgvStaff.Columns["NgaySinh"].HeaderText = @"Ngày sinh";
                dgvStaff.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvStaff.Columns.Contains("SDT"))
                dgvStaff.Columns["SDT"].HeaderText = @"Số điện thoại";

            if (dgvStaff.Columns.Contains("GioiTinh"))
                dgvStaff.Columns["GioiTinh"].HeaderText = @"Giới tính";

            if (dgvStaff.Columns.Contains("Quyen"))
                dgvStaff.Columns["Quyen"].HeaderText = @"Quyền";


            // Ẩn các cột không cần thiết
            if (dgvStaff.Columns.Contains("MatKhau"))
                dgvStaff.Columns["MatKhau"].Visible = false;

            if (dgvStaff.Columns.Contains("TenTK"))
                dgvStaff.Columns["TenTK"].Visible = false;

            if (dgvStaff.Columns.Contains("TrangThai"))
                dgvStaff.Columns["TrangThai"].Visible = false;

        }

        #region Event
        // Load form
        private void FManageStaff_Load(object sender, EventArgs e)
        {
            LoadStaffList();

        }


        // Nút tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
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
        // Keydown trong tìm kiếm
        private void txtTenNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick(); // Giả lập việc nhấn nút tìm
            }
        }

        // Xóa nhân viên
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
        // Sửa thông tin

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                string maNV = dgvStaff.SelectedRows[0].Cells["MaNV"].Value.ToString();


                // Kiểm tra các trường dữ liệu
                if (string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                    string.IsNullOrWhiteSpace(txtSDT.Text) ||
                    string.IsNullOrWhiteSpace(txtGioiTinh.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi chỉnh sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var employee = new NHANVIEN_DTO
                {
                    MaNV = maNV,
                    TenNV = txtTenNV.Text,
                    NgaySinh = dtpNgaySinh.Value,
                    SDT = txtSDT.Text,
                    GioiTinh = txtGioiTinh.Text

                };

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
                txtGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();

            }

        }
        #endregion

    }
}



