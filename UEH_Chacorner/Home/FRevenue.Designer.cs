namespace UEH_ChaCorner.Home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRevenue));
            this.datetimepicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.bindingSourceHoaDon = new System.Windows.Forms.BindingSource(this.components);
            this.panelRight = new Guna.UI2.WinForms.Guna2Panel();
            this.grStaffList = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.dgvHoaDon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelGrStaffListFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelGrStaffListHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lbTitle5 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelChart = new Guna.UI2.WinForms.Guna2Panel();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHienThiTatCa = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoaDon)).BeginInit();
            this.panelRight.SuspendLayout();
            this.grStaffList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panelGrStaffListFooter.SuspendLayout();
            this.panelGrStaffListHeader.SuspendLayout();
            this.panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // datetimepicker
            // 
            this.datetimepicker.Animated = true;
            this.datetimepicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.datetimepicker.BorderRadius = 14;
            this.datetimepicker.BorderThickness = 1;
            this.datetimepicker.Checked = true;
            this.datetimepicker.CheckedState.FillColor = System.Drawing.Color.White;
            this.datetimepicker.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.datetimepicker.FillColor = System.Drawing.Color.White;
            this.datetimepicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.datetimepicker.ForeColor = System.Drawing.Color.Black;
            this.datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datetimepicker.Location = new System.Drawing.Point(23, 149);
            this.datetimepicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetimepicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetimepicker.Name = "datetimepicker";
            this.datetimepicker.Size = new System.Drawing.Size(341, 50);
            this.datetimepicker.TabIndex = 2;
            this.datetimepicker.Value = new System.DateTime(2024, 12, 12, 21, 6, 42, 608);
            this.datetimepicker.CloseUp += new System.EventHandler(this.datetimepicker_CloseUp);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Transparent;
            this.panelRight.Controls.Add(this.grStaffList);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1425, 400);
            this.panelRight.TabIndex = 101;
            // 
            // grStaffList
            // 
            this.grStaffList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grStaffList.BackColor = System.Drawing.Color.Transparent;
            this.grStaffList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.grStaffList.BorderRadius = 24;
            this.grStaffList.BorderThickness = 1;
            this.grStaffList.Controls.Add(this.dgvHoaDon);
            this.grStaffList.Controls.Add(this.panelGrStaffListFooter);
            this.grStaffList.Controls.Add(this.panelGrStaffListHeader);
            this.grStaffList.FillColor = System.Drawing.Color.White;
            this.grStaffList.FillColor2 = System.Drawing.Color.White;
            this.grStaffList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.grStaffList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.grStaffList.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grStaffList.Location = new System.Drawing.Point(15, 10);
            this.grStaffList.Margin = new System.Windows.Forms.Padding(4);
            this.grStaffList.Name = "grStaffList";
            this.grStaffList.ShadowDecoration.BorderRadius = 30;
            this.grStaffList.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(68)))), ((int)(((byte)(54)))));
            this.grStaffList.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.grStaffList.Size = new System.Drawing.Size(1394, 380);
            this.grStaffList.TabIndex = 99;
            // 
            // dgvHoaDon
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHoaDon.ColumnHeadersHeight = 40;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 75);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(20);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 50;
            this.dgvHoaDon.RowTemplate.Height = 40;
            this.dgvHoaDon.Size = new System.Drawing.Size(1394, 276);
            this.dgvHoaDon.TabIndex = 46;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(42)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvHoaDon.ThemeStyle.ReadOnly = true;
            this.dgvHoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvHoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.dgvHoaDon.ThemeStyle.RowsStyle.Height = 40;
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.dgvHoaDon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellDoubleClick);
            // 
            // panelGrStaffListFooter
            // 
            this.panelGrStaffListFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.panelGrStaffListFooter.BorderRadius = 24;
            this.panelGrStaffListFooter.Controls.Add(this.guna2Panel1);
            this.panelGrStaffListFooter.CustomizableEdges.TopLeft = false;
            this.panelGrStaffListFooter.CustomizableEdges.TopRight = false;
            this.panelGrStaffListFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGrStaffListFooter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.panelGrStaffListFooter.ForeColor = System.Drawing.Color.White;
            this.panelGrStaffListFooter.Location = new System.Drawing.Point(0, 351);
            this.panelGrStaffListFooter.Margin = new System.Windows.Forms.Padding(2);
            this.panelGrStaffListFooter.Name = "panelGrStaffListFooter";
            this.panelGrStaffListFooter.Size = new System.Drawing.Size(1394, 29);
            this.panelGrStaffListFooter.TabIndex = 44;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.guna2Panel1.BorderRadius = 24;
            this.guna2Panel1.CustomizableEdges.TopLeft = false;
            this.guna2Panel1.CustomizableEdges.TopRight = false;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.guna2Panel1.ForeColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1394, 29);
            this.guna2Panel1.TabIndex = 45;
            // 
            // panelGrStaffListHeader
            // 
            this.panelGrStaffListHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.panelGrStaffListHeader.BorderRadius = 24;
            this.panelGrStaffListHeader.Controls.Add(this.lblThanhTien);
            this.panelGrStaffListHeader.Controls.Add(this.lbTitle5);
            this.panelGrStaffListHeader.CustomizableEdges.BottomLeft = false;
            this.panelGrStaffListHeader.CustomizableEdges.BottomRight = false;
            this.panelGrStaffListHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGrStaffListHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.panelGrStaffListHeader.ForeColor = System.Drawing.Color.White;
            this.panelGrStaffListHeader.Location = new System.Drawing.Point(0, 0);
            this.panelGrStaffListHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelGrStaffListHeader.Name = "panelGrStaffListHeader";
            this.panelGrStaffListHeader.Size = new System.Drawing.Size(1394, 75);
            this.panelGrStaffListHeader.TabIndex = 43;
            // 
            // lbTitle5
            // 
            this.lbTitle5.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle5.ForeColor = System.Drawing.Color.White;
            this.lbTitle5.Location = new System.Drawing.Point(0, 0);
            this.lbTitle5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle5.Name = "lbTitle5";
            this.lbTitle5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbTitle5.Size = new System.Drawing.Size(299, 75);
            this.lbTitle5.TabIndex = 38;
            this.lbTitle5.Text = "Danh sách hóa đơn";
            this.lbTitle5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Animated = true;
            this.txtSearch.BorderRadius = 14;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(127)))), ((int)(((byte)(149)))));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconRight = global::UEH_ChaCorner.Properties.Resources.search;
            this.txtSearch.IconRightOffset = new System.Drawing.Point(8, 0);
            this.txtSearch.IconRightSize = new System.Drawing.Size(16, 16);
            this.txtSearch.Location = new System.Drawing.Point(23, 278);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(10, 4, 2, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSearch.PlaceholderText = "Tìm kiếm nhân viên";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(341, 50);
            this.txtSearch.TabIndex = 39;
            this.txtSearch.TextChanged += new System.EventHandler(this.btnTimTenNV_TextChanged);
            // 
            // panelChart
            // 
            this.panelChart.BackColor = System.Drawing.Color.Transparent;
            this.panelChart.BorderRadius = 24;
            this.panelChart.Controls.Add(this.chartRevenue);
            this.panelChart.Controls.Add(this.guna2Panel3);
            this.panelChart.Controls.Add(this.guna2Panel2);
            this.panelChart.FillColor = System.Drawing.Color.White;
            this.panelChart.Location = new System.Drawing.Point(429, 408);
            this.panelChart.Margin = new System.Windows.Forms.Padding(4);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(980, 391);
            this.panelChart.TabIndex = 102;
            // 
            // chartRevenue
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea3);
            this.chartRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend3);
            this.chartRevenue.Location = new System.Drawing.Point(0, 75);
            this.chartRevenue.Margin = new System.Windows.Forms.Padding(4);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartRevenue.Series.Add(series3);
            this.chartRevenue.Size = new System.Drawing.Size(980, 287);
            this.chartRevenue.TabIndex = 106;
            this.chartRevenue.Text = "Biểu đồ";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.guna2Panel3.BorderRadius = 24;
            this.guna2Panel3.CustomizableEdges.TopLeft = false;
            this.guna2Panel3.CustomizableEdges.TopRight = false;
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.guna2Panel3.ForeColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 362);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(980, 29);
            this.guna2Panel3.TabIndex = 105;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.guna2Panel2.BorderRadius = 24;
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.CustomizableEdges.BottomLeft = false;
            this.guna2Panel2.CustomizableEdges.BottomRight = false;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.guna2Panel2.ForeColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(980, 75);
            this.guna2Panel2.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(980, 75);
            this.label1.TabIndex = 38;
            this.label1.Text = "Biểu đồ doanh thu theo thời gian";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHienThiTatCa
            // 
            this.btnHienThiTatCa.Animated = true;
            this.btnHienThiTatCa.AutoRoundedCorners = true;
            this.btnHienThiTatCa.BackColor = System.Drawing.Color.Transparent;
            this.btnHienThiTatCa.BorderColor = System.Drawing.Color.Transparent;
            this.btnHienThiTatCa.BorderRadius = 19;
            this.btnHienThiTatCa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.btnHienThiTatCa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHienThiTatCa.ForeColor = System.Drawing.Color.White;
            this.btnHienThiTatCa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(151)))), ((int)(((byte)(59)))));
            this.btnHienThiTatCa.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnHienThiTatCa.Image = ((System.Drawing.Image)(resources.GetObject("btnHienThiTatCa.Image")));
            this.btnHienThiTatCa.Location = new System.Drawing.Point(324, 18);
            this.btnHienThiTatCa.Margin = new System.Windows.Forms.Padding(2);
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(159)))));
            this.btnHienThiTatCa.PressedDepth = 50;
            this.btnHienThiTatCa.ShadowDecoration.BorderRadius = 23;
            this.btnHienThiTatCa.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.btnHienThiTatCa.Size = new System.Drawing.Size(40, 40);
            this.btnHienThiTatCa.TabIndex = 107;
            this.btnHienThiTatCa.UseTransparentBackground = true;
            this.btnHienThiTatCa.Click += new System.EventHandler(this.btnHienThiTatCa_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderRadius = 24;
            this.guna2Panel4.Controls.Add(this.label3);
            this.guna2Panel4.Controls.Add(this.lbTenNV);
            this.guna2Panel4.Controls.Add(this.txtSearch);
            this.guna2Panel4.Controls.Add(this.datetimepicker);
            this.guna2Panel4.Controls.Add(this.guna2Panel6);
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.guna2Panel4.Location = new System.Drawing.Point(20, 420);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(383, 362);
            this.guna2Panel4.TabIndex = 107;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.label3.Location = new System.Drawing.Point(19, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 29);
            this.label3.TabIndex = 107;
            this.label3.Text = "Tìm kiếm theo nhân viên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTenNV
            // 
            this.lbTenNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.lbTenNV.Location = new System.Drawing.Point(19, 102);
            this.lbTenNV.Margin = new System.Windows.Forms.Padding(0);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(304, 29);
            this.lbTenNV.TabIndex = 106;
            this.lbTenNV.Text = "Tìm kiếm theo ngày tháng";
            this.lbTenNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.guna2Panel6.BorderRadius = 24;
            this.guna2Panel6.Controls.Add(this.btnHienThiTatCa);
            this.guna2Panel6.Controls.Add(this.label2);
            this.guna2Panel6.CustomizableEdges.BottomLeft = false;
            this.guna2Panel6.CustomizableEdges.BottomRight = false;
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.guna2Panel6.ForeColor = System.Drawing.Color.White;
            this.guna2Panel6.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(383, 75);
            this.guna2Panel6.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(383, 75);
            this.label2.TabIndex = 38;
            this.label2.Text = "Chức năng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.ForeColor = System.Drawing.Color.White;
            this.lblThanhTien.Location = new System.Drawing.Point(1071, 25);
            this.lblThanhTien.Margin = new System.Windows.Forms.Padding(0);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(308, 29);
            this.lblThanhTien.TabIndex = 109;
            this.lblThanhTien.Text = "Mã bàn: ?";
            this.lblThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1425, 812);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.panelRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRevenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRevenue";
            this.Load += new System.EventHandler(this.FRevenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoaDon)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.grStaffList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panelGrStaffListFooter.ResumeLayout(false);
            this.panelGrStaffListHeader.ResumeLayout(false);
            this.panelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker datetimepicker;
        private System.Windows.Forms.BindingSource bindingSourceHoaDon;
        private Guna.UI2.WinForms.Guna2Panel panelRight;
        public Guna.UI2.WinForms.Guna2GradientPanel grStaffList;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHoaDon;
        private Guna.UI2.WinForms.Guna2Panel panelGrStaffListFooter;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelGrStaffListHeader;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label lbTitle5;
        private Guna.UI2.WinForms.Guna2Panel panelChart;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnHienThiTatCa;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblThanhTien;
    }
}