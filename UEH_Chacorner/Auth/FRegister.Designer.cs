
namespace UEH_ChaCorner
{
    partial class FRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRegister));
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.AnimatedWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SidePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnRegister = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtFullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.imgLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.MainElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ImgPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPic)).BeginInit();
            this.SuspendLayout();
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.SidePanel;
            this.DragControl.UseTransparentDrag = true;
            // 
            // ShadowForm
            // 
            this.ShadowForm.BorderRadius = 6;
            this.ShadowForm.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ShadowForm.TargetForm = this;
            // 
            // AnimatedWindow
            // 
            this.AnimatedWindow.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.AnimatedWindow.TargetForm = this;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Animated = true;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BorderRadius = 4;
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.CustomIconSize = 50F;
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnMinimize.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMinimize.HoverState.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1098, 20);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 12;
            this.btnMinimize.UseTransparentBackground = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Animated = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderRadius = 4;
            this.btnExit.CustomIconSize = 50F;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnExit.HoverState.IconColor = System.Drawing.Color.White;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1136, 20);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 14;
            this.btnExit.UseTransparentBackground = true;
            // 
            // SidePanel
            // 
            this.SidePanel.Controls.Add(this.btnBack);
            this.SidePanel.Controls.Add(this.btnRegister);
            this.SidePanel.Controls.Add(this.txtPhone);
            this.SidePanel.Controls.Add(this.txtGender);
            this.SidePanel.Controls.Add(this.txtDOB);
            this.SidePanel.Controls.Add(this.txtFullname);
            this.SidePanel.Controls.Add(this.txtPassword);
            this.SidePanel.Controls.Add(this.txtUsername);
            this.SidePanel.Controls.Add(this.imgLogo);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SidePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.SidePanel.Location = new System.Drawing.Point(698, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(502, 650);
            this.SidePanel.TabIndex = 13;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnBack.Animated = true;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderRadius = 10;
            this.btnBack.FillColor = System.Drawing.Color.Empty;
            this.btnBack.FillColor2 = System.Drawing.Color.Empty;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnBack.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnBack.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Location = new System.Drawing.Point(191, 573);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(2);
            this.btnBack.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(234)))), ((int)(((byte)(226)))));
            this.btnBack.ShadowDecoration.BorderRadius = 20;
            this.btnBack.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.btnBack.ShadowDecoration.Depth = 8;
            this.btnBack.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.btnBack.Size = new System.Drawing.Size(115, 34);
            this.btnBack.TabIndex = 89;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseTransparentBackground = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRegister.Animated = true;
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BorderColor = System.Drawing.Color.Transparent;
            this.btnRegister.BorderRadius = 10;
            this.btnRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnRegister.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(234)))), ((int)(((byte)(226)))));
            this.btnRegister.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(234)))), ((int)(((byte)(226)))));
            this.btnRegister.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.btnRegister.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRegister.Location = new System.Drawing.Point(134, 504);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Padding = new System.Windows.Forms.Padding(2);
            this.btnRegister.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(234)))), ((int)(((byte)(226)))));
            this.btnRegister.ShadowDecoration.BorderRadius = 20;
            this.btnRegister.ShadowDecoration.Color = System.Drawing.Color.DarkGray;
            this.btnRegister.ShadowDecoration.Depth = 8;
            this.btnRegister.ShadowDecoration.Enabled = true;
            this.btnRegister.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.btnRegister.Size = new System.Drawing.Size(229, 50);
            this.btnRegister.TabIndex = 87;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.UseTransparentBackground = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPhone.Animated = true;
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BorderColor = System.Drawing.Color.Transparent;
            this.txtPhone.BorderRadius = 4;
            this.txtPhone.BorderThickness = 0;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(96)))), ((int)(((byte)(48)))));
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(151)))), ((int)(((byte)(59)))));
            this.txtPhone.IconLeft = global::UEH_ChaCorner.Properties.Resources.telephone;
            this.txtPhone.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.txtPhone.IconLeftSize = new System.Drawing.Size(14, 14);
            this.txtPhone.Location = new System.Drawing.Point(37, 422);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(4);
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txtPhone.PlaceholderText = "Số điện thoại";
            this.txtPhone.SelectedText = "";
            this.txtPhone.ShadowDecoration.BorderRadius = 13;
            this.txtPhone.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.txtPhone.Size = new System.Drawing.Size(203, 50);
            this.txtPhone.TabIndex = 85;
            // 
            // txtGender
            // 
            this.txtGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtGender.Animated = true;
            this.txtGender.BackColor = System.Drawing.Color.Transparent;
            this.txtGender.BorderColor = System.Drawing.Color.Transparent;
            this.txtGender.BorderRadius = 4;
            this.txtGender.BorderThickness = 0;
            this.txtGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(96)))), ((int)(((byte)(48)))));
            this.txtGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(96)))), ((int)(((byte)(48)))));
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txtGender.FormattingEnabled = true;
            this.txtGender.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(151)))), ((int)(((byte)(59)))));
            this.txtGender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtGender.ItemHeight = 44;
            this.txtGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtGender.Location = new System.Drawing.Point(265, 422);
            this.txtGender.Margin = new System.Windows.Forms.Padding(4);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(203, 50);
            this.txtGender.TabIndex = 84;
            this.txtGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDOB
            // 
            this.txtDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDOB.Animated = true;
            this.txtDOB.BackColor = System.Drawing.Color.Transparent;
            this.txtDOB.BorderColor = System.Drawing.Color.Transparent;
            this.txtDOB.BorderRadius = 4;
            this.txtDOB.Checked = true;
            this.txtDOB.CheckedState.FillColor = System.Drawing.Color.White;
            this.txtDOB.FillColor = System.Drawing.Color.White;
            this.txtDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDOB.HoverState.ForeColor = System.Drawing.Color.Black;
            this.txtDOB.Location = new System.Drawing.Point(265, 338);
            this.txtDOB.Margin = new System.Windows.Forms.Padding(4);
            this.txtDOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Padding = new System.Windows.Forms.Padding(4);
            this.txtDOB.ShadowDecoration.BorderRadius = 12;
            this.txtDOB.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(49)))), ((int)(((byte)(46)))));
            this.txtDOB.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.txtDOB.Size = new System.Drawing.Size(203, 50);
            this.txtDOB.TabIndex = 63;
            this.txtDOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDOB.UseTransparentBackground = true;
            this.txtDOB.Value = new System.DateTime(2021, 5, 14, 14, 29, 30, 350);
            // 
            // txtFullname
            // 
            this.txtFullname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtFullname.Animated = true;
            this.txtFullname.BackColor = System.Drawing.Color.Transparent;
            this.txtFullname.BorderColor = System.Drawing.Color.Transparent;
            this.txtFullname.BorderRadius = 4;
            this.txtFullname.BorderThickness = 0;
            this.txtFullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullname.DefaultText = "";
            this.txtFullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(96)))), ((int)(((byte)(48)))));
            this.txtFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txtFullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullname.IconLeft = global::UEH_ChaCorner.Properties.Resources.user1;
            this.txtFullname.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.txtFullname.IconLeftSize = new System.Drawing.Size(14, 14);
            this.txtFullname.Location = new System.Drawing.Point(37, 338);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Padding = new System.Windows.Forms.Padding(4);
            this.txtFullname.PasswordChar = '\0';
            this.txtFullname.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txtFullname.PlaceholderText = "Họ tên";
            this.txtFullname.SelectedText = "";
            this.txtFullname.Size = new System.Drawing.Size(203, 50);
            this.txtFullname.TabIndex = 82;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPassword.Animated = true;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderRadius = 4;
            this.txtPassword.BorderThickness = 0;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(96)))), ((int)(((byte)(48)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.IconLeft = global::UEH_ChaCorner.Properties.Resources.shield;
            this.txtPassword.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.txtPassword.IconLeftSize = new System.Drawing.Size(14, 14);
            this.txtPassword.Location = new System.Drawing.Point(265, 254);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(4);
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txtPassword.PlaceholderText = "Mật khẩu";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(203, 50);
            this.txtPassword.TabIndex = 81;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtUsername.Animated = true;
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderRadius = 4;
            this.txtUsername.BorderThickness = 0;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(96)))), ((int)(((byte)(48)))));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.IconLeft = global::UEH_ChaCorner.Properties.Resources.user1;
            this.txtUsername.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.txtUsername.IconLeftSize = new System.Drawing.Size(14, 14);
            this.txtUsername.Location = new System.Drawing.Point(37, 254);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(4);
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.txtUsername.PlaceholderText = "Tên đăng nhập";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(203, 50);
            this.txtUsername.TabIndex = 80;
            // 
            // imgLogo
            // 
            this.imgLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.imgLogo.AutoRoundedCorners = true;
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.BorderRadius = 134;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.ImageRotate = 0F;
            this.imgLogo.Location = new System.Drawing.Point(98, -13);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(293, 270);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 88;
            this.imgLogo.TabStop = false;
            this.imgLogo.UseTransparentBackground = true;
            // 
            // MainElipse
            // 
            this.MainElipse.BorderRadius = 90;
            this.MainElipse.TargetControl = this;
            // 
            // ImgPic
            // 
            this.ImgPic.BackColor = System.Drawing.Color.Transparent;
            this.ImgPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImgPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgPic.FillColor = System.Drawing.Color.Transparent;
            this.ImgPic.Image = ((System.Drawing.Image)(resources.GetObject("ImgPic.Image")));
            this.ImgPic.ImageRotate = 0F;
            this.ImgPic.Location = new System.Drawing.Point(0, 0);
            this.ImgPic.Margin = new System.Windows.Forms.Padding(2);
            this.ImgPic.Name = "ImgPic";
            this.ImgPic.Size = new System.Drawing.Size(698, 650);
            this.ImgPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgPic.TabIndex = 16;
            this.ImgPic.TabStop = false;
            this.ImgPic.UseTransparentBackground = true;
            // 
            // DragControl2
            // 
            this.DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl2.TargetControl = this.ImgPic;
            this.DragControl2.UseTransparentDrag = true;
            // 
            // FRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.ImgPic);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1200, 650);
            this.Name = "FRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRegister";
            this.Load += new System.EventHandler(this.FRegister_Load);
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private Guna.UI2.WinForms.Guna2AnimateWindow AnimatedWindow;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private Guna.UI2.WinForms.Guna2Panel SidePanel;
        private Guna.UI2.WinForms.Guna2Elipse MainElipse;
        private Guna.UI2.WinForms.Guna2PictureBox ImgPic;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtFullname;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2ComboBox txtGender;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnRegister;
        private Guna.UI2.WinForms.Guna2PictureBox imgLogo;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnBack;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtDOB;
        private Guna.UI2.WinForms.Guna2DragControl DragControl2;
    }
}