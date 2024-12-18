using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace UEH_Chacorner.Home
{
    public partial class FTable : Form
    {
        // Khai báo các đối tượng BLL 
        private readonly BAN_BLL _banBll = new BAN_BLL();
        private readonly HOADON_BLL _hoadonBll = new HOADON_BLL();
        private string _maNV = "00579";

        public FTable()
        {
            InitializeComponent();
        }

        private void LoadDataGrid_Ban()
        {
            bindingSourceBan.DataSource = _banBll.load_ban();
            dgvBan.DataSource = bindingSourceBan;
        }

        private void LoadDataGrid_BanTrong()
        {
            bindingSourceBan.DataSource = _banBll.load_ban_trong();
            dgvBan.DataSource = bindingSourceBan;
        }
        private void LoadDataGrid_BanCoNguoi()
        {
            bindingSourceBan.DataSource = _banBll.load_ban_conguoi();
            dgvBan.DataSource = bindingSourceBan;
        }

        private void EditDataGrid_Ban()
        {
            dgvBan.ReadOnly = true;
            dgvBan.Columns[0].HeaderText = @"Mã bàn";
            dgvBan.Columns[1].HeaderText = @"Tên bàn";
            dgvBan.Columns[2].HeaderText = @"Trạng thái";
            dgvBan.Columns[3].HeaderText = @"Thứ tự";
            dgvBan.Columns[4].Visible = false;
        }

        private void FTable_Load(object sender, EventArgs e)
        {
            // Thêm các giá trị vào ComboBox
            cbbTrangThai.Items.Clear();
            cbbTrangThai.Items.Add("Trống");
            cbbTrangThai.Items.Add("Có người");
            cbbTrangThai.SelectedItem = "Trống";

            LoadDataGrid_Ban();
            if (dgvBan.Rows.Count > 0)
            {
                EditDataGrid_Ban();
            }
            else
            {
                MessageBox.Show("Không có bàn nào.");
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            // Kiểm tra đầu vào
            if (string.IsNullOrWhiteSpace(txtTenBan.Text) ||
                string.IsNullOrWhiteSpace(cbbTrangThai.Text) ||
                numThuTu.Value <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm bàn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra tên bàn đã tồn tại chưa
            bool TenBanTonTai = false;

            foreach (DataGridViewRow row in dgvBan.Rows)
            {
                if (row.Cells["Ten"].Value != null && row.Cells["Ten"].Value.ToString() == txtTenBan.Text.Trim())
                {
                    TenBanTonTai = true;
                    break;
                }
            }

            if (TenBanTonTai)
            {
                MessageBox.Show("Tên bàn đã tồn tại. Vui lòng nhập tên bàn khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu từ input
            var newTable = new BAN_DTO
            {
                Ten = txtTenBan.Text,
                TrangThai = cbbTrangThai.SelectedItem.ToString(),
                ThuTu = (int)numThuTu.Value
            };

            // Thêm bàn vào DB
            int result = _banBll.insert_ban(newTable);

            if (result > 0)
            {
                MessageBox.Show("Thêm bàn thành công.", "Thông báo");
                LoadDataGrid_Ban(); // Reload danh sách bàn
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại.", "Lỗi");
            }
        }

        // Xóa bàn
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBan.SelectedRows.Count > 0)
            {
                int maban = Convert.ToInt32(dgvBan.SelectedRows[0].Cells["MaBan"].Value);
                var ban = new BAN_DTO { MaBan = maban };

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bàn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    // Xóa bàn trong bảng Ban
                    int result = _banBll.delete_ban_daxoa(ban);

                    if (result > 0)
                    {
                        MessageBox.Show("Bàn đã được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataGrid_Ban();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa bàn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn bàn cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Sửa thông tin bàn
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBan.SelectedRows.Count > 0)
            {
                // Lấy mã bàn được chọn
                int maBan = Convert.ToInt32(dgvBan.SelectedRows[0].Cells["MaBan"].Value);

                // Lấy dữ liệu trên form
                string TenBan = txtTenBan.Text;
                string TrangThai = cbbTrangThai.SelectedItem.ToString();
                cbbTrangThai.SelectedItem.ToString();
                int ThuTu = (int)numThuTu.Value;

                // Lấy thông tin hiện tại của bàn từ DataGridView
                string oldTenBan = dgvBan.SelectedRows[0].Cells["Ten"].Value.ToString().Trim();
                string oldTrangThai = dgvBan.SelectedRows[0].Cells["TrangThai"].Value.ToString().Trim();
                int oldThuTu = Convert.ToInt32(dgvBan.SelectedRows[0].Cells["ThuTu"].Value);

                // So sánh thông tin cũ và mới
                if (oldTenBan == TenBan &&
                    oldTrangThai == TrangThai &&
                    oldThuTu == ThuTu)
                {
                    MessageBox.Show("Bạn chưa thay đổi thông tin gì.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Kiểm tra các trường dữ liệu
                if (string.IsNullOrWhiteSpace(txtTenBan.Text) ||
                    string.IsNullOrWhiteSpace(cbbTrangThai.SelectedItem.ToString()))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi chỉnh sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng nhân viên
                var table = new BAN_DTO
                {
                    MaBan = maBan,
                    Ten = txtTenBan.Text,
                    TrangThai = cbbTrangThai.SelectedItem.ToString(),
                    ThuTu = (int)numThuTu.Value
                };

                // Gọi phương thức cập nhật
                int result = _banBll.update_ban(table);
                if (result > 0)
                {
                    MessageBox.Show("Thông tin bàn đã được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid_Ban();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin bàn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chọn bàn cần chỉnh sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadDataGrid_Ban();

        }

        private void btnTrong_Click(object sender, EventArgs e)
        {
            LoadDataGrid_BanTrong();
            if (dgvBan.Rows.Count > 0)
            {
                EditDataGrid_Ban();
            }
            else
            {
                MessageBox.Show("Không có bàn trống nào.");
            }
        }

        private void btnCoNguoi_Click(object sender, EventArgs e)
        {
            LoadDataGrid_BanCoNguoi();
            if (dgvBan.Rows.Count > 0)
            {
                EditDataGrid_Ban();
            }
            else
            {
                MessageBox.Show("Không có bàn có người nào.");
            }
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            LoadDataGrid_Ban();
            if (dgvBan.Rows.Count > 0)
            {
                EditDataGrid_Ban();
            }
            else
            {
                MessageBox.Show("Không có bàn nào.");
            }
        }

        private void dgvBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBan.Rows[e.RowIndex];
                // Hiển thị thông tin vào các textbox
                txtTenBan.Text = row.Cells["Ten"].Value.ToString();
                numThuTu.Value = Convert.ToInt32(row.Cells["ThuTu"].Value);
                // Đặt giá trị trạng thái cho ComboBox từ cột "TrangThai" trong DataGridView
                string TrangThai = row.Cells["TrangThai"].Value.ToString();

                // Kiểm tra và chọn trạng thái trong ComboBox
                if (TrangThai.Equals("Trống", StringComparison.OrdinalIgnoreCase))
                {
                    cbbTrangThai.SelectedItem = "Trống";  // Chọn "Trống"
                }
                else if (TrangThai.Equals("Có người", StringComparison.OrdinalIgnoreCase))
                {
                    cbbTrangThai.SelectedItem = "Có người";  // Chọn "Có người"
                }
                else
                {
                    cbbTrangThai.SelectedIndex = -1;  // Nếu không khớp, bỏ chọn
                }
            }
            txtTenBan.Focus();

        }

        private void btnTableDetails_Click(object sender, EventArgs e)
        {
            
            // Kiểm tra xem tên bàn có hợp lệ không
            if (dgvBan.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn bàn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maBan = Convert.ToInt32(dgvBan.CurrentRow.Cells["MaBan"].Value);

            // Lấy dữ liệu
            var newHoaDon = new HOADON_DTO
            {
                MaBan = maBan,
                MaNV = _maNV,
                NgayLap = DateTime.Now,
                TrangThai = "Chưa Thanh Toán"
            };

            // Thêm hóa đơn
            int insert_hoadon = _hoadonBll.insert_hoadon(newHoaDon);

            if (insert_hoadon > 0)
            {
                // Lấy mã hóa đơn vừa tạo
                int maHD = _hoadonBll.load_hoadon_new(newHoaDon);
                if (maHD > 0)
                {
                    FTableDetails fTableDetails = new FTableDetails(maBan, maHD);
                    fTableDetails.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã hóa đơn vừa tạo.", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Thêm hóa đơn thất bại.", "Lỗi");
            }
        }

        private void dgvBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem tên bàn có hợp lệ không
            if (dgvBan.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn bàn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maBan = Convert.ToInt32(dgvBan.CurrentRow.Cells["MaBan"].Value);

            // Lấy dữ liệu
            var newHoaDon = new HOADON_DTO
            {
                MaBan = maBan,
                MaNV = _maNV,
                NgayLap = DateTime.Now,
                TrangThai = "Chưa Thanh Toán"
            };

            // Thêm hóa đơn
            int insert_hoadon = _hoadonBll.insert_hoadon(newHoaDon);

            if (insert_hoadon > 0)
            {
                // Lấy mã hóa đơn vừa tạo
                int maHD = _hoadonBll.load_hoadon_new(newHoaDon);
                if (maHD > 0)
                {
                    FTableDetails fTableDetails = new FTableDetails(maBan, maHD);
                    fTableDetails.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã hóa đơn vừa tạo.", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Thêm hóa đơn thất bại.", "Lỗi");
            }
        }
    }
}