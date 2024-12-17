namespace UEH_ChaCorner.Home
{
    partial class FStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelRight = new Guna.UI2.WinForms.Guna2Panel();
            this.grStaffList = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.dgvStaff = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelGrStaffListFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.panelGrStaffListHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTitle5 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btSua = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btXoa = new Guna.UI2.WinForms.Guna2ImageButton();
            this.grStaff = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.lbHoten = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbGioitinh = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.txtTenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelRight.SuspendLayout();
            this.grStaffList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.panelGrStaffListHeader.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.grStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Transparent;
            this.panelRight.Controls.Add(this.grStaffList);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(560, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(580, 650);
            this.panelRight.TabIndex = 21;
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
            this.grStaffList.Controls.Add(this.dgvStaff);
            this.grStaffList.Controls.Add(this.panelGrStaffListFooter);
            this.grStaffList.Controls.Add(this.panelGrStaffListHeader);
            this.grStaffList.FillColor = System.Drawing.Color.White;
            this.grStaffList.FillColor2 = System.Drawing.Color.White;
            this.grStaffList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.grStaffList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.grStaffList.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grStaffList.Location = new System.Drawing.Point(13, 12);
            this.grStaffList.Name = "grStaffList";
            this.grStaffList.ShadowDecoration.BorderRadius = 30;
            this.grStaffList.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(68)))), ((int)(((byte)(54)))));
            this.grStaffList.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.grStaffList.Size = new System.Drawing.Size(555, 626);
            this.grStaffList.TabIndex = 98;
            // 
            // dgvStaff
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStaff.ColumnHeadersHeight = 40;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaff.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.dgvStaff.Location = new System.Drawing.Point(0, 60);
            this.dgvStaff.Margin = new System.Windows.Forms.Padding(16);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.RowHeadersWidth = 51;
            this.dgvStaff.RowTemplate.Height = 30;
            this.dgvStaff.Size = new System.Drawing.Size(555, 525);
            this.dgvStaff.TabIndex = 45;
            this.dgvStaff.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStaff.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStaff.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStaff.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStaff.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStaff.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvStaff.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.dgvStaff.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(42)))));
            this.dgvStaff.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStaff.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStaff.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStaff.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStaff.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvStaff.ThemeStyle.ReadOnly = true;
            this.dgvStaff.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStaff.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvStaff.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStaff.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.dgvStaff.ThemeStyle.RowsStyle.Height = 30;
            this.dgvStaff.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.dgvStaff.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
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
            this.panelGrStaffListFooter.Location = new System.Drawing.Point(0, 585);
            this.panelGrStaffListFooter.Margin = new System.Windows.Forms.Padding(2);
            this.panelGrStaffListFooter.Name = "panelGrStaffListFooter";
            this.panelGrStaffListFooter.Size = new System.Drawing.Size(555, 41);
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
            this.panelGrStaffListHeader.Name = "panelGrStaffListHeader";
            this.panelGrStaffListHeader.Size = new System.Drawing.Size(555, 60);
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
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconRight = global::UEH_ChaCorner.Properties.Resources.search;
            this.txtSearch.IconRightOffset = new System.Drawing.Point(8, 0);
            this.txtSearch.IconRightSize = new System.Drawing.Size(16, 16);
            this.txtSearch.Location = new System.Drawing.Point(341, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(8, 3, 2, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(24);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Tìm kiếm nhân viên";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(210, 40);
            this.txtSearch.TabIndex = 39;
            this.txtSearch.TextChanged += new System.EventHandler(this.btnSearch_TextChanged);
            // 
            // lbTitle5
            // 
            this.lbTitle5.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle5.ForeColor = System.Drawing.Color.White;
            this.lbTitle5.Location = new System.Drawing.Point(0, 0);
            this.lbTitle5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle5.Name = "lbTitle5";
            this.lbTitle5.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lbTitle5.Size = new System.Drawing.Size(239, 60);
            this.lbTitle5.TabIndex = 38;
            this.lbTitle5.Text = "Danh sách nhân viên";
            this.lbTitle5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.Controls.Add(this.btSua);
            this.panelLeft.Controls.Add(this.btXoa);
            this.panelLeft.Controls.Add(this.grStaff);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(560, 650);
            this.panelLeft.TabIndex = 22;
            // 
            // btSua
            // 
            this.btSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSua.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btSua.HoverState.Image = global::UEH_ChaCorner.Properties.Resources.edit___hover;
            this.btSua.HoverState.ImageSize = new System.Drawing.Size(60, 60);
            this.btSua.Image = global::UEH_ChaCorner.Properties.Resources.edit;
            this.btSua.ImageOffset = new System.Drawing.Point(0, 0);
            this.btSua.ImageRotate = 0F;
            this.btSua.ImageSize = new System.Drawing.Size(60, 60);
            this.btSua.Location = new System.Drawing.Point(203, 513);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.PressedState.Image = global::UEH_ChaCorner.Properties.Resources.edit___hover;
            this.btSua.PressedState.ImageSize = new System.Drawing.Size(60, 60);
            this.btSua.Size = new System.Drawing.Size(68, 60);
            this.btSua.TabIndex = 93;
            this.btSua.UseTransparentBackground = true;
            this.btSua.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btXoa.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btXoa.HoverState.Image = global::UEH_ChaCorner.Properties.Resources.delete___hover;
            this.btXoa.HoverState.ImageSize = new System.Drawing.Size(60, 60);
            this.btXoa.Image = global::UEH_ChaCorner.Properties.Resources.delete;
            this.btXoa.ImageOffset = new System.Drawing.Point(0, 0);
            this.btXoa.ImageRotate = 0F;
            this.btXoa.ImageSize = new System.Drawing.Size(60, 60);
            this.btXoa.Location = new System.Drawing.Point(299, 513);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.PressedState.Image = global::UEH_ChaCorner.Properties.Resources.delete___hover;
            this.btXoa.PressedState.ImageSize = new System.Drawing.Size(60, 60);
            this.btXoa.Size = new System.Drawing.Size(68, 60);
            this.btXoa.TabIndex = 94;
            this.btXoa.UseTransparentBackground = true;
            this.btXoa.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grStaff
            // 
            this.grStaff.BackColor = System.Drawing.Color.Transparent;
            this.grStaff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.grStaff.BorderRadius = 20;
            this.grStaff.Controls.Add(this.lbNgaysinh);
            this.grStaff.Controls.Add(this.lbHoten);
            this.grStaff.Controls.Add(this.txtSDT);
            this.grStaff.Controls.Add(this.dtpNgaySinh);
            this.grStaff.Controls.Add(this.txtGioiTinh);
            this.grStaff.Controls.Add(this.lbGioitinh);
            this.grStaff.Controls.Add(this.lbTenNV);
            this.grStaff.Controls.Add(this.txtTenNV);
            this.grStaff.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.grStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.grStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.grStaff.ForeColor = System.Drawing.Color.White;
            this.grStaff.Location = new System.Drawing.Point(12, 205);
            this.grStaff.Name = "grStaff";
            this.grStaff.ShadowDecoration.BorderRadius = 20;
            this.grStaff.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.grStaff.ShadowDecoration.Depth = 40;
            this.grStaff.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7, 0, 0, 7);
            this.grStaff.Size = new System.Drawing.Size(542, 235);
            this.grStaff.TabIndex = 92;
            this.grStaff.Text = "Thông tin nhân viên";
            this.grStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.grStaff.UseTransparentBackground = true;
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaysinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.lbNgaysinh.Location = new System.Drawing.Point(284, 136);
            this.lbNgaysinh.Margin = new System.Windows.Forms.Padding(0);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(240, 23);
            this.lbNgaysinh.TabIndex = 89;
            this.lbNgaysinh.Text = "Ngày sinh";
            this.lbNgaysinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbHoten
            // 
            this.lbHoten.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.lbHoten.Location = new System.Drawing.Point(16, 136);
            this.lbHoten.Margin = new System.Windows.Forms.Padding(0);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(243, 23);
            this.lbHoten.TabIndex = 88;
            this.lbHoten.Text = "Số điện thoại";
            this.lbHoten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSDT
            // 
            this.txtSDT.Animated = true;
            this.txtSDT.BackColor = System.Drawing.Color.Transparent;
            this.txtSDT.BorderColor = System.Drawing.Color.Transparent;
            this.txtSDT.BorderRadius = 4;
            this.txtSDT.BorderThickness = 0;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(96)))), ((int)(((byte)(48)))));
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(151)))), ((int)(((byte)(59)))));
            this.txtSDT.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.txtSDT.IconLeftSize = new System.Drawing.Size(14, 14);
            this.txtSDT.Location = new System.Drawing.Point(19, 170);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Padding = new System.Windows.Forms.Padding(4);
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.ShadowDecoration.BorderRadius = 13;
            this.txtSDT.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.txtSDT.Size = new System.Drawing.Size(240, 40);
            this.txtSDT.TabIndex = 87;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Animated = true;
            this.dtpNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.dtpNgaySinh.BorderColor = System.Drawing.Color.Transparent;
            this.dtpNgaySinh.BorderRadius = 4;
            this.dtpNgaySinh.Checked = true;
            this.dtpNgaySinh.CheckedState.FillColor = System.Drawing.Color.White;
            this.dtpNgaySinh.FillColor = System.Drawing.Color.White;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpNgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.HoverState.ForeColor = System.Drawing.Color.Black;
            this.dtpNgaySinh.Location = new System.Drawing.Point(284, 170);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Padding = new System.Windows.Forms.Padding(4);
            this.dtpNgaySinh.ShadowDecoration.BorderRadius = 12;
            this.dtpNgaySinh.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.dtpNgaySinh.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.dtpNgaySinh.Size = new System.Drawing.Size(240, 40);
            this.dtpNgaySinh.TabIndex = 86;
            this.dtpNgaySinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpNgaySinh.UseTransparentBackground = true;
            this.dtpNgaySinh.Value = new System.DateTime(2021, 5, 14, 14, 29, 30, 350);
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Animated = true;
            this.txtGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.txtGioiTinh.BorderColor = System.Drawing.Color.Transparent;
            this.txtGioiTinh.BorderRadius = 4;
            this.txtGioiTinh.BorderThickness = 0;
            this.txtGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGioiTinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(96)))), ((int)(((byte)(48)))));
            this.txtGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(96)))), ((int)(((byte)(48)))));
            this.txtGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txtGioiTinh.FormattingEnabled = true;
            this.txtGioiTinh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(151)))), ((int)(((byte)(59)))));
            this.txtGioiTinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtGioiTinh.ItemHeight = 34;
            this.txtGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtGioiTinh.Location = new System.Drawing.Point(284, 85);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(240, 40);
            this.txtGioiTinh.StartIndex = 0;
            this.txtGioiTinh.TabIndex = 85;
            this.txtGioiTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbGioitinh
            // 
            this.lbGioitinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioitinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.lbGioitinh.Location = new System.Drawing.Point(284, 51);
            this.lbGioitinh.Margin = new System.Windows.Forms.Padding(0);
            this.lbGioitinh.Name = "lbGioitinh";
            this.lbGioitinh.Size = new System.Drawing.Size(240, 23);
            this.lbGioitinh.TabIndex = 77;
            this.lbGioitinh.Text = "Giới tính";
            this.lbGioitinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTenNV
            // 
            this.lbTenNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.lbTenNV.Location = new System.Drawing.Point(16, 51);
            this.lbTenNV.Margin = new System.Windows.Forms.Padding(0);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(243, 23);
            this.lbTenNV.TabIndex = 76;
            this.lbTenNV.Text = "Họ tên";
            this.lbTenNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Animated = true;
            this.txtTenNV.BorderColor = System.Drawing.Color.White;
            this.txtTenNV.BorderRadius = 4;
            this.txtTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNV.DefaultText = "";
            this.txtTenNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txtTenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.Location = new System.Drawing.Point(19, 85);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(0);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.PasswordChar = '\0';
            this.txtTenNV.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txtTenNV.PlaceholderText = "";
            this.txtTenNV.SelectedText = "";
            this.txtTenNV.Size = new System.Drawing.Size(240, 40);
            this.txtTenNV.TabIndex = 22;
            // 
            // FStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 650);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FStaff";
            this.Load += new System.EventHandler(this.FManageStaff_Load);
            this.panelRight.ResumeLayout(false);
            this.grStaffList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.panelGrStaffListHeader.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.grStaff.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelRight;
        public Guna.UI2.WinForms.Guna2GradientPanel grStaffList;
        private Guna.UI2.WinForms.Guna2Panel panelGrStaffListFooter;
        private Guna.UI2.WinForms.Guna2Panel panelGrStaffListHeader;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label lbTitle5;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStaff;
        private System.Windows.Forms.Panel panelLeft;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNV;
        private Guna.UI2.WinForms.Guna2GroupBox grStaff;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label lbGioitinh;
        private Guna.UI2.WinForms.Guna2ComboBox txtGioiTinh;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lbNgaysinh;
        private System.Windows.Forms.Label lbHoten;
        private Guna.UI2.WinForms.Guna2ImageButton btSua;
        private Guna.UI2.WinForms.Guna2ImageButton btXoa;
    }
}