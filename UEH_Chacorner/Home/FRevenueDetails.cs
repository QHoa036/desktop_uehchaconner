using BLL;
using DTO;
using Microsoft.Office.Interop.Word;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace UEH_ChaCorner.Home
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

        public string Tenban { get; set; }

        private void LoadDataGrid()
        {
            dgvCTHD.DataSource = bindingSourceCTHD;
        }

        private void EditDataGrid()
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

        private void ExportFile(DataGridView dgv, string filename)
        {
            //Kiểm tra xem DataGridView có dữ liệu không
            if (dgv.Rows.Count != 0)
            {
                //Chuyển dữ liệu từ DataGridView sang mảng hai chiều
                var rowCount = dgv.Rows.Count;
                var columnCount = dgv.Columns.Count;
                //Khởi tạo mảng dataArray để chứa toàn bộ dữ liệu.
                var dataArray = new object[rowCount + 1, columnCount + 1];

                //Duyệt qua các ô trong DataGridView và lưu giá trị vào dataArray
                int r;
                for (var c = 0; c <= columnCount - 1; c++)
                    for (r = 0; r <= rowCount - 1; r++)
                        dataArray[r, c] = dgv.Rows[r].Cells[c].Value;

                //Khởi tạo tài liệu Word
                var oApp = new Microsoft.Office.Interop.Word.Application();
                var oDoc = oApp.Documents.Add(); //Tạo đối tượng Word Document
                oApp.Visible = false;

                //Đặt hướng trang ngang
                oDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;

                //Thiết lập tiêu đề trang
                oDoc.PageSetup.DifferentFirstPageHeaderFooter = -1; //Cho phép thiết lập tiêu đề khác nhau trên các trang.
                oDoc.Sections[1].Headers[WdHeaderFooterIndex.wdHeaderFooterFirstPage].Range.Text = @"Hóa đơn";
                oDoc.Sections[1].Headers[WdHeaderFooterIndex.wdHeaderFooterFirstPage].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                oDoc.Sections[1].Headers[WdHeaderFooterIndex.wdHeaderFooterFirstPage].Range.Bold = 3;
                oDoc.Sections[1].Headers[WdHeaderFooterIndex.wdHeaderFooterFirstPage].Range.Font.Size = 20;
                oDoc.Sections[1].Headers[WdHeaderFooterIndex.wdHeaderFooterFirstPage].Range.Font.Name = "Tahoma";

                //Chuyển dữ liệu thành bảng trong Word
                dynamic oRange = oDoc.Content.Application.Selection.Range;
                var oTemp = "";
                //Nối các giá trị thành chuỗi cách nhau bằng dấu tab \t
                for (r = 0; r <= rowCount - 1; r++)
                    for (var c = 0; c <= columnCount - 1; c++)
                        oTemp = oTemp + dataArray[r, c] + "\t";

                oRange.Text = oTemp;

                object separator = WdTableFieldSeparator.wdSeparateByTabs;
                object applyBorders = true;
                object autoFit = true;
                object autoFitBehavior = WdAutoFitBehavior.wdAutoFitContent;

                //Chuyển chuỗi này thành bảng trong tài liệu Word
                oRange.ConvertToTable(ref separator, ref rowCount, ref columnCount,
                    Type.Missing, Type.Missing, ref applyBorders,
                    Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, ref autoFit, ref autoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //In đậm và chỉnh font hàng đầu tiên
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //Thêm dòng tiêu đề cột từ DataGridView
                for (var c = 0; c <= columnCount - 1; c++)
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = dgv.Columns[c].HeaderText;

                //Thiết lập kiểu bảng
                oDoc.Application.Selection.Tables[1].set_Style("Table Grid 3");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //Thêm thông tin tổng tiền
                var p = oDoc.Paragraphs.Add();
                var TongTien = p.Range;
                TongTien.Text = @"Tổng tiền: " + txtThanhTien.Text;

                // Căn lề phải cho tổng tiền
                TongTien.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                TongTien.Font.Name = "Tahoma";
                TongTien.ParagraphFormat.LineUnitBefore = 3;
                TongTien.InsertParagraphAfter();

                //Thêm ngày giờ hiện tại
                var p1 = oDoc.Paragraphs.Add();
                var billTime = p1.Range;
                billTime.Text = DateTime.Now.ToString(CultureInfo.CurrentCulture);
                // Căn lề phải cho ngày giờ
                billTime.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                billTime.Font.Name = "Tahoma";
                billTime.InsertParagraphAfter();

                //Lưu file dưới định dạng PDF
                oDoc.SaveAs(filename, WdSaveFormat.wdFormatPDF);
                System.Diagnostics.Process.Start("explorer.exe", filename);
                oDoc.Close(false);
                oApp.Quit();
            }
        }

        private void PrintBill()
        {
            //Hiển thị hộp thoại lưu file
            var save = new SaveFileDialog { Filter = @"PDF (*.pdf)|*.pdf" };
            save.FileName = save.FileName;
            //Nếu người dùng chọn file, gọi ExportFile để xuất hóa đơn.
            if (save.ShowDialog() == DialogResult.OK)
            {
                ExportFile(dgvCTHD, save.FileName);
            }
        }

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
                TinhTongTien();
            }
            else
            {
                MessageBox.Show("Không có chi tiết cho hóa đơn này.");
            }
        }

        private void btnExportToWord_Click(object sender, EventArgs e)
        {
            PrintBill();
        }
    }
}