
namespace UEH_ChaCorner
{
    partial class FAccount
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
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.mainElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelOperator = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btChangePassword = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.panelUser = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.panelOperator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragControl
            // 
            this.DragControl.ContainerControl = this;
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.UseTransparentDrag = true;
            // 
            // mainElipse
            // 
            this.mainElipse.BorderRadius = 60;
            this.mainElipse.TargetControl = this;
            // 
            // panelOperator
            // 
            this.panelOperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.panelOperator.Controls.Add(this.btChangePassword);
            this.panelOperator.Location = new System.Drawing.Point(0, 388);
            this.panelOperator.Margin = new System.Windows.Forms.Padding(2);
            this.panelOperator.Name = "panelOperator";
            this.panelOperator.Size = new System.Drawing.Size(320, 68);
            this.panelOperator.TabIndex = 6;
            // 
            // ShadowForm
            // 
            this.ShadowForm.BorderRadius = 30;
            this.ShadowForm.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ShadowForm.TargetForm = this;
            // 
            // btChangePassword
            // 
            this.btChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btChangePassword.Animated = true;
            this.btChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.btChangePassword.BorderColor = System.Drawing.Color.Transparent;
            this.btChangePassword.BorderRadius = 20;
            this.btChangePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btChangePassword.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChangePassword.ForeColor = System.Drawing.Color.White;
            this.btChangePassword.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btChangePassword.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.btChangePassword.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.btChangePassword.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChangePassword.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btChangePassword.ImageSize = new System.Drawing.Size(30, 30);
            this.btChangePassword.Location = new System.Drawing.Point(88, 12);
            this.btChangePassword.Name = "btChangePassword";
            this.btChangePassword.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.btChangePassword.ShadowDecoration.BorderRadius = 20;
            this.btChangePassword.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btChangePassword.ShadowDecoration.Depth = 8;
            this.btChangePassword.ShadowDecoration.Enabled = true;
            this.btChangePassword.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.btChangePassword.Size = new System.Drawing.Size(139, 45);
            this.btChangePassword.TabIndex = 6;
            this.btChangePassword.Text = "Đổi mật khẩu";
            this.btChangePassword.UseTransparentBackground = true;
            this.btChangePassword.Click += new System.EventHandler(this.btChangePassword_Click);
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.panelUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.panelUser.BorderRadius = 100;
            this.panelUser.BorderThickness = 1;
            this.panelUser.Controls.Add(this.btMinimize);
            this.panelUser.Controls.Add(this.btClose);
            this.panelUser.Controls.Add(this.lbRole);
            this.panelUser.Controls.Add(this.lbName);
            this.panelUser.CustomizableEdges.TopLeft = false;
            this.panelUser.CustomizableEdges.TopRight = false;
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.panelUser.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.panelUser.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.panelUser.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.panelUser.ForeColor = System.Drawing.Color.Black;
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Quality = 1;
            this.panelUser.Size = new System.Drawing.Size(320, 388);
            this.panelUser.TabIndex = 9;
            // 
            // btMinimize
            // 
            this.btMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimize.Animated = true;
            this.btMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btMinimize.BorderColor = System.Drawing.Color.Empty;
            this.btMinimize.BorderRadius = 40;
            this.btMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btMinimize.CustomIconSize = 50F;
            this.btMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btMinimize.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btMinimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btMinimize.HoverState.IconColor = System.Drawing.Color.Red;
            this.btMinimize.IconColor = System.Drawing.Color.White;
            this.btMinimize.Location = new System.Drawing.Point(239, 13);
            this.btMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btMinimize.Size = new System.Drawing.Size(30, 30);
            this.btMinimize.TabIndex = 3;
            this.btMinimize.UseTransparentBackground = true;
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.Animated = true;
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.BorderColor = System.Drawing.Color.Empty;
            this.btClose.BorderRadius = 40;
            this.btClose.CustomIconSize = 50F;
            this.btClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btClose.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btClose.HoverState.IconColor = System.Drawing.Color.Red;
            this.btClose.IconColor = System.Drawing.Color.White;
            this.btClose.Location = new System.Drawing.Point(277, 13);
            this.btClose.Margin = new System.Windows.Forms.Padding(4);
            this.btClose.Name = "btClose";
            this.btClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btClose.Size = new System.Drawing.Size(30, 30);
            this.btClose.TabIndex = 4;
            this.btClose.UseTransparentBackground = true;
            // 
            // lbRole
            // 
            this.lbRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRole.BackColor = System.Drawing.Color.Transparent;
            this.lbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.ForeColor = System.Drawing.Color.White;
            this.lbRole.Location = new System.Drawing.Point(-1, 209);
            this.lbRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(320, 42);
            this.lbRole.TabIndex = 2;
            this.lbRole.Text = "Quyền";
            this.lbRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(2, 140);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.lbName.Size = new System.Drawing.Size(315, 42);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Họ tên";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 456);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.panelOperator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAccount";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FAccount_FormClosing);
            this.Load += new System.EventHandler(this.FAccount_Load);
            this.panelOperator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panelUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2Elipse mainElipse;
        private Guna.UI2.WinForms.Guna2GradientPanel panelOperator;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Guna.UI2.WinForms.Guna2GradientTileButton btChangePassword;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelUser;
        private Guna.UI2.WinForms.Guna2ControlBox btMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox btClose;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbName;
    }
}