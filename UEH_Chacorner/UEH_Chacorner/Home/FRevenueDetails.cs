using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BLL;
using DTO;

namespace UEH_Chacorner.Home
{
    public partial class FRevenueDetails : Form
    {
        private readonly int _maHD;
        private readonly CTHD_BLL _cthdBll = new CTHD_BLL();
        private readonly HOADON_BLL _hoadonBll = new HOADON_BLL();

        public FRevenueDetails(int maHD)
        {
            InitializeComponent();
            _maHD = maHD;
            // Tạo đối tượng DTO
            CTHD_DTO cthdDto = new CTHD_DTO { MaHD = _maHD };

            // Truyền DTO vào phương thức
            bindingSourceCTHD.DataSource = _cthdBll.load_cthd(cthdDto);
        }

        #region Method

        private void LoadDataGrid()
        {
            dgvCTHD.DataSource = bindingSourceCTHD;
        }

        private void EditDataGrid()
        {
            dgvCTHD.ReadOnly = true;
            dgvCTHD.Columns[0].HeaderText = @"Mã CTHD";
            dgvCTHD.Columns[1].HeaderText = @"Tên sản phẩm";
            dgvCTHD.Columns[2].HeaderText = @"Số lượng";
            dgvCTHD.Columns[3].HeaderText = @"Đơn giá";
            dgvCTHD.Columns[3].DefaultCellStyle.Format = "N0";
            dgvCTHD.Columns[4].HeaderText = @"Thành tiền";
            dgvCTHD.Columns[4].DefaultCellStyle.Format = "N0";
        }

        #endregion

        #region Event

        private void FRevenueDetails_Load(object sender, EventArgs e)
        {
            // Hiển thị mã hóa đơn trên Label
            lblMaHD.Text = $"Mã hóa đơn: {_maHD}";

            // Nạp chi tiết hóa đơn vào DataGridView
            LoadDataGrid();
            if (dgvCTHD.Rows.Count > 0)
            {
                EditDataGrid();
                // Tính tổng thành tiền và hiển thị vào txtThanhTien
                decimal TongThanhTien = 0;

                foreach (DataGridViewRow row in dgvCTHD.Rows)
                {
                    
                        // Lấy giá trị thành tiền từ cột "Thành tiền"
                        decimal ThanhTien = Convert.ToDecimal(row.Cells[4].Value);
                        TongThanhTien += ThanhTien;
                    
                }

                // Cập nhật tổng thành tiền vào TextBox
                txtThanhTien.Text = TongThanhTien.ToString("N0") + "đ";  // Định dạng số và thêm "đ" vào cuối
            }
            else
            {
                MessageBox.Show("Không có chi tiết cho hóa đơn này.");
            }
        }

        #endregion
    }
}
