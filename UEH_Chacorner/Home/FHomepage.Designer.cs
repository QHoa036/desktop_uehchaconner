
namespace UEH_ChaCorner
{
    partial class FHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHomepage));
            this.mainElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelChildForm = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelSideRight = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelControl = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btAccount = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelSideLeft = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btHome = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btStaff = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btMenu = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btManage = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btStatistic = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btExit = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelChildForm.SuspendLayout();
            this.panelSideRight.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panelSideLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainElipse
            // 
            this.mainElipse.BorderRadius = 90;
            this.mainElipse.TargetControl = this;
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoSize = true;
            this.panelChildForm.BackColor = System.Drawing.Color.Transparent;
            this.panelChildForm.BorderColor = System.Drawing.Color.Transparent;
            this.panelChildForm.BorderThickness = 1;
            this.panelChildForm.Controls.Add(this.panelSideRight);
            this.panelChildForm.Controls.Add(this.panelSideLeft);
            this.panelChildForm.CustomizableEdges.BottomLeft = false;
            this.panelChildForm.CustomizableEdges.BottomRight = false;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.FillColor = System.Drawing.Color.White;
            this.panelChildForm.FillColor2 = System.Drawing.Color.White;
            this.panelChildForm.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1200, 650);
            this.panelChildForm.TabIndex = 24;
            this.panelChildForm.UseTransparentBackground = true;
            // 
            // panelSideRight
            // 
            this.panelSideRight.BackColor = System.Drawing.Color.Transparent;
            this.panelSideRight.BorderColor = System.Drawing.Color.Transparent;
            this.panelSideRight.Controls.Add(this.panelControl);
            this.panelSideRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSideRight.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.panelSideRight.Location = new System.Drawing.Point(60, 0);
            this.panelSideRight.Name = "panelSideRight";
            this.panelSideRight.Size = new System.Drawing.Size(1140, 650);
            this.panelSideRight.TabIndex = 28;
            this.panelSideRight.UseTransparentBackground = true;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.Transparent;
            this.panelControl.BorderColor = System.Drawing.Color.Transparent;
            this.panelControl.Controls.Add(this.lbUsername);
            this.panelControl.Controls.Add(this.btAccount);
            this.panelControl.Controls.Add(this.lbTitle);
            this.panelControl.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panelControl.CustomizableEdges.TopLeft = false;
            this.panelControl.CustomizableEdges.TopRight = false;
            this.panelControl.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.panelControl.Location = new System.Drawing.Point(0, 2);
            this.panelControl.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1140, 50);
            this.panelControl.TabIndex = 23;
            this.panelControl.UseTransparentBackground = true;
            // 
            // lbUsername
            // 
            this.lbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.lbUsername.Location = new System.Drawing.Point(642, 17);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbUsername.Size = new System.Drawing.Size(421, 20);
            this.lbUsername.TabIndex = 33;
            this.lbUsername.Text = "Tên";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btAccount
            // 
            this.btAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btAccount.Animated = true;
            this.btAccount.AutoRoundedCorners = true;
            this.btAccount.BackColor = System.Drawing.Color.Transparent;
            this.btAccount.BorderColor = System.Drawing.Color.Empty;
            this.btAccount.BorderRadius = 19;
            this.btAccount.FillColor = System.Drawing.Color.Empty;
            this.btAccount.FillColor2 = System.Drawing.Color.Empty;
            this.btAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btAccount.ForeColor = System.Drawing.Color.White;
            this.btAccount.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btAccount.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAccount.HoverState.Image = global::UEH_ChaCorner.Properties.Resources.user___hover;
            this.btAccount.Image = global::UEH_ChaCorner.Properties.Resources.user;
            this.btAccount.ImageSize = new System.Drawing.Size(32, 32);
            this.btAccount.Location = new System.Drawing.Point(1069, 5);
            this.btAccount.Name = "btAccount";
            this.btAccount.PressedColor = System.Drawing.Color.White;
            this.btAccount.Size = new System.Drawing.Size(40, 40);
            this.btAccount.TabIndex = 32;
            this.btAccount.UseTransparentBackground = true;
            this.btAccount.Click += new System.EventHandler(this.btAccount_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(16, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lbTitle.Size = new System.Drawing.Size(254, 50);
            this.lbTitle.TabIndex = 31;
            this.lbTitle.Text = "UEH Cha Corner";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelSideLeft
            // 
            this.panelSideLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelSideLeft.Controls.Add(this.btHome);
            this.panelSideLeft.Controls.Add(this.btStaff);
            this.panelSideLeft.Controls.Add(this.btMenu);
            this.panelSideLeft.Controls.Add(this.btManage);
            this.panelSideLeft.Controls.Add(this.btStatistic);
            this.panelSideLeft.Controls.Add(this.btExit);
            this.panelSideLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideLeft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.panelSideLeft.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.panelSideLeft.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelSideLeft.Location = new System.Drawing.Point(0, 0);
            this.panelSideLeft.Margin = new System.Windows.Forms.Padding(2);
            this.panelSideLeft.Name = "panelSideLeft";
            this.panelSideLeft.Size = new System.Drawing.Size(60, 650);
            this.panelSideLeft.TabIndex = 24;
            // 
            // btHome
            // 
            this.btHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btHome.Animated = true;
            this.btHome.BackColor = System.Drawing.Color.Transparent;
            this.btHome.BorderColor = System.Drawing.Color.Empty;
            this.btHome.FillColor = System.Drawing.Color.Empty;
            this.btHome.FillColor2 = System.Drawing.Color.Empty;
            this.btHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btHome.ForeColor = System.Drawing.Color.White;
            this.btHome.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btHome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.btHome.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.btHome.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.btHome.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.btHome.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.HoverState.Image = global::UEH_ChaCorner.Properties.Resources.home___hover;
            this.btHome.Image = global::UEH_ChaCorner.Properties.Resources.home;
            this.btHome.ImageSize = new System.Drawing.Size(24, 24);
            this.btHome.Location = new System.Drawing.Point(0, 161);
            this.btHome.Name = "btHome";
            this.btHome.PressedColor = System.Drawing.Color.White;
            this.btHome.Size = new System.Drawing.Size(60, 40);
            this.btHome.TabIndex = 29;
            this.btHome.UseTransparentBackground = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // btStaff
            // 
            this.btStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btStaff.Animated = true;
            this.btStaff.BackColor = System.Drawing.Color.Transparent;
            this.btStaff.BorderColor = System.Drawing.Color.Empty;
            this.btStaff.FillColor = System.Drawing.Color.Empty;
            this.btStaff.FillColor2 = System.Drawing.Color.Empty;
            this.btStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btStaff.ForeColor = System.Drawing.Color.White;
            this.btStaff.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btStaff.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.btStaff.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.btStaff.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStaff.HoverState.Image = global::UEH_ChaCorner.Properties.Resources.people_hover;
            this.btStaff.Image = ((System.Drawing.Image)(resources.GetObject("btStaff.Image")));
            this.btStaff.ImageSize = new System.Drawing.Size(32, 32);
            this.btStaff.Location = new System.Drawing.Point(0, 375);
            this.btStaff.Name = "btStaff";
            this.btStaff.PressedColor = System.Drawing.Color.White;
            this.btStaff.Size = new System.Drawing.Size(60, 40);
            this.btStaff.TabIndex = 28;
            this.btStaff.UseTransparentBackground = true;
            this.btStaff.Click += new System.EventHandler(this.btStaff_Click);
            // 
            // btMenu
            // 
            this.btMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btMenu.Animated = true;
            this.btMenu.BackColor = System.Drawing.Color.Transparent;
            this.btMenu.FillColor = System.Drawing.Color.Empty;
            this.btMenu.FillColor2 = System.Drawing.Color.Empty;
            this.btMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btMenu.ForeColor = System.Drawing.Color.White;
            this.btMenu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btMenu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.btMenu.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.btMenu.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenu.HoverState.Image = global::UEH_ChaCorner.Properties.Resources.bubble_tea_hover;
            this.btMenu.Image = global::UEH_ChaCorner.Properties.Resources.bubble_tea;
            this.btMenu.ImageSize = new System.Drawing.Size(32, 32);
            this.btMenu.Location = new System.Drawing.Point(0, 303);
            this.btMenu.Name = "btMenu";
            this.btMenu.PressedColor = System.Drawing.Color.White;
            this.btMenu.Size = new System.Drawing.Size(60, 40);
            this.btMenu.TabIndex = 26;
            this.btMenu.UseTransparentBackground = true;
            // 
            // btManage
            // 
            this.btManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btManage.Animated = true;
            this.btManage.BackColor = System.Drawing.Color.Transparent;
            this.btManage.BorderColor = System.Drawing.Color.Empty;
            this.btManage.FillColor = System.Drawing.Color.Empty;
            this.btManage.FillColor2 = System.Drawing.Color.Empty;
            this.btManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btManage.ForeColor = System.Drawing.Color.White;
            this.btManage.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btManage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.btManage.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.btManage.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.btManage.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.btManage.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btManage.HoverState.Image = global::UEH_ChaCorner.Properties.Resources.table_hover;
            this.btManage.Image = global::UEH_ChaCorner.Properties.Resources.table;
            this.btManage.ImageSize = new System.Drawing.Size(32, 32);
            this.btManage.Location = new System.Drawing.Point(0, 231);
            this.btManage.Name = "btManage";
            this.btManage.PressedColor = System.Drawing.Color.White;
            this.btManage.Size = new System.Drawing.Size(60, 40);
            this.btManage.TabIndex = 27;
            this.btManage.UseTransparentBackground = true;
            // 
            // btStatistic
            // 
            this.btStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btStatistic.Animated = true;
            this.btStatistic.BackColor = System.Drawing.Color.Transparent;
            this.btStatistic.FillColor = System.Drawing.Color.Empty;
            this.btStatistic.FillColor2 = System.Drawing.Color.Empty;
            this.btStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStatistic.ForeColor = System.Drawing.Color.White;
            this.btStatistic.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btStatistic.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.btStatistic.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.btStatistic.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStatistic.HoverState.Image = global::UEH_ChaCorner.Properties.Resources.statistic_hover;
            this.btStatistic.Image = global::UEH_ChaCorner.Properties.Resources.statistic;
            this.btStatistic.ImageSize = new System.Drawing.Size(32, 32);
            this.btStatistic.Location = new System.Drawing.Point(0, 447);
            this.btStatistic.Name = "btStatistic";
            this.btStatistic.PressedColor = System.Drawing.Color.White;
            this.btStatistic.Size = new System.Drawing.Size(60, 40);
            this.btStatistic.TabIndex = 25;
            this.btStatistic.UseTransparentBackground = true;
            this.btStatistic.Click += new System.EventHandler(this.btStatistic_Click);
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.Animated = true;
            this.btExit.BackColor = System.Drawing.Color.Transparent;
            this.btExit.FillColor = System.Drawing.Color.Empty;
            this.btExit.FillColor2 = System.Drawing.Color.Empty;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btExit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.btExit.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.btExit.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.HoverState.Image = global::UEH_ChaCorner.Properties.Resources.log_out_hover;
            this.btExit.Image = global::UEH_ChaCorner.Properties.Resources.log_out;
            this.btExit.ImageSize = new System.Drawing.Size(28, 28);
            this.btExit.Location = new System.Drawing.Point(0, 584);
            this.btExit.Name = "btExit";
            this.btExit.PressedColor = System.Drawing.Color.White;
            this.btExit.Size = new System.Drawing.Size(60, 40);
            this.btExit.TabIndex = 16;
            this.btExit.UseTransparentBackground = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // DragControl2
            // 
            this.DragControl2.DockForm = true;
            this.DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl2.UseTransparentDrag = true;
            // 
            // DragControl1
            // 
            this.DragControl1.DockForm = true;
            this.DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl1.UseTransparentDrag = true;
            // 
            // FHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.panelChildForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.FMainMenu_Load);
            this.panelChildForm.ResumeLayout(false);
            this.panelSideRight.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panelSideLeft.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse mainElipse;
        private Guna.UI2.WinForms.Guna2GradientPanel panelChildForm;
        private Guna.UI2.WinForms.Guna2GradientPanel panelSideRight;
        private Guna.UI2.WinForms.Guna2GradientPanel panelSideLeft;
        private Guna.UI2.WinForms.Guna2GradientTileButton btStaff;
        private Guna.UI2.WinForms.Guna2GradientTileButton btMenu;
        private Guna.UI2.WinForms.Guna2GradientTileButton btManage;
        private Guna.UI2.WinForms.Guna2GradientTileButton btStatistic;
        private Guna.UI2.WinForms.Guna2GradientTileButton btExit;
        private Guna.UI2.WinForms.Guna2DragControl DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl DragControl1;
        private Guna.UI2.WinForms.Guna2GradientPanel panelControl;
        private System.Windows.Forms.Label lbUsername;
        private Guna.UI2.WinForms.Guna2GradientTileButton btAccount;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2GradientTileButton btHome;
    }
}