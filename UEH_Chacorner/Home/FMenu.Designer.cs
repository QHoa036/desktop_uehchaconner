namespace UEH_ChaCorner.Home
{
    partial class FMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.panelRight = new Guna.UI2.WinForms.Guna2Panel();
            this.grStaffList = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.dgvsanpham = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelGrStaffListFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.panelGrStaffListHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTitle5 = new System.Windows.Forms.Label();
            this.grStaff = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbHoten = new System.Windows.Forms.Label();
            this.txtgia = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbMaDMSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbGioitinh = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.txttensp = new Guna.UI2.WinForms.Guna2TextBox();
            this.btThem = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btSua = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btXoa = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panelRight.SuspendLayout();
            this.grStaffList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).BeginInit();
            this.panelGrStaffListHeader.SuspendLayout();
            this.grStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Transparent;
            this.panelRight.Controls.Add(this.grStaffList);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1425, 510);
            this.panelRight.TabIndex = 64;
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
            this.grStaffList.Controls.Add(this.dgvsanpham);
            this.grStaffList.Controls.Add(this.panelGrStaffListFooter);
            this.grStaffList.Controls.Add(this.panelGrStaffListHeader);
            this.grStaffList.FillColor = System.Drawing.Color.White;
            this.grStaffList.FillColor2 = System.Drawing.Color.White;
            this.grStaffList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.grStaffList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.grStaffList.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grStaffList.Location = new System.Drawing.Point(16, 15);
            this.grStaffList.Margin = new System.Windows.Forms.Padding(4);
            this.grStaffList.Name = "grStaffList";
            this.grStaffList.ShadowDecoration.BorderRadius = 30;
            this.grStaffList.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(68)))), ((int)(((byte)(54)))));
            this.grStaffList.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.grStaffList.Size = new System.Drawing.Size(1394, 480);
            this.grStaffList.TabIndex = 98;
            // 
            // dgvsanpham
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvsanpham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvsanpham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsanpham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvsanpham.ColumnHeadersHeight = 40;
            this.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsanpham.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvsanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvsanpham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.dgvsanpham.Location = new System.Drawing.Point(0, 75);
            this.dgvsanpham.Margin = new System.Windows.Forms.Padding(20);
            this.dgvsanpham.Name = "dgvsanpham";
            this.dgvsanpham.ReadOnly = true;
            this.dgvsanpham.RowHeadersVisible = false;
            this.dgvsanpham.RowHeadersWidth = 50;
            this.dgvsanpham.RowTemplate.Height = 40;
            this.dgvsanpham.Size = new System.Drawing.Size(1394, 376);
            this.dgvsanpham.TabIndex = 45;
            this.dgvsanpham.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvsanpham.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvsanpham.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvsanpham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvsanpham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvsanpham.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvsanpham.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.dgvsanpham.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(42)))));
            this.dgvsanpham.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvsanpham.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvsanpham.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvsanpham.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvsanpham.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvsanpham.ThemeStyle.ReadOnly = true;
            this.dgvsanpham.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvsanpham.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvsanpham.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvsanpham.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.dgvsanpham.ThemeStyle.RowsStyle.Height = 40;
            this.dgvsanpham.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.dgvsanpham.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.dgvsanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsanpham_CellClick);
            // 
            // panelGrStaffListFooter
            // 
            this.panelGrStaffListFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.panelGrStaffListFooter.BorderRadius = 24;
            this.panelGrStaffListFooter.CustomizableEdges.TopLeft = false;
            this.panelGrStaffListFooter.CustomizableEdges.TopRight = false;
            this.panelGrStaffListFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGrStaffListFooter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.panelGrStaffListFooter.ForeColor = System.Drawing.Color.White;
            this.panelGrStaffListFooter.Location = new System.Drawing.Point(0, 451);
            this.panelGrStaffListFooter.Margin = new System.Windows.Forms.Padding(2);
            this.panelGrStaffListFooter.Name = "panelGrStaffListFooter";
            this.panelGrStaffListFooter.Size = new System.Drawing.Size(1394, 29);
            this.panelGrStaffListFooter.TabIndex = 44;
            // 
            // panelGrStaffListHeader
            // 
            this.panelGrStaffListHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.panelGrStaffListHeader.BorderRadius = 24;
            this.panelGrStaffListHeader.Controls.Add(this.txtSearch);
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
            // txtSearch
            // 
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
            this.txtSearch.Location = new System.Drawing.Point(954, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(10, 4, 2, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(30);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSearch.PlaceholderText = "Nhập món tại đây";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(353, 50);
            this.txtSearch.TabIndex = 39;
            this.txtSearch.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
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
            this.lbTitle5.Text = "Danh sách thực đơn";
            this.lbTitle5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grStaff
            // 
            this.grStaff.BackColor = System.Drawing.Color.Transparent;
            this.grStaff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.grStaff.BorderRadius = 20;
            this.grStaff.BorderThickness = 0;
            this.grStaff.Controls.Add(this.lbHoten);
            this.grStaff.Controls.Add(this.txtgia);
            this.grStaff.Controls.Add(this.cbbMaDMSP);
            this.grStaff.Controls.Add(this.lbGioitinh);
            this.grStaff.Controls.Add(this.lbTenNV);
            this.grStaff.Controls.Add(this.txttensp);
            this.grStaff.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.grStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.grStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.grStaff.ForeColor = System.Drawing.Color.White;
            this.grStaff.Location = new System.Drawing.Point(395, 512);
            this.grStaff.Margin = new System.Windows.Forms.Padding(4);
            this.grStaff.Name = "grStaff";
            this.grStaff.ShadowDecoration.BorderRadius = 20;
            this.grStaff.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.grStaff.ShadowDecoration.Depth = 40;
            this.grStaff.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7, 0, 0, 7);
            this.grStaff.Size = new System.Drawing.Size(650, 280);
            this.grStaff.TabIndex = 99;
            this.grStaff.Text = "Thông tin thực đơn";
            this.grStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.grStaff.UseTransparentBackground = true;
            // 
            // lbHoten
            // 
            this.lbHoten.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.lbHoten.Location = new System.Drawing.Point(14, 160);
            this.lbHoten.Margin = new System.Windows.Forms.Padding(0);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(304, 29);
            this.lbHoten.TabIndex = 88;
            this.lbHoten.Text = "Đơn giá";
            this.lbHoten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtgia
            // 
            this.txtgia.Animated = true;
            this.txtgia.BackColor = System.Drawing.Color.Transparent;
            this.txtgia.BorderColor = System.Drawing.Color.Transparent;
            this.txtgia.BorderRadius = 4;
            this.txtgia.BorderThickness = 0;
            this.txtgia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtgia.DefaultText = "";
            this.txtgia.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.txtgia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtgia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtgia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtgia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(96)))), ((int)(((byte)(48)))));
            this.txtgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtgia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txtgia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(151)))), ((int)(((byte)(59)))));
            this.txtgia.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.txtgia.IconLeftSize = new System.Drawing.Size(14, 14);
            this.txtgia.Location = new System.Drawing.Point(22, 202);
            this.txtgia.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtgia.Name = "txtgia";
            this.txtgia.Padding = new System.Windows.Forms.Padding(5);
            this.txtgia.PasswordChar = '\0';
            this.txtgia.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txtgia.PlaceholderText = "";
            this.txtgia.SelectedText = "";
            this.txtgia.ShadowDecoration.BorderRadius = 13;
            this.txtgia.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.txtgia.Size = new System.Drawing.Size(602, 50);
            this.txtgia.TabIndex = 87;
            // 
            // cbbMaDMSP
            // 
            this.cbbMaDMSP.Animated = true;
            this.cbbMaDMSP.BackColor = System.Drawing.Color.Transparent;
            this.cbbMaDMSP.BorderColor = System.Drawing.Color.Transparent;
            this.cbbMaDMSP.BorderRadius = 4;
            this.cbbMaDMSP.BorderThickness = 0;
            this.cbbMaDMSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMaDMSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaDMSP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(96)))), ((int)(((byte)(48)))));
            this.cbbMaDMSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(96)))), ((int)(((byte)(48)))));
            this.cbbMaDMSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbMaDMSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.cbbMaDMSP.FormattingEnabled = true;
            this.cbbMaDMSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(151)))), ((int)(((byte)(59)))));
            this.cbbMaDMSP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbbMaDMSP.ItemHeight = 34;
            this.cbbMaDMSP.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbMaDMSP.Location = new System.Drawing.Point(334, 97);
            this.cbbMaDMSP.Margin = new System.Windows.Forms.Padding(5);
            this.cbbMaDMSP.Name = "cbbMaDMSP";
            this.cbbMaDMSP.Size = new System.Drawing.Size(290, 40);
            this.cbbMaDMSP.StartIndex = 0;
            this.cbbMaDMSP.TabIndex = 85;
            this.cbbMaDMSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbGioitinh
            // 
            this.lbGioitinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioitinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.lbGioitinh.Location = new System.Drawing.Point(330, 55);
            this.lbGioitinh.Margin = new System.Windows.Forms.Padding(0);
            this.lbGioitinh.Name = "lbGioitinh";
            this.lbGioitinh.Size = new System.Drawing.Size(300, 29);
            this.lbGioitinh.TabIndex = 77;
            this.lbGioitinh.Text = "Mã danh mục";
            this.lbGioitinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTenNV
            // 
            this.lbTenNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.lbTenNV.Location = new System.Drawing.Point(14, 55);
            this.lbTenNV.Margin = new System.Windows.Forms.Padding(0);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(304, 29);
            this.lbTenNV.TabIndex = 76;
            this.lbTenNV.Text = "Tên sản phẩm";
            this.lbTenNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txttensp
            // 
            this.txttensp.Animated = true;
            this.txttensp.BorderColor = System.Drawing.Color.White;
            this.txttensp.BorderRadius = 4;
            this.txttensp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttensp.DefaultText = "";
            this.txttensp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttensp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttensp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttensp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttensp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttensp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttensp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txttensp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttensp.Location = new System.Drawing.Point(22, 97);
            this.txttensp.Margin = new System.Windows.Forms.Padding(0);
            this.txttensp.Name = "txttensp";
            this.txttensp.PasswordChar = '\0';
            this.txttensp.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txttensp.PlaceholderText = "";
            this.txttensp.SelectedText = "";
            this.txttensp.Size = new System.Drawing.Size(290, 50);
            this.txttensp.TabIndex = 22;
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Transparent;
            this.btThem.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btThem.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btThem.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageOffset = new System.Drawing.Point(0, 0);
            this.btThem.ImageRotate = 0F;
            this.btThem.ImageSize = new System.Drawing.Size(50, 50);
            this.btThem.Location = new System.Drawing.Point(1085, 540);
            this.btThem.Margin = new System.Windows.Forms.Padding(2);
            this.btThem.Name = "btThem";
            this.btThem.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btThem.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btThem.Size = new System.Drawing.Size(80, 80);
            this.btThem.TabIndex = 118;
            this.btThem.UseTransparentBackground = true;
            this.btThem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.Transparent;
            this.btSua.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btSua.HoverState.Image = global::UEH_ChaCorner.Properties.Resources.edit___hover;
            this.btSua.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.btSua.Image = global::UEH_ChaCorner.Properties.Resources.edit;
            this.btSua.ImageOffset = new System.Drawing.Point(0, 0);
            this.btSua.ImageRotate = 0F;
            this.btSua.ImageSize = new System.Drawing.Size(50, 50);
            this.btSua.Location = new System.Drawing.Point(1085, 621);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.PressedState.Image = global::UEH_ChaCorner.Properties.Resources.edit___hover;
            this.btSua.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btSua.Size = new System.Drawing.Size(80, 80);
            this.btSua.TabIndex = 116;
            this.btSua.UseTransparentBackground = true;
            this.btSua.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Transparent;
            this.btXoa.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btXoa.HoverState.Image = global::UEH_ChaCorner.Properties.Resources.delete___hover;
            this.btXoa.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.btXoa.Image = global::UEH_ChaCorner.Properties.Resources.delete;
            this.btXoa.ImageOffset = new System.Drawing.Point(0, 0);
            this.btXoa.ImageRotate = 0F;
            this.btXoa.ImageSize = new System.Drawing.Size(50, 50);
            this.btXoa.Location = new System.Drawing.Point(1085, 702);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.PressedState.Image = global::UEH_ChaCorner.Properties.Resources.delete___hover;
            this.btXoa.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btXoa.Size = new System.Drawing.Size(80, 80);
            this.btXoa.TabIndex = 117;
            this.btXoa.UseTransparentBackground = true;
            this.btXoa.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 812);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.grStaff);
            this.Controls.Add(this.panelRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMenu";
            this.Load += new System.EventHandler(this.FMenu_Load);
            this.panelRight.ResumeLayout(false);
            this.grStaffList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).EndInit();
            this.panelGrStaffListHeader.ResumeLayout(false);
            this.grStaff.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelRight;
        public Guna.UI2.WinForms.Guna2GradientPanel grStaffList;
        private Guna.UI2.WinForms.Guna2DataGridView dgvsanpham;
        private Guna.UI2.WinForms.Guna2Panel panelGrStaffListFooter;
        private Guna.UI2.WinForms.Guna2Panel panelGrStaffListHeader;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label lbTitle5;
        private Guna.UI2.WinForms.Guna2GroupBox grStaff;
        private System.Windows.Forms.Label lbHoten;
        private Guna.UI2.WinForms.Guna2TextBox txtgia;
        private Guna.UI2.WinForms.Guna2ComboBox cbbMaDMSP;
        private System.Windows.Forms.Label lbGioitinh;
        private System.Windows.Forms.Label lbTenNV;
        private Guna.UI2.WinForms.Guna2TextBox txttensp;
        private Guna.UI2.WinForms.Guna2ImageButton btThem;
        private Guna.UI2.WinForms.Guna2ImageButton btSua;
        private Guna.UI2.WinForms.Guna2ImageButton btXoa;
    }
}