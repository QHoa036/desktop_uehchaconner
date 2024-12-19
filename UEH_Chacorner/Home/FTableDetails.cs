using System;
using System.Windows.Forms;

using BLL;
using DTO;

namespace UEH_Chacorner.Home
{
    public partial class FTableDetails : Form
    {
        private Panel _panel;

        private readonly SANPHAM_BLL _sanPhamBll = new SANPHAM_BLL();
        private readonly HOADON_BLL _hoadonBll = new HOADON_BLL();
        private readonly CTHD_BLL _cthdBll = new CTHD_BLL();

        private readonly int _maBan;
        private readonly int _maHD;
        private readonly string _maNV;

        public FTableDetails(int maBan, int maHD, string maNV, Panel panel)
        {
            InitializeComponent();

            // Gán giá trị từ Form Table
            _maBan = maBan;
            _maNV = maNV;
            _maHD = maHD;
            _panel = panel;
        }
        private void LoadDataGrid_SanPham()
        {
            bindingSourceSanPham.DataSource = _sanPhamBll.Load_SanPham();
            dgvSanPham.DataSource = bindingSourceSanPham;
        }

        private void EditDataGrid_SanPham()
        {
            dgvSanPham.ReadOnly = true;
            dgvSanPham.Columns[0].HeaderText = @"Mã sản phẩm";
            dgvSanPham.Columns[1].HeaderText = @"Mã DMSP";
            dgvSanPham.Columns[2].HeaderText = @"Tên DMSP";
            dgvSanPham.Columns[3].HeaderText = @"Tên sản phẩm";
            dgvSanPham.Columns[4].HeaderText = @"Đơn giá";
            dgvSanPham.Columns[4].DefaultCellStyle.Format = "N0";
            dgvSanPham.Columns[5].Visible = false;
        }

        private void LoadDataGrid_CTHD()
        {
            // Tạo DTO với Mã Hóa Đơn hiện tại
            var cthdDto = new CTHD_DTO { MaHD = Convert.ToInt32(txtMaHD.Text) };

            // Lấy dữ liệu CTHD mới từ BLL
            bindingSourceCTHD.DataSource = _cthdBll.load_cthd(cthdDto);

            // Gán dữ liệu vào DataGridView
            dgvCTHD.DataSource = bindingSourceCTHD;

            // Tính tổng tiền
            TinhTongTien();
        }

        private void EditDataGrid_CTHD()
        {
            dgvCTHD.ReadOnly = true;
            dgvCTHD.Columns[0].HeaderText = @"Mã CTHD";
            dgvCTHD.Columns[1].HeaderText = @"Mã sản phẩm";
            dgvCTHD.Columns[2].HeaderText = @"Tên sản phẩm";
            dgvCTHD.Columns[3].HeaderText = @"Số lượng";
            dgvCTHD.Columns[4].HeaderText = @"Đơn giá";
            dgvCTHD.Columns[4].DefaultCellStyle.Format = "N0";
            dgvCTHD.Columns[5].HeaderText = @"Thành tiền";
            dgvCTHD.Columns[5].DefaultCellStyle.Format = "N0";
        }

        private void TinhTongTien()
        {
            decimal TongTien = 0;

            foreach (DataGridViewRow row in dgvCTHD.Rows)
            {

                // Lấy giá trị thành tiền từ cột "Thành tiền"
                decimal ThanhTien = Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                TongTien += ThanhTien;

            }

            // Cập nhật tổng thành tiền vào TextBox
            txtThanhTien.Text = TongTien.ToString("N0") + "đ";  // Định dạng số và thêm "đ" vào cuối
        }

        private void ThanhToan()
        {
            if (dgvCTHD.Rows.Count == 0)
            {
                MessageBox.Show("Hóa đơn chưa có sản phẩm.", "Lỗi");
                return;
            }

            // Tạo đối tượng
            var hd_thanhtoan = new HOADON_DTO
            {
                MaHD = Convert.ToInt32(txtMaHD.Text),
                MaBan = _maBan,
                MaNV = _maNV,
                NgayLap = DateTime.Now,
                TrangThai = "Đã Thanh Toán"
            };

            // Gọi phương thức cập nhật
            int result = _hoadonBll.update_hoadon(hd_thanhtoan);
            if (result > 0)
            {
                MessageBox.Show("Thanh toán thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTrangThai.Text = "Đã Thanh Toán";
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void FTableDetails_Load(object sender, EventArgs e)
        {
            // Hiển thị mã hóa đơn trên Label
            lbTable.Text = $"Thực đơn Bàn {_maBan}";
            txtMaHD.Text = _maHD.ToString();

            LoadDataGrid_SanPham();
            if (dgvSanPham.Rows.Count > 0)
            {
                EditDataGrid_SanPham();
                txtMaSP.Text = dgvSanPham.SelectedRows[0].Cells["MaSP"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Thực đơn không có sản phẩm nào.");
            }

            LoadDataGrid_CTHD();
            EditDataGrid_CTHD();

        }

        private void ThemMon()
        {
            // Kiểm tra trạng thái hóa đơn
            if (txtTrangThai.Text == "Đã Thanh Toán")
            {
                MessageBox.Show("Hóa đơn đã được thanh toán. Không thể cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtMaSP.Text == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi");
                return;
            }

            var newCTHD = new CTHD_DTO
            {
                MaHD = Convert.ToInt32(txtMaHD.Text),
                MaSP = Convert.ToInt32(txtMaSP.Text),
                SoLuong = (int)numSoLuong.Value
            };

            // Thêm CTHD
            int insert_cthd = _cthdBll.insert_cthd(newCTHD);

            if (insert_cthd > 0)
            {
                MessageBox.Show("Thêm món vào hóa đơn thành công.");

                // Load lại danh sách CTHD sau khi thêm món
                LoadDataGrid_CTHD();  // Đảm bảo dữ liệu trong dgvCTHD được cập nhật
            }
            else
            {
                MessageBox.Show("Thêm món vào hóa đơn thất bại.", "Lỗi");
            }
            LoadDataGrid_CTHD();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng hiện tại
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

                // Hiển thị thông tin vào các textbox
                txtMaSP.Text = row.Cells["MaSP"].Value.ToString();
            }
        }
        
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                
                if (numSoLuong.Value <= 0)
                {
                    MessageBox.Show("Số lượng không hợp lệ.", "Lỗi");
                    return;
                }
                ThemMon();
                LoadDataGrid_CTHD();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi");
            }
        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái hóa đơn
            if (txtTrangThai.Text == "Đã Thanh Toán")
            {
                MessageBox.Show("Hóa đơn đã được thanh toán. Không thể cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvCTHD.SelectedRows.Count > 0)
            {
                // Lấy mã CTHD và Mã SP
                int MaCTHD = Convert.ToInt32(dgvCTHD.SelectedRows[0].Cells["MaCTHD"].Value);
                int MaSP = Convert.ToInt32(dgvCTHD.SelectedRows[0].Cells["MaSP"].Value);

                // Lấy dữ liệu trên form
                int SoLuong = (int)numSoLuong.Value;

                // Lấy thông tin hiện tại của bàn từ DataGridView
                int oldTSoLuong = Convert.ToInt32(dgvCTHD.SelectedRows[0].Cells["SoLuong"].Value);

                // So sánh thông tin cũ và mới
                if (oldTSoLuong == SoLuong)
                {
                    MessageBox.Show("Bạn chưa thay đổi số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Kiểm tra các trường dữ liệu
                if (SoLuong <= 0)
                {
                    MessageBox.Show("Số lượng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng
                var cthd = new CTHD_DTO
                {
                    MaCTHD = MaCTHD,
                    MaHD = Convert.ToInt32(txtMaHD.Text),
                    MaSP = MaSP,
                    SoLuong = SoLuong
                };

                // Gọi phương thức cập nhật
                int result = _cthdBll.update_cthd(cthd);
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật số lượng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid_CTHD();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật số lượng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chọn sản phẩm cần cập nhật số lượng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadDataGrid_CTHD();
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCTHD.Rows[e.RowIndex];
                // Hiển thị thông tin vào các textbox
                numSoLuong.Value = Convert.ToInt32(row.Cells["SoLuong"].Value);
            }
            numSoLuong.Focus();
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (dgvCTHD.SelectedRows.Count > 0)
            {
                // Lấy mã CTHD và Mã SP
                int MaCTHD = Convert.ToInt32(dgvCTHD.SelectedRows[0].Cells["MaCTHD"].Value);
                int MaSP = Convert.ToInt32(dgvCTHD.SelectedRows[0].Cells["MaSP"].Value);

                // Lấy dữ liệu trên form
                int SoLuong = (int)numSoLuong.Value;

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa món này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    // Tạo đối tượng
                    var cthd = new CTHD_DTO
                    {
                        MaCTHD = MaCTHD,
                        MaHD = Convert.ToInt32(txtMaHD.Text),
                        MaSP = MaSP,
                        SoLuong = SoLuong
                    };

                    // Xóa CTHD
                    int result = _cthdBll.delete_cthd(cthd);

                    if (result > 0)
                    {
                        MessageBox.Show("Món đã được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataGrid_CTHD();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa món.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn món cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            _panel.SendToBack();
            _panel.Controls.Clear();
        }
    }
}
