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

namespace UEH_ChaCorner.Home
{
    public partial class FRevenue : Form
    {
        private readonly CTHD_BLL _cthdBll = new CTHD_BLL();
        private readonly HOADON_BLL _hoadonBll = new HOADON_BLL();

        public FRevenue()
        {
            InitializeComponent();
        }

        #region Method

        private void LoadDataGrid()
        {
            bindingSourceHoaDon.DataSource = _hoadonBll.load_hoadon();
            dgvHoaDon.DataSource = bindingSourceHoaDon;
        }

        private void EditDataGrid()
        {
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.Columns[0].HeaderText = @"Mã hóa đơn";
            dgvHoaDon.Columns[1].HeaderText = @"Tên bàn";
            dgvHoaDon.Columns[2].HeaderText = @"Tên nhân viên";
            dgvHoaDon.Columns[3].HeaderText = @"Ngày lập";
            dgvHoaDon.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvHoaDon.Columns[4].HeaderText = @"Trạng thái";
        }

        private void FilterDataGridByNgayLap(DateTime date)
        {
            // Kiểm tra ngày trong tương lai
            if (date.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày đã chọn chưa diễn ra. Vui lòng chọn ngày hợp lệ.",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Giả sử `load_hoadon()` trả về danh sách hóa đơn
            DataTable dt = _hoadonBll.load_hoadon();

            // Lọc theo ngày
            DataView dv = new DataView(dt)
            {
                RowFilter = $"NgayLap = #{date:MM/dd/yyyy}#"
            };

            bindingSourceHoaDon.DataSource = dv;
            dgvHoaDon.DataSource = bindingSourceHoaDon;

            if (dv.Count == 0)
            {
                MessageBox.Show("Không có hóa đơn nào trong ngày đã chọn.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FilterDataGridByTenNV(string tenNV)
        {
            // Lấy dữ liệu từ bảng hóa đơn
            DataTable dt = _hoadonBll.load_hoadon();

            // Lọc theo tên nhân viên trong DataTable (cột TenNV đã có trong DataTable sau khi load)
            DataView dv = new DataView(dt)
            {
                RowFilter = $"TenNV LIKE '%{tenNV}%'"
            };

            // Gán kết quả lọc cho binding source và data grid
            bindingSourceHoaDon.DataSource = dv;
            dgvHoaDon.DataSource = bindingSourceHoaDon;

            // Kiểm tra xem có kết quả lọc hay không
            if (dv.Count == 0)
            {
                MessageBox.Show("Không có hóa đơn nào cho nhân viên này.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadChartRevenue()
        {
            // Lấy dữ liệu từ bảng hóa đơn
            DataTable dtHoaDon = _hoadonBll.load_hoadon();

            // Tạo một dictionary để lưu tổng doanh thu theo tháng (tháng - năm)
            Dictionary<string, decimal> DoanhThuData = new Dictionary<string, decimal>();

            // Lặp qua từng hóa đơn
            foreach (DataRow row in dtHoaDon.Rows)
            {
                string TrangThai = row["TrangThai"].ToString(); // Lấy trạng thái hóa đơn
                if (TrangThai != "Đã Thanh Toán")
                {
                    continue;  // Nếu không phải "Đã thanh toán", bỏ qua hóa đơn này
                }

                // Lấy ngày lập hóa đơn và tính tháng-năm
                DateTime NgayLap = Convert.ToDateTime(row["NgayLap"]);
                int _maHD = Convert.ToInt32(row["MaHD"]);  // Lấy MaHD của hóa đơn hiện tại

                // Tính tổng doanh thu từ bảng chi tiết hóa đơn
                decimal DoanhThu = 0;

                // Tạo đối tượng CTHD_DTO và gán MaHD
                CTHD_DTO cthdDto = new CTHD_DTO { MaHD = _maHD };

                // Gọi hàm load_cthd với đối tượng CTHD_DTO
                DataTable dtCTHD = _cthdBll.load_cthd(cthdDto);  // Truyền đối tượng CTHD_DTO

                foreach (DataRow cthdRow in dtCTHD.Rows)
                {
                    // Tính doanh thu cho từng chi tiết hóa đơn (Số lượng * Đơn giá)
                    decimal SoLuong = Convert.ToDecimal(cthdRow["SoLuong"]);
                    decimal DonGia = Convert.ToDecimal(cthdRow["DonGia"]);
                    DoanhThu += SoLuong * DonGia;
                }

                // Tạo chuỗi tháng-năm để nhóm doanh thu
                string monthYear = NgayLap.ToString("MM/yyyy");

                // Lưu doanh thu theo tháng-năm
                if (DoanhThuData.ContainsKey(monthYear))
                {
                    DoanhThuData[monthYear] += DoanhThu;
                }
                else
                {
                    DoanhThuData.Add(monthYear, DoanhThu);
                }
            }

            // Cập nhật chartRevenue
            chartRevenue.Series.Clear();
            var series = chartRevenue.Series.Add("Doanh thu");

            // Vẽ biểu đồ với dữ liệu đã tính toán
            foreach (var entry in DoanhThuData)
            {
                series.Points.AddXY(entry.Key, entry.Value);
            }

            // Cài đặt biểu đồ
            chartRevenue.ChartAreas[0].AxisX.Title = "Tháng";  // Đặt tiêu đề cho trục X là "Tháng"
            chartRevenue.ChartAreas[0].AxisY.Title = "Doanh thu";  // Đặt tiêu đề cho trục Y là "Doanh thu"

            // Định dạng số trên trục Y
            chartRevenue.ChartAreas[0].AxisY.LabelStyle.Format = "#,0";  // Định dạng số liệu trục Y
        }


        #endregion

        #region Event

        private void FRevenue_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            if (dgvHoaDon.Rows.Count > 0)
            {
                EditDataGrid();
            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadChartRevenue(); // Tải dữ liệu vào chart
        }

        private void btnXemCTHD_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgvHoaDon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy MaHD từ dòng được chọn
            int _maHD = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells[0].Value);

            // Mở form chi tiết hóa đơn
            FRevenueDetails fCTHD = new FRevenueDetails(_maHD);
            fCTHD.ShowDialog();
        }

        private void datetimepicker_CloseUp(object sender, EventArgs e)
        {
            DateTime selectedDate = datetimepicker.Value.Date;

            // Gọi phương thức lọc
            FilterDataGridByNgayLap(selectedDate);
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            LoadDataGrid();  // Gọi lại phương thức load tất cả hóa đơn
            if (dgvHoaDon.Rows.Count > 0)
            {
                EditDataGrid();  // Đảm bảo cài đặt lại header
            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTimTenNV_Click(object sender, EventArgs e)
        {
            string tenNV = txtTenNV.Text.Trim();

            if (string.IsNullOrEmpty(tenNV))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi phương thức lọc theo tên nhân viên
            FilterDataGridByTenNV(tenNV);
        }

        private void txtTenNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimTenNV.PerformClick(); // Giả lập việc nhấn nút tìm
            }
        }

        #endregion


    }
}
