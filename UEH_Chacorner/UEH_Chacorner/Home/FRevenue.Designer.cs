namespace UEH_Chacorner.Home
{
    partial class FRevenue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblHoaDon = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvHoaDon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.datetimepicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtTenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenNV = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNgayLap = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnXemCTHD = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimTenNV = new Guna.UI2.WinForms.Guna2Button();
            this.lblRevenue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bindingSourceHoaDon = new System.Windows.Forms.BindingSource(this.components);
            this.btnHienThiTatCa = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.lblHoaDon.Location = new System.Drawing.Point(37, 12);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(119, 18);
            this.lblHoaDon.TabIndex = 0;
            this.lblHoaDon.Text = "Danh sách hóa đơn";
            // 
            // dgvHoaDon
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDon.ColumnHeadersHeight = 40;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.Location = new System.Drawing.Point(37, 36);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(680, 190);
            this.dgvHoaDon.TabIndex = 1;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvHoaDon.ThemeStyle.ReadOnly = false;
            this.dgvHoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvHoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHoaDon.ThemeStyle.RowsStyle.Height = 24;
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // datetimepicker
            // 
            this.datetimepicker.Checked = true;
            this.datetimepicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datetimepicker.Location = new System.Drawing.Point(37, 275);
            this.datetimepicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetimepicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetimepicker.Name = "datetimepicker";
            this.datetimepicker.Size = new System.Drawing.Size(413, 36);
            this.datetimepicker.TabIndex = 2;
            this.datetimepicker.Value = new System.DateTime(2024, 12, 12, 21, 6, 42, 608);
            this.datetimepicker.CloseUp += new System.EventHandler(this.datetimepicker_CloseUp);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNV.DefaultText = "";
            this.txtTenNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.Location = new System.Drawing.Point(37, 360);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.PasswordChar = '\0';
            this.txtTenNV.PlaceholderText = "Nhập tên nhân viên";
            this.txtTenNV.SelectedText = "";
            this.txtTenNV.Size = new System.Drawing.Size(265, 48);
            this.txtTenNV.TabIndex = 3;
            this.txtTenNV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenNV_KeyDown);
            // 
            // lblTenNV
            // 
            this.lblTenNV.BackColor = System.Drawing.Color.Transparent;
            this.lblTenNV.Location = new System.Drawing.Point(37, 335);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(136, 18);
            this.lblTenNV.TabIndex = 4;
            this.lblTenNV.Text = "Tìm theo tên nhân viên";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayLap.Location = new System.Drawing.Point(37, 251);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(88, 18);
            this.lblNgayLap.TabIndex = 5;
            this.lblNgayLap.Text = "Tìm theo ngày";
            // 
            // btnXemCTHD
            // 
            this.btnXemCTHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXemCTHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXemCTHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXemCTHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXemCTHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXemCTHD.ForeColor = System.Drawing.Color.White;
            this.btnXemCTHD.Location = new System.Drawing.Point(805, 100);
            this.btnXemCTHD.Name = "btnXemCTHD";
            this.btnXemCTHD.Size = new System.Drawing.Size(230, 45);
            this.btnXemCTHD.TabIndex = 6;
            this.btnXemCTHD.Text = "Xem chi tiết hóa đơn";
            this.btnXemCTHD.Click += new System.EventHandler(this.btnXemCTHD_Click);
            // 
            // btnTimTenNV
            // 
            this.btnTimTenNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimTenNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimTenNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimTenNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimTenNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimTenNV.ForeColor = System.Drawing.Color.White;
            this.btnTimTenNV.Location = new System.Drawing.Point(333, 360);
            this.btnTimTenNV.Name = "btnTimTenNV";
            this.btnTimTenNV.Size = new System.Drawing.Size(117, 45);
            this.btnTimTenNV.TabIndex = 7;
            this.btnTimTenNV.Text = "Tìm";
            this.btnTimTenNV.Click += new System.EventHandler(this.btnTimTenNV_Click);
            // 
            // lblRevenue
            // 
            this.lblRevenue.BackColor = System.Drawing.Color.Transparent;
            this.lblRevenue.Location = new System.Drawing.Point(726, 238);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(192, 18);
            this.lblRevenue.TabIndex = 8;
            this.lblRevenue.Text = "Biểu đồ doanh thu theo thời gian";
            // 
            // chartRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(521, 275);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(647, 358);
            this.chartRevenue.TabIndex = 9;
            this.chartRevenue.Text = "Biểu đồ";
            // 
            // btnHienThiTatCa
            // 
            this.btnHienThiTatCa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHienThiTatCa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHienThiTatCa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHienThiTatCa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHienThiTatCa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHienThiTatCa.ForeColor = System.Drawing.Color.White;
            this.btnHienThiTatCa.Location = new System.Drawing.Point(37, 432);
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.Size = new System.Drawing.Size(210, 45);
            this.btnHienThiTatCa.TabIndex = 10;
            this.btnHienThiTatCa.Text = "Hiển thị tất cả hóa đơn";
            this.btnHienThiTatCa.Click += new System.EventHandler(this.btnHienThiTatCa_Click);
            // 
            // FRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 645);
            this.Controls.Add(this.btnHienThiTatCa);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.btnTimTenNV);
            this.Controls.Add(this.btnXemCTHD);
            this.Controls.Add(this.lblNgayLap);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.datetimepicker);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.lblHoaDon);
            this.Name = "FRevenue";
            this.Text = "FRevenue";
            this.Load += new System.EventHandler(this.FRevenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblHoaDon;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHoaDon;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetimepicker;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNV;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenNV;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgayLap;
        private Guna.UI2.WinForms.Guna2Button btnXemCTHD;
        private Guna.UI2.WinForms.Guna2Button btnTimTenNV;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.BindingSource bindingSourceHoaDon;
        private Guna.UI2.WinForms.Guna2Button btnHienThiTatCa;
    }
}