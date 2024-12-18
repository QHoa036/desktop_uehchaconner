using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UEH_ChaCorner.Home
{
    public partial class FMenu : Form
    {
        private readonly SANPHAM_BLL _sanphamBll = new SANPHAM_BLL();
        private readonly DANHMUCSANPHAM_BLL _danhMucBll = new DANHMUCSANPHAM_BLL();
        private DataTable _productData;
        public FMenu()
        {
            InitializeComponent();
        }
        #region Method
        private void LoadProductList()
        {
            _productData = _sanphamBll.Load_SanPham();          
            DataView activeproduct = _productData.DefaultView;
            activeproduct.RowFilter = "TrangThai = 1";
            dgvsanpham.DataSource = activeproduct.ToTable();

            if (dgvsanpham.Columns.Contains("MaSP"))
                dgvsanpham.Columns["MaSP"].HeaderText = @"Mã sản phẩm";

            if (dgvsanpham.Columns.Contains("TenSanPham"))
                dgvsanpham.Columns["TenSanPham"].HeaderText = @"Tên sản phẩm";

            if (dgvsanpham.Columns.Contains("DonGia"))
                dgvsanpham.Columns["DonGia"].HeaderText = @"Giá";

            if (dgvsanpham.Columns.Contains("TenDMSP"))
                dgvsanpham.Columns["TenDMSP"].HeaderText = @" Tên Danh mục";

            if (dgvsanpham.Columns.Contains("MaDMSP"))
                dgvsanpham.Columns["MaDMSP"].HeaderText = @" Mã Danh mục";

            if (dgvsanpham.Columns.Contains("TrangThai"))
                dgvsanpham.Columns["TrangThai"].Visible = false;

        }
        // Tìm sp
        private void SearchProduct()
        {
            string searchTerm = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                DataTable searchResults = _sanphamBll.TIM_TenSanPham_active(new SANPHAM_DTO { TenSanPham = searchTerm });
                dgvsanpham.DataSource = searchResults;
            }
            else
            {
                LoadProductList();
            }
      
}
        private void DeleteProduct()
        {
            if (dgvsanpham.SelectedRows.Count > 0)
            {
                int MaSP = Convert.ToInt32(dgvsanpham.SelectedRows[0].Cells["MaSP"].Value);
                var product = new SANPHAM_DTO { MaSP = MaSP };

                int result = _sanphamBll.DELETE_SanPham_TrangThai(product);

                if (result > 0)
                {
                    MessageBox.Show("Sản phẩm đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductList(); 
                }
                else
                {
                    MessageBox.Show("Không thể xóa sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Sửa sp
        private void EditProduct()
        {
            if (dgvsanpham.SelectedRows.Count > 0)
            {
                // Lấy thông tin sản phẩm từ DataGridView
                int maSP = Convert.ToInt32(dgvsanpham.SelectedRows[0].Cells["MaSP"].Value);
                int oldMaDMSP = Convert.ToInt32(dgvsanpham.SelectedRows[0].Cells["MaDMSP"].Value);
                string oldTenSanPham = dgvsanpham.SelectedRows[0].Cells["TenSanPham"].Value.ToString().Trim();
                float oldDonGia = float.Parse(dgvsanpham.SelectedRows[0].Cells["DonGia"].Value.ToString());

                // Lấy thông tin mới từ các ô nhập liệu
                string maDMSPInput = txtMaDMSP.Text.Trim();
                string donGiaInput = txtgia.Text.Trim();
                string newTenSanPham = txttensp.Text.Trim();

                // Kiểm tra nếu MaDMSP không phải số
                if (!int.TryParse(maDMSPInput, out int newMaDMSP))
                {
                    MessageBox.Show("Mã danh mục sản phẩm phải là số nguyên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra nếu Đơn Giá không phải số hoặc <= 0
                if (!float.TryParse(donGiaInput, out float newDonGia) || newDonGia <= 0)
                {
                    MessageBox.Show("Đơn giá phải là số dương hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy danh sách các giá trị MaDMSP từ cột DataGridView
                var validMaDMSPList = new HashSet<int>();
                foreach (DataGridViewRow row in dgvsanpham.Rows)
                {
                    if (row.Cells["MaDMSP"].Value != null)
                    {
                        validMaDMSPList.Add(Convert.ToInt32(row.Cells["MaDMSP"].Value));
                    }
                }

                // Kiểm tra nếu MaDMSP mới không nằm trong danh sách hợp lệ
                if (!validMaDMSPList.Contains(newMaDMSP))
                {
                    MessageBox.Show($"Mã danh mục sản phẩm không hợp lệ. Chỉ được chọn các giá trị sau: {string.Join(", ", validMaDMSPList)}.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra nếu không có sự thay đổi nào
                if (oldMaDMSP == newMaDMSP &&
                    oldTenSanPham == newTenSanPham &&
                    oldDonGia == newDonGia)
                {
                    MessageBox.Show("Bạn chưa thay đổi thông tin gì.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Kiểm tra các trường dữ liệu khác
                if (string.IsNullOrWhiteSpace(newTenSanPham))
                {
                    MessageBox.Show("Tên sản phẩm không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng sản phẩm
                var product = new SANPHAM_DTO
                {
                    MaSP = maSP,
                    MaDMSP = newMaDMSP,
                    TenSanPham = newTenSanPham,
                    DonGia = newDonGia
                };

                // Gọi phương thức cập nhật
                int result = _sanphamBll.Update_SanPham(product);
                if (result > 0)
                {
                    MessageBox.Show("Thông tin sản phẩm đã được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductList(); // Refresh danh sách sản phẩm
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chọn sản phẩm cần chỉnh sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        #endregion

        #region Event
        // Event Load form
        private void FMenu_Load(object sender, EventArgs e)
        {
            LoadProductList();
        }
        private void dgvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvsanpham.CurrentRow.Index;
            txtMaDMSP.Text = dgvsanpham.Rows[index].Cells[1].Value.ToString();
            txttensp.Text = dgvsanpham.Rows[index].Cells[3].Value.ToString();
            txtgia.Text = dgvsanpham.Rows[index].Cells[4].Value.ToString();
        }
        // Tìm 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchProduct();
        }

       
        // Xóa 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }
        // Thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var sanPham = new SANPHAM_DTO
            {
                TenSanPham = txttensp.Text.Trim(),
                DonGia = float.Parse(txtgia.Text.Trim()),
                MaDMSP = int.Parse(txtMaDMSP.Text.Trim())
            };

            // Gọi phương thức Insert_SanPham
            int result = _sanphamBll.Insert_SanPham(sanPham);

            if (result > 0)
            {
                MessageBox.Show("Sản phẩm đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProductList(); // Refresh danh sách sản phẩm
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditProduct();         
        }
    
    }
    #endregion
}

