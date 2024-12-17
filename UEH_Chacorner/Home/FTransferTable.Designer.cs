namespace UEH_Chacorner.Home
{
    partial class FTransferTable
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
            this.cmbCurrentTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbNewTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnConfirmTransfer = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // cmbCurrentTable
            // 
            this.cmbCurrentTable.BackColor = System.Drawing.Color.Transparent;
            this.cmbCurrentTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCurrentTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrentTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCurrentTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCurrentTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCurrentTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCurrentTable.ItemHeight = 30;
            this.cmbCurrentTable.Location = new System.Drawing.Point(29, 51);
            this.cmbCurrentTable.Name = "cmbCurrentTable";
            this.cmbCurrentTable.Size = new System.Drawing.Size(140, 36);
            this.cmbCurrentTable.TabIndex = 0;
            // 
            // cmbNewTable
            // 
            this.cmbNewTable.BackColor = System.Drawing.Color.Transparent;
            this.cmbNewTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNewTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNewTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNewTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNewTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbNewTable.ItemHeight = 30;
            this.cmbNewTable.Location = new System.Drawing.Point(207, 51);
            this.cmbNewTable.Name = "cmbNewTable";
            this.cmbNewTable.Size = new System.Drawing.Size(140, 36);
            this.cmbNewTable.TabIndex = 0;
            // 
            // btnConfirmTransfer
            // 
            this.btnConfirmTransfer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmTransfer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmTransfer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmTransfer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmTransfer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfirmTransfer.ForeColor = System.Drawing.Color.White;
            this.btnConfirmTransfer.Location = new System.Drawing.Point(29, 137);
            this.btnConfirmTransfer.Name = "btnConfirmTransfer";
            this.btnConfirmTransfer.Size = new System.Drawing.Size(140, 45);
            this.btnConfirmTransfer.TabIndex = 1;
            this.btnConfirmTransfer.Text = "Xác nhận chuyển bàn";
            this.btnConfirmTransfer.Click += new System.EventHandler(this.btnConfirmTransfer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(207, 137);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 45);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FTransferTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 225);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmTransfer);
            this.Controls.Add(this.cmbNewTable);
            this.Controls.Add(this.cmbCurrentTable);
            this.Name = "FTransferTable";
            this.Text = "FTransferTable";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmbCurrentTable;
        private Guna.UI2.WinForms.Guna2ComboBox cmbNewTable;
        private Guna.UI2.WinForms.Guna2Button btnConfirmTransfer;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}