using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private readonly NHANVIEN_BLL _nhanvienBll = new NHANVIEN_BLL();
        private readonly TAIKHOAN_BLL _taikhoanBll = new TAIKHOAN_BLL();

        private DataTable _staffData;

        public FManageStaff()
        {
            InitializeComponent();
        }

        private void FManageStaff_Load(object sender, EventArgs e)
        {
            LoadStaffList();
            // Adding values to the ComboBox
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");

        }
        // Method to load the staff list into DataGridView
        private void LoadStaffList()
        {
            _staffData = _nhanvienBll.load_nhanvien(); // Get staff data from the BLL
            dgvStaff.DataSource = _staffData; // Set data source for DataGridView

            // Hide unwanted columns
            dgvStaff.Columns["MaNV"].Visible = true;
            dgvStaff.Columns["TenNV"].Visible = true;
            dgvStaff.Columns["NgaySinh"].Visible = true;
            dgvStaff.Columns["SDT"].Visible = true;
            dgvStaff.Columns["GioiTinh"].Visible = true;
            dgvStaff.Columns["TenTK"].Visible = true;

            // Hide other columns if they exist
            if (dgvStaff.Columns.Contains("MatKhau"))
                dgvStaff.Columns["MatKhau"].Visible = false;

            //if (dgvStaff.Columns.Contains("TenTK"))
            //    dgvStaff.Columns["TenTK"].Visible = false;

            if (dgvStaff.Columns.Contains("Quyen"))
                dgvStaff.Columns["Quyen"].Visible = false;
        }
        #region Event
        // Method to handle the search functionality
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                DataTable searchResults = _nhanvienBll.Tim_nv(new NHANVIEN_DTO { TenNV = searchTerm });
                dgvStaff.DataSource = searchResults;
            }
            else
            {
                LoadStaffList();
            }

        }
        // Method to handle deleting an employee
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                string maNV = dgvStaff.SelectedRows[0].Cells["MaNV"].Value.ToString();
                var employee = new NHANVIEN_DTO { MaNV = maNV };
                var account = new TAIKHOAN_DTO { MaNV = maNV };

                // First, delete the related account in TaiKhoan
                int result2 = _taikhoanBll.delete_taikhoan(account);

                // Then, delete the employee record in NhanVien
                int result1 = _nhanvienBll.delete_nhanvien(employee);

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
        // Method to handle editing employee details

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                string maNV = dgvStaff.SelectedRows[0].Cells["MaNV"].Value.ToString();

                // Kiểm tra các trường dữ liệu
                if (string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                    string.IsNullOrWhiteSpace(txtSDT.Text) ||
                    cmbGioiTinh.SelectedItem == null)
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
                    GioiTinh = cmbGioiTinh.SelectedItem.ToString()
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

        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStaff.Rows[e.RowIndex];
                txtTenNV.Text = row.Cells["MaNV"].Value.ToString();
                txtTenNV.Text = row.Cells["TenNV"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                cmbGioiTinh.SelectedItem = row.Cells["GioiTinh"].Value.ToString();
            }

        }
        #endregion

    }
}


