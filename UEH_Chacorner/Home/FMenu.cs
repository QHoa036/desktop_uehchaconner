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
            dgvsanpham.DataSource = _productData;

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

        }
        // Tìm sp
        private void SearchProduct()
        {
            string searchTerm = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                DataTable searchResults = _sanphamBll.Tim_SanPham(new SANPHAM_DTO { TenSanPham = searchTerm });
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

                int result = _sanphamBll.Delete_SanPham(product);

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
    }
    #endregion
}

