using System;
using System.Data;
using System.Windows.Forms;

using BLL;
using DTO;

namespace UEH_ChaCorner.Home
{
    public partial class FCategory : Form
    {
        private readonly DANHMUCSANPHAM_BLL _danhMucBll = new DANHMUCSANPHAM_BLL();
        private DataTable _categoryData;

        public FCategory()
        {
            InitializeComponent();
        }

        private void LoadCategoryList()
        {
            _categoryData = _danhMucBll.Load_DanhMucSanPham();

            // Tạo DataView để lọc sản phẩm có TrangThai = 1
            DataView activeproduct = _categoryData.DefaultView;

            // Sắp xếp theo MaDMSP (thứ tự tăng dần)
            activeproduct.Sort = "MaDMSP ASC";

            // Cập nhật DataSource cho DataGridView
            dgvsanpham.DataSource = activeproduct.ToTable();

            if (dgvsanpham.Columns.Contains("MaDMSP"))
                dgvsanpham.Columns["MaDMSP"].HeaderText = @"Mã danh mục";

            if (dgvsanpham.Columns.Contains("TenDMSP"))
                dgvsanpham.Columns["TenDMSP"].HeaderText = @"Tên danh mục";
        }

        public bool KiemTraTenSanPhamExist(string tenSanPham, int maSP)
        {
            DataTable dtSanPham = _danhMucBll.Load_DanhMucSanPham();
            // Kiểm tra tên sản phẩm trùng
            foreach (DataRow row in dtSanPham.Rows)
            {
                string tenSanPhamRow = row["TenDMSP"].ToString().Trim();
                int maSPRow = Convert.ToInt32(row["MaDMSP"].ToString().Trim());

                if (tenSanPhamRow == tenSanPham.Trim() && maSPRow != maSP)
                {
                    return true;
                }
            }
            return false;
        }

        private void FCategory_Load(object sender, EventArgs e)
        {
            LoadCategoryList();
        }

        private void dgvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvsanpham.SelectedRows.Count > 0)
            {
                // Lấy chỉ số dòng được chọn
                int index = dgvsanpham.CurrentRow.Index;

                // Lấy giá trị MaDMSP từ dòng được chọn
                string maDMSP = dgvsanpham.Rows[index].Cells["MaDMSP"].Value.ToString();

                // Cập nhật các thông tin khác
                txttensp.Text = dgvsanpham.Rows[index].Cells["TenDMSP"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra trống
            if (string.IsNullOrWhiteSpace(txttensp.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newTenSanPham = txttensp.Text.Trim();

            // Kiểm tra tên sản phẩm đã tồn tại trong cơ sở dữ liệu
            bool isTenSanPhamExist = KiemTraTenSanPhamExist(newTenSanPham, 0);
            if (isTenSanPhamExist)
            {
                MessageBox.Show("Tên danh mục sản phẩm này đã tồn tại. Vui lòng chọn tên khác cho sản phẩm mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sanPham = new DANHMUCSANPHAM_DTO
            {
                TenDMSP = txttensp.Text.Trim(),
            };

            int result = _danhMucBll.Insert_DanhMucSanPham(sanPham);
            if (result > 0)
            {
                MessageBox.Show("Danh mục sản phẩm đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategoryList(); // Refresh danh sách sản phẩm
            }
            else
            {
                MessageBox.Show("Thêm danh mục sản phẩm thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dgvsanpham.SelectedRows.Count > 0)
            {
                // Lấy thông tin sản phẩm từ DataGridView
                int oldMaDMSP = Convert.ToInt32(dgvsanpham.SelectedRows[0].Cells["MaDMSP"].Value);
                string oldTenSanPham = dgvsanpham.SelectedRows[0].Cells["TenDMSP"].Value.ToString().Trim();

                // Lấy thông tin mới từ các ô nhập liệu
                string newTenSanPham = txttensp.Text.Trim();

                // Kiểm tra nếu các ô nhập liệu trống
                if ( string.IsNullOrWhiteSpace(newTenSanPham))
                {
                    MessageBox.Show("Bạn chưa chọn danh mục sản phẩm cần sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra tên sản phẩm đã tồn tại trong cơ sở dữ liệu
                bool isTenSanPhamExist = KiemTraTenSanPhamExist(newTenSanPham, oldMaDMSP);
                if (isTenSanPhamExist)
                {
                    MessageBox.Show("Tên danh mục sản phẩm này đã tồn tại. Vui lòng chọn tên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng sản phẩm
                var product = new DANHMUCSANPHAM_DTO
                {
                    MaDMSP = oldMaDMSP,
                    TenDMSP = newTenSanPham
                };

                // Gọi phương thức cập nhật
                int result = _danhMucBll.Update_DanhMucSanPham(product);
                if (result > 0)
                {
                    MessageBox.Show("Thông tin danh mục sản phẩm đã được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategoryList(); // Refresh danh sách sản phẩm
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin danh mục sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chọn danh mục sản phẩm cần chỉnh sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvsanpham.SelectedRows.Count > 0)
                {
                    int MaDMSP = Convert.ToInt32(dgvsanpham.SelectedRows[0].Cells["MaDMSP"].Value);
                    var product = new DANHMUCSANPHAM_DTO { MaDMSP = MaDMSP };

                    int result = _danhMucBll.Delete_DanhMucSanPham(product);

                    if (result > 0)
                    {
                        MessageBox.Show("Danh mục sản phẩm đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCategoryList();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa danh mục sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một danh mục sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa danh mục sản phẩm (Do lỗi khóa ngoại với bảng SanPham).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
