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
    public partial class FTable : Form
    {
        // Khai báo các đối tượng BLL 
        private readonly BAN_BLL _banBll = new BAN_BLL();
        private readonly CTHD_BLL _cthdBll = new CTHD_BLL();
        private readonly SANPHAM_BLL _sanPhamBll = new SANPHAM_BLL();
        private DataTable _banData;

        public FTable()
        {
            InitializeComponent();
        }

        private void FTable_Load(object sender, EventArgs e)
        {
            // Thêm các giá trị vào ComboBox
            cbbTrangThai.Items.Clear();
            cbbTrangThai.Items.Add("Trống");
            cbbTrangThai.Items.Add("Có người");

            LoadTableList();
            LoadDanhMucSanPham();
        }
        // Tải danh mục sản phẩm vào cboDanhMucSanPham
        private void LoadDanhMucSanPham()
        {
            // Lấy danh sách danh mục sản phẩm từ database
            var danhMucSanPham = _sanPhamBll.LayDanhMucSanPham();

            // Hiển thị vào ComboBox
            cboDanhMucSanPham.DataSource = danhMucSanPham;
            cboDanhMucSanPham.DisplayMember = "TenDMSP";
            cboDanhMucSanPham.ValueMember = "MaDMSP";

            // Thêm lựa chọn "Tất cả" vào ComboBox
            cboDanhMucSanPham.Items.Insert(0, new { MaDMSP = -1, TenDMSP = "Tất cả" });
            cboDanhMucSanPham.SelectedIndex = 0;
        }
        private void LoadTableList()
        {
            _banData = _banBll.load_ban();
            dgvTable.DataSource = _banData;

            // Hiển thị các cột 
            dgvTable.Columns["MaBan"].Visible = true;
            dgvTable.Columns["Ten"].Visible = true;
            dgvTable.Columns["TrangThai"].Visible = true;
            dgvTable.Columns["ThuTu"].Visible = true;
           
        }

        // Nút tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                DataTable searchResults = _banBll.Tim_Ban(new BAN_DTO { Ten = searchTerm });
                dgvTable.DataSource = searchResults;
            }
            else
            {
                LoadTableList();
            }            
        }

        // Keydown trong tìm kiếm
        private void txtTenBan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick(); // Giả lập việc nhấn nút tìm
            }
        }

        // Xóa bàn
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTable.SelectedRows.Count > 0)
            {
                int maban = Convert.ToInt32(dgvTable.SelectedRows[0].Cells["MaBan"].Value);
                var ban = new BAN_DTO { MaBan = maban };

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bàn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    // Xóa bàn trong bảng Ban
                    int result = _banBll.delete_ban(ban);

                    if (result > 0)
                    {
                        MessageBox.Show("Bàn đã được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTableList();
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
            if (dgvTable.SelectedRows.Count > 0)
            {

                // Kiểm tra các trường dữ liệu
                if (string.IsNullOrWhiteSpace(txtTenBan.Text) ||
                    string.IsNullOrWhiteSpace(cbbTrangThai.Text) ||
                    numThuTu.Value <= 0) 
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi chỉnh sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy mã bàn được chọn
                int maBan = Convert.ToInt32(dgvTable.SelectedRows[0].Cells["MaBan"].Value);

                // Lấy dữ liệu từ các control trên form
                var ban = new BAN_DTO
                {
                    MaBan = maBan,
                    Ten = txtTenBan.Text,
                    TrangThai = cbbTrangThai.SelectedItem.ToString(),
                    ThuTu = (int)numThuTu.Value

                };

                // Cập nhật bàn
                int result = _banBll.update_ban(ban);
                if (result > 0)
                {
                    MessageBox.Show("Thông tin bàn đã được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTableList();
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

        }

        // CellClick DataGridView 
        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTable.Rows.Count)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dgvTable.Rows[e.RowIndex];

                // Nếu là dòng cuối cùng (dòng trống), làm trống các textbox để người dùng nhập thông tin mới
                if (row.IsNewRow) // Kiểm tra nếu đây là dòng mới chưa có dữ liệu
                {
                    txtTenBan.Clear(); // Làm trống Tên bàn
                    cbbTrangThai.SelectedIndex = -1; // Làm trống trạng thái
                    numThuTu.Value = 0; // Làm trống Thứ tự
                }
                else
                {
                    // Hiển thị thông tin vào các textbox
                    txtTenBan.Text = row.Cells["Ten"].Value.ToString();
                    numThuTu.Value = Convert.ToInt32(row.Cells["ThuTu"].Value);
                    // Đặt giá trị trạng thái cho ComboBox từ cột "TrangThai" trong DataGridView
                    string trangThai = row.Cells["TrangThai"].Value.ToString();

                    // Kiểm tra và chọn trạng thái trong ComboBox
                    if (trangThai.Equals("Trống", StringComparison.OrdinalIgnoreCase))
                    {
                        cbbTrangThai.SelectedItem = "Trống";  // Chọn "Trống"
                    }
                    else if (trangThai.Equals("Có người", StringComparison.OrdinalIgnoreCase))
                    {
                        cbbTrangThai.SelectedItem = "Có người";  // Chọn "Có người"
                    }
                    else
                    {
                        cbbTrangThai.SelectedIndex = -1;  // Nếu không khớp, bỏ chọn
                    }

                    try
                    {
                        // Lấy mã bàn được chọn
                        int maBan = Convert.ToInt32(row.Cells["MaBan"].Value);

                        // Lấy danh sách món ăn của bàn
                        List<SANPHAM_DTO> danhSachMon = _banBll.LayDanhSachMonTheoBan(maBan);

                        // Hiển thị danh sách món ăn lên DataGridView
                        dgvMonTrongBan.DataSource = danhSachMon;

                        // Tùy chỉnh cột DataGridView (nếu cần)
                        dgvMonTrongBan.Columns["MaDMSP"].Visible = false; // Ẩn cột mã danh mục

                        // Tạo form chuyển bàn và truyền tên bàn hiện tại
                        btnTransferTable.Click += (s, args) =>
                        {
                            FTransferTable transferForm = new FTransferTable(txtTenBan.Text); // Truyền tên bàn
                            transferForm.ShowDialog();
                        };
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi hiển thị danh sách món: {ex.Message}\n{ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Dòng được chọn không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                LoadTableList(); // Reload danh sách bàn
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại.", "Lỗi");
            }
        }
       
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng đã chọn bàn, sản phẩm và số lượng hợp lệ
            if (dgvTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn bàn để thêm món.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboSanPham.SelectedValue == null)
            {
                MessageBox.Show("Chọn sản phẩm để thêm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numSoLuong.Value <= 0)
            {
                MessageBox.Show("Nhập số lượng hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin bàn được chọn
            int maBan = Convert.ToInt32(dgvTable.SelectedRows[0].Cells["MaBan"].Value);

            // Lấy thông tin sản phẩm và số lượng
            int maSP = (int)cboSanPham.SelectedValue;
            int soLuong = (int)numSoLuong.Value;

            // Thêm món vào hóa đơn
            int result = _cthdBll.ThemMonVaoHoaDon(maBan, maSP, soLuong);

            // Cập nhật trạng thái bàn nếu bàn có trạng thái "Trống"
            if (result > 0)
            {
                // Cập nhật trạng thái bàn
                string trangThai = dgvTable.SelectedRows[0].Cells["TrangThai"].Value.ToString();
                if (trangThai == "Trống")
                {
                    // Cập nhật trạng thái bàn thành "Có người"
                    _banBll.CapNhatTrangThaiBan(maBan, "Có người");
                    MessageBox.Show("Thêm món thành công và trạng thái bàn đã được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm món thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Tải lại danh sách món trong bàn
                LoadMonTrongBan(maBan);
            }
            else
            {
                MessageBox.Show("Thêm món thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Hiển thị danh sách món trong bàn
        private void LoadMonTrongBan(int maBan)
        {
            var danhSachMon = _banBll.LayDanhSachMonTheoBan(maBan);
            dgvMonTrongBan.DataSource = danhSachMon;
        }
        private void btnTransferTable_Click(object sender, EventArgs e)
        {
            // Lấy tên bàn đã chọn từ TextBox
            string tenBan = txtTenBan.Text.Trim();

            // Kiểm tra xem tên bàn có hợp lệ không
            if (string.IsNullOrEmpty(tenBan))
            {
                MessageBox.Show("Vui lòng chọn bàn để chuyển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mở form FTransferTable và truyền tên bàn đã chọn
            FTransferTable transferForm = new FTransferTable(tenBan);
            transferForm.ShowDialog(); // Hiển thị form chuyển bàn
        }


        private void dgvMonTrongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cboDanhMucSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDanhMucSanPham.SelectedValue != null)
            {
                // Kiểm tra nếu SelectedValue có kiểu int
                if (cboDanhMucSanPham.SelectedValue is int maDMSP)
                {
                    // Nếu chọn "Tất cả", hiển thị tất cả sản phẩm
                    if (maDMSP == -1)
                    {
                        cboSanPham.DataSource = _sanPhamBll.LaySanPham();
                    }
                    else
                    {
                        // Lấy sản phẩm theo danh mục đã chọn
                        cboSanPham.DataSource = _sanPhamBll.LaySanPhamTheoDanhMuc(maDMSP);
                    }

                    cboSanPham.DisplayMember = "TenSanPham";
                    cboSanPham.ValueMember = "MaSP";
                }
                else
                {
                    MessageBox.Show("Giá trị không hợp lệ. Vui lòng chọn một danh mục sản phẩm hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}
