namespace UEH_Chacorner.Home
{
    partial class FTable
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
            this.btnDeleteTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditTable = new Guna.UI2.WinForms.Guna2Button();
            this.dgvBan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAddTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnTableDetails = new Guna.UI2.WinForms.Guna2Button();
            this.bindingSourceBan = new System.Windows.Forms.BindingSource(this.components);
            this.numThuTu = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbbTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTrangThai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblThuTu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTenBan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTenBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFilter = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnTrong = new Guna.UI2.WinForms.Guna2Button();
            this.btnCoNguoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnTatCa = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThuTu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteTable.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTable.Location = new System.Drawing.Point(333, 337);
            this.btnDeleteTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(104, 46);
            this.btnDeleteTable.TabIndex = 23;
            this.btnDeleteTable.Text = "Xóa";
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditTable
            // 
            this.btnEditTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditTable.ForeColor = System.Drawing.Color.White;
            this.btnEditTable.Location = new System.Drawing.Point(333, 387);
            this.btnEditTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(104, 46);
            this.btnEditTable.TabIndex = 22;
            this.btnEditTable.Text = "Sửa";
            this.btnEditTable.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvBan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBan.ColumnHeadersHeight = 20;
            this.dgvBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBan.Location = new System.Drawing.Point(40, 43);
            this.dgvBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBan.Name = "dgvBan";
            this.dgvBan.ReadOnly = true;
            this.dgvBan.RowHeadersVisible = false;
            this.dgvBan.RowHeadersWidth = 51;
            this.dgvBan.RowTemplate.Height = 24;
            this.dgvBan.Size = new System.Drawing.Size(432, 188);
            this.dgvBan.TabIndex = 21;
            this.dgvBan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBan.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvBan.ThemeStyle.ReadOnly = true;
            this.dgvBan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBan.ThemeStyle.RowsStyle.Height = 24;
            this.dgvBan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBan_CellClick);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(40, 7);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(93, 18);
            this.guna2HtmlLabel2.TabIndex = 28;
            this.guna2HtmlLabel2.Text = "Danh sách bàn";
            // 
            // btnAddTable
            // 
            this.btnAddTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddTable.ForeColor = System.Drawing.Color.White;
            this.btnAddTable.Location = new System.Drawing.Point(333, 287);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(104, 46);
            this.btnAddTable.TabIndex = 22;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // btnTableDetails
            // 
            this.btnTableDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTableDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTableDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTableDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTableDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTableDetails.ForeColor = System.Drawing.Color.White;
            this.btnTableDetails.Location = new System.Drawing.Point(591, 91);
            this.btnTableDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTableDetails.Name = "btnTableDetails";
            this.btnTableDetails.Size = new System.Drawing.Size(215, 46);
            this.btnTableDetails.TabIndex = 22;
            this.btnTableDetails.Text = "Thêm hóa đơn cho bàn";
            this.btnTableDetails.Click += new System.EventHandler(this.btnTableDetails_Click);
            // 
            // numThuTu
            // 
            this.numThuTu.BackColor = System.Drawing.Color.Transparent;
            this.numThuTu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numThuTu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numThuTu.Location = new System.Drawing.Point(115, 389);
            this.numThuTu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numThuTu.Name = "numThuTu";
            this.numThuTu.Size = new System.Drawing.Size(97, 44);
            this.numThuTu.TabIndex = 36;
            this.numThuTu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cbbTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbTrangThai.ItemHeight = 30;
            this.cbbTrangThai.Location = new System.Drawing.Point(128, 344);
            this.cbbTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(147, 36);
            this.cbbTrangThai.TabIndex = 35;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.lblTrangThai.Location = new System.Drawing.Point(49, 352);
            this.lblTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(66, 18);
            this.lblTrangThai.TabIndex = 32;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // lblThuTu
            // 
            this.lblThuTu.BackColor = System.Drawing.Color.Transparent;
            this.lblThuTu.Location = new System.Drawing.Point(49, 405);
            this.lblThuTu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblThuTu.Name = "lblThuTu";
            this.lblThuTu.Size = new System.Drawing.Size(42, 18);
            this.lblThuTu.TabIndex = 33;
            this.lblThuTu.Text = "Thứ tự:";
            // 
            // lblTenBan
            // 
            this.lblTenBan.BackColor = System.Drawing.Color.Transparent;
            this.lblTenBan.Location = new System.Drawing.Point(49, 302);
            this.lblTenBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(57, 18);
            this.lblTenBan.TabIndex = 34;
            this.lblTenBan.Text = "Tên Bàn:";
            // 
            // txtTenBan
            // 
            this.txtTenBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenBan.DefaultText = "";
            this.txtTenBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenBan.Location = new System.Drawing.Point(117, 283);
            this.txtTenBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.PasswordChar = '\0';
            this.txtTenBan.PlaceholderText = "";
            this.txtTenBan.SelectedText = "";
            this.txtTenBan.Size = new System.Drawing.Size(95, 48);
            this.txtTenBan.TabIndex = 31;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.Location = new System.Drawing.Point(580, 310);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(137, 18);
            this.btnFilter.TabIndex = 37;
            this.btnFilter.Text = "Lọc bàn theo trạng thái";
            // 
            // btnTrong
            // 
            this.btnTrong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTrong.ForeColor = System.Drawing.Color.White;
            this.btnTrong.Location = new System.Drawing.Point(580, 344);
            this.btnTrong.Name = "btnTrong";
            this.btnTrong.Size = new System.Drawing.Size(180, 45);
            this.btnTrong.TabIndex = 38;
            this.btnTrong.Text = "Trống";
            this.btnTrong.Click += new System.EventHandler(this.btnTrong_Click);
            // 
            // btnCoNguoi
            // 
            this.btnCoNguoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCoNguoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCoNguoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCoNguoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCoNguoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCoNguoi.ForeColor = System.Drawing.Color.White;
            this.btnCoNguoi.Location = new System.Drawing.Point(786, 344);
            this.btnCoNguoi.Name = "btnCoNguoi";
            this.btnCoNguoi.Size = new System.Drawing.Size(180, 45);
            this.btnCoNguoi.TabIndex = 39;
            this.btnCoNguoi.Text = "Có người";
            this.btnCoNguoi.Click += new System.EventHandler(this.btnCoNguoi_Click);
            // 
            // btnTatCa
            // 
            this.btnTatCa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTatCa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTatCa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTatCa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTatCa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTatCa.ForeColor = System.Drawing.Color.White;
            this.btnTatCa.Location = new System.Drawing.Point(580, 405);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(180, 45);
            this.btnTatCa.TabIndex = 40;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // FTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnTatCa);
            this.Controls.Add(this.btnCoNguoi);
            this.Controls.Add(this.btnTrong);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.numThuTu);
            this.Controls.Add(this.cbbTrangThai);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.lblThuTu);
            this.Controls.Add(this.lblTenBan);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.txtTenBan);
            this.Controls.Add(this.btnDeleteTable);
            this.Controls.Add(this.btnEditTable);
            this.Controls.Add(this.btnTableDetails);
            this.Controls.Add(this.dgvBan);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FTable";
            this.Text = "FTable";
            this.Load += new System.EventHandler(this.FTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThuTu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnDeleteTable;
        private Guna.UI2.WinForms.Guna2Button btnEditTable;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBan;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button btnAddTable;
        private Guna.UI2.WinForms.Guna2Button btnTableDetails;
        private System.Windows.Forms.BindingSource bindingSourceBan;
        private Guna.UI2.WinForms.Guna2NumericUpDown numThuTu;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTrangThai;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTrangThai;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblThuTu;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenBan;
        private Guna.UI2.WinForms.Guna2TextBox txtTenBan;
        private Guna.UI2.WinForms.Guna2HtmlLabel btnFilter;
        private Guna.UI2.WinForms.Guna2Button btnTrong;
        private Guna.UI2.WinForms.Guna2Button btnCoNguoi;
        private Guna.UI2.WinForms.Guna2Button btnTatCa;
    }
}