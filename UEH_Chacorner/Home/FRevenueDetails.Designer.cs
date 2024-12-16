namespace UEH_ChaCorner.Home
{
    partial class FRevenueDetails
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
            this.lblMaHD = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvCTHD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtThanhTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblThanhTien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bindingSourceCTHD = new System.Windows.Forms.BindingSource(this.components);
            this.btnExportToWord = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaHD
            // 
            this.lblMaHD.BackColor = System.Drawing.Color.Transparent;
            this.lblMaHD.Location = new System.Drawing.Point(51, 44);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(87, 18);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã hóa đơn: ?";
            // 
            // dgvCTHD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCTHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCTHD.ColumnHeadersHeight = 40;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTHD.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCTHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCTHD.Location = new System.Drawing.Point(29, 84);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersVisible = false;
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.RowTemplate.Height = 24;
            this.dgvCTHD.Size = new System.Drawing.Size(718, 150);
            this.dgvCTHD.TabIndex = 1;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCTHD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCTHD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCTHD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCTHD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCTHD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvCTHD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCTHD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCTHD.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvCTHD.ThemeStyle.ReadOnly = false;
            this.dgvCTHD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCTHD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCTHD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvCTHD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCTHD.ThemeStyle.RowsStyle.Height = 24;
            this.dgvCTHD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCTHD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThanhTien.DefaultText = "";
            this.txtThanhTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThanhTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThanhTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThanhTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtThanhTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThanhTien.Location = new System.Drawing.Point(51, 317);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.PasswordChar = '\0';
            this.txtThanhTien.PlaceholderText = "";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.SelectedText = "";
            this.txtThanhTien.Size = new System.Drawing.Size(229, 48);
            this.txtThanhTien.TabIndex = 2;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.BackColor = System.Drawing.Color.Transparent;
            this.lblThanhTien.Location = new System.Drawing.Point(51, 292);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(97, 18);
            this.lblThanhTien.TabIndex = 3;
            this.lblThanhTien.Text = "Tổng thành tiền:";
            // 
            // btnExportToWord
            // 
            this.btnExportToWord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportToWord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportToWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportToWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportToWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportToWord.ForeColor = System.Drawing.Color.White;
            this.btnExportToWord.Location = new System.Drawing.Point(567, 317);
            this.btnExportToWord.Name = "btnExportToWord";
            this.btnExportToWord.Size = new System.Drawing.Size(180, 45);
            this.btnExportToWord.TabIndex = 4;
            this.btnExportToWord.Text = "Xuất hóa đơn";
            this.btnExportToWord.Click += new System.EventHandler(this.btnExportToWord_Click);
            // 
            // FRevenueDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExportToWord);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.lblMaHD);
            this.Name = "FRevenueDetails";
            this.Text = "FRevenueDetails";
            this.Load += new System.EventHandler(this.FRevenueDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaHD;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCTHD;
        private Guna.UI2.WinForms.Guna2TextBox txtThanhTien;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblThanhTien;
        private System.Windows.Forms.BindingSource bindingSourceCTHD;
        private Guna.UI2.WinForms.Guna2Button btnExportToWord;
    }
}