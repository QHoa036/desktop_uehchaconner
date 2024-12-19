namespace UEH_ChaCorner.Home
{
    partial class FCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCategory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btThem = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btSua = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btXoa = new Guna.UI2.WinForms.Guna2ImageButton();
            this.grStaff = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.txttensp = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelGrStaffListFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.panelGrStaffListHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lbTitle5 = new System.Windows.Forms.Label();
            this.dgvsanpham = new Guna.UI2.WinForms.Guna2DataGridView();
            this.grStaffList = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelRight = new Guna.UI2.WinForms.Guna2Panel();
            this.grStaff.SuspendLayout();
            this.panelGrStaffListHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).BeginInit();
            this.grStaffList.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
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
            this.btThem.Location = new System.Drawing.Point(1085, 550);
            this.btThem.Margin = new System.Windows.Forms.Padding(2);
            this.btThem.Name = "btThem";
            this.btThem.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btThem.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btThem.Size = new System.Drawing.Size(80, 80);
            this.btThem.TabIndex = 123;
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
            this.btSua.Location = new System.Drawing.Point(1085, 631);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.PressedState.Image = global::UEH_ChaCorner.Properties.Resources.edit___hover;
            this.btSua.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btSua.Size = new System.Drawing.Size(80, 80);
            this.btSua.TabIndex = 121;
            this.btSua.UseTransparentBackground = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
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
            this.btXoa.Location = new System.Drawing.Point(1085, 712);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.PressedState.Image = global::UEH_ChaCorner.Properties.Resources.delete___hover;
            this.btXoa.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btXoa.Size = new System.Drawing.Size(80, 80);
            this.btXoa.TabIndex = 122;
            this.btXoa.UseTransparentBackground = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // grStaff
            // 
            this.grStaff.BackColor = System.Drawing.Color.Transparent;
            this.grStaff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.grStaff.BorderRadius = 20;
            this.grStaff.BorderThickness = 0;
            this.grStaff.Controls.Add(this.lbTenNV);
            this.grStaff.Controls.Add(this.txttensp);
            this.grStaff.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.grStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.grStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.grStaff.ForeColor = System.Drawing.Color.White;
            this.grStaff.Location = new System.Drawing.Point(395, 522);
            this.grStaff.Margin = new System.Windows.Forms.Padding(4);
            this.grStaff.Name = "grStaff";
            this.grStaff.ShadowDecoration.BorderRadius = 20;
            this.grStaff.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.grStaff.ShadowDecoration.Depth = 40;
            this.grStaff.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7, 0, 0, 7);
            this.grStaff.Size = new System.Drawing.Size(650, 189);
            this.grStaff.TabIndex = 120;
            this.grStaff.Text = "Thông tin danh mục";
            this.grStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.grStaff.UseTransparentBackground = true;
            // 
            // lbTenNV
            // 
            this.lbTenNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.lbTenNV.Location = new System.Drawing.Point(19, 63);
            this.lbTenNV.Margin = new System.Windows.Forms.Padding(0);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(304, 29);
            this.lbTenNV.TabIndex = 76;
            this.lbTenNV.Text = "Tên danh mục";
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
            this.txttensp.Location = new System.Drawing.Point(22, 109);
            this.txttensp.Margin = new System.Windows.Forms.Padding(0);
            this.txttensp.Name = "txttensp";
            this.txttensp.PasswordChar = '\0';
            this.txttensp.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txttensp.PlaceholderText = "";
            this.txttensp.SelectedText = "";
            this.txttensp.Size = new System.Drawing.Size(610, 50);
            this.txttensp.TabIndex = 22;
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
            this.lbTitle5.Text = "Danh mục sản phẩm";
            this.lbTitle5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvsanpham
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvsanpham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvsanpham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsanpham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvsanpham.ColumnHeadersHeight = 40;
            this.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsanpham.DefaultCellStyle = dataGridViewCellStyle3;
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
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Transparent;
            this.panelRight.Controls.Add(this.grStaffList);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1425, 510);
            this.panelRight.TabIndex = 119;
            // 
            // FCategory
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
            this.Name = "FCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCategory";
            this.Load += new System.EventHandler(this.FCategory_Load);
            this.grStaff.ResumeLayout(false);
            this.panelGrStaffListHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).EndInit();
            this.grStaffList.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton btThem;
        private Guna.UI2.WinForms.Guna2ImageButton btSua;
        private Guna.UI2.WinForms.Guna2ImageButton btXoa;
        private Guna.UI2.WinForms.Guna2GroupBox grStaff;
        private System.Windows.Forms.Label lbTenNV;
        private Guna.UI2.WinForms.Guna2TextBox txttensp;
        private Guna.UI2.WinForms.Guna2Panel panelGrStaffListFooter;
        private Guna.UI2.WinForms.Guna2Panel panelGrStaffListHeader;
        private System.Windows.Forms.Label lbTitle5;
        private Guna.UI2.WinForms.Guna2DataGridView dgvsanpham;
        public Guna.UI2.WinForms.Guna2GradientPanel grStaffList;
        private Guna.UI2.WinForms.Guna2Panel panelRight;
    }
}