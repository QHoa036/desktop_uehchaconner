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
            LoadComboBoxMaDMSP();
            _productData = _sanphamBll.Load_SanPham();

            // Tạo DataView để lọc sản phẩm có TrangThai = 1
            DataView activeproduct = _productData.DefaultView;
            activeproduct.RowFilter = "TrangThai = 1";

            // Sắp xếp theo MaDMSP (thứ tự tăng dần)
            activeproduct.Sort = "MaDMSP ASC";

            // Cập nhật DataSource cho DataGridView
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
        private void LoadComboBoxMaDMSP()
        {
            cbbMaDMSP.Items.Clear();
            for (int i = 1; i <= 8; i++)
            {
                cbbMaDMSP.Items.Add(i);
            }
        }
        public bool KiemTraTenSanPhamExist(string tenSanPham, int maSP)
        {
            DataTable dtSanPham = _sanphamBll.Load_SanPham(); 
            // Kiểm tra tên sản phẩm trùng
            foreach (DataRow row in dtSanPham.Rows)
            {
                string tenSanPhamRow = row["TenSanPham"].ToString().Trim();
                int maSPRow = Convert.ToInt32(row["MaSP"].ToString().Trim());

                if (tenSanPhamRow == tenSanPham.Trim() && maSPRow != maSP)
                {
                    return true; 
                }
            }
            return false; 
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
                string donGiaInput = txtgia.Text.Trim();
                string newTenSanPham = txttensp.Text.Trim();
                int newMaDMSP = Convert.ToInt32(cbbMaDMSP.SelectedItem.ToString());

                // Kiểm tra nếu các ô nhập liệu trống
                if (string.IsNullOrWhiteSpace(donGiaInput) || string.IsNullOrWhiteSpace(newTenSanPham) || cbbMaDMSP.SelectedItem == null)
                {
                    MessageBox.Show("Bạn chưa chọn sản phẩm cần sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra nếu Đơn Giá không phải số hoặc <= 0
                if (!float.TryParse(donGiaInput, out float newDonGia) || newDonGia <= 0)
                {
                    MessageBox.Show("Đơn giá phải là số dương hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                // Kiểm tra tên sản phẩm đã tồn tại trong cơ sở dữ liệu
                bool isTenSanPhamExist = KiemTraTenSanPhamExist(newTenSanPham, maSP);
                if (isTenSanPhamExist)
                {
                    MessageBox.Show("Tên sản phẩm này đã tồn tại. Vui lòng chọn tên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        // Cell Click
        private void dgvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvsanpham.SelectedRows.Count > 0)
            {
                // Lấy chỉ số dòng được chọn
                int index = dgvsanpham.CurrentRow.Index;

                // Lấy giá trị MaDMSP từ dòng được chọn
                string maDMSP = dgvsanpham.Rows[index].Cells["MaDMSP"].Value.ToString();

                // Kiểm tra nếu MaDMSP có trong ComboBox
                if (int.TryParse(maDMSP, out int maDMSPValue) && maDMSPValue >= 1 && maDMSPValue <= 8)
                {
                    // Chọn giá trị MaDMSP trong ComboBox
                    cbbMaDMSP.SelectedIndex = maDMSPValue - 1; // Điều chỉnh chỉ mục ComboBox từ 0 đến 7
                }
                else
                {
                    cbbMaDMSP.SelectedIndex = -1; // Không có giá trị hợp lệ
                }

                // Cập nhật các thông tin khác
                txttensp.Text = dgvsanpham.Rows[index].Cells["TenSanPham"].Value.ToString();
                txtgia.Text = dgvsanpham.Rows[index].Cells["DonGia"].Value.ToString();
            }
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
            // Kiểm tra trống
            if (string.IsNullOrWhiteSpace(txttensp.Text) || string.IsNullOrWhiteSpace(txtgia.Text) || cbbMaDMSP.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newTenSanPham = txttensp.Text.Trim();           
            // Kiểm tra tên sản phẩm đã tồn tại trong cơ sở dữ liệu
            bool isTenSanPhamExist = KiemTraTenSanPhamExist(newTenSanPham, 0); 
            if (isTenSanPhamExist)
            {
                MessageBox.Show("Tên sản phẩm này đã tồn tại. Vui lòng chọn tên khác cho sản phẩm mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra Đơn giá phải là số và lớn hơn 0
            float donGia;
            if (!float.TryParse(txtgia.Text.Trim(), out donGia) || donGia <= 0)
            {
                MessageBox.Show("Đơn giá phải là số và lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maDMSP = Convert.ToInt32(cbbMaDMSP.SelectedItem.ToString());          

            var sanPham = new SANPHAM_DTO
            {
                TenSanPham = txttensp.Text.Trim(),
                DonGia = donGia,
                MaDMSP = maDMSP
            };

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

