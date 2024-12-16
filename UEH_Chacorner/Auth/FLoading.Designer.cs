
namespace UEH_ChaCorner
{
    partial class FLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLoading));
            this.AnimatedWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.MainWindow = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Gif = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ImageTop = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BottomPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.Gif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageTop)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnimatedWindow
            // 
            this.AnimatedWindow.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_ACTIVATE;
            this.AnimatedWindow.TargetForm = this;
            // 
            // MainWindow
            // 
            this.MainWindow.BorderRadius = 90;
            this.MainWindow.TargetControl = this;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Gif
            // 
            this.Gif.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Gif.BackColor = System.Drawing.Color.Transparent;
            this.Gif.FillColor = System.Drawing.Color.Transparent;
            this.Gif.Image = ((System.Drawing.Image)(resources.GetObject("Gif.Image")));
            this.Gif.ImageRotate = 0F;
            this.Gif.Location = new System.Drawing.Point(457, 285);
            this.Gif.Margin = new System.Windows.Forms.Padding(2);
            this.Gif.Name = "Gif";
            this.Gif.Size = new System.Drawing.Size(296, 309);
            this.Gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Gif.TabIndex = 8;
            this.Gif.TabStop = false;
            this.Gif.UseTransparentBackground = true;
            // 
            // ImageTop
            // 
            this.ImageTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageTop.BackColor = System.Drawing.Color.Transparent;
            this.ImageTop.CustomizableEdges.BottomLeft = false;
            this.ImageTop.CustomizableEdges.BottomRight = false;
            this.ImageTop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.ImageTop.Image = ((System.Drawing.Image)(resources.GetObject("ImageTop.Image")));
            this.ImageTop.ImageRotate = 0F;
            this.ImageTop.Location = new System.Drawing.Point(0, 0);
            this.ImageTop.Margin = new System.Windows.Forms.Padding(0);
            this.ImageTop.Name = "ImageTop";
            this.ImageTop.Size = new System.Drawing.Size(1200, 588);
            this.ImageTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageTop.TabIndex = 6;
            this.ImageTop.TabStop = false;
            this.ImageTop.UseTransparentBackground = true;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BottomPanel.AutoRoundedCorners = true;
            this.BottomPanel.BackColor = System.Drawing.Color.White;
            this.BottomPanel.BorderRadius = 20;
            this.BottomPanel.Controls.Add(this.ProgressBar);
            this.BottomPanel.FillColor = System.Drawing.Color.White;
            this.BottomPanel.FillColor2 = System.Drawing.Color.White;
            this.BottomPanel.Location = new System.Drawing.Point(0, 592);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(2);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1200, 60);
            this.BottomPanel.TabIndex = 9;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.AutoRoundedCorners = true;
            this.ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar.BorderRadius = 14;
            this.ProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.ProgressBar.Location = new System.Drawing.Point(40, 12);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(234)))), ((int)(((byte)(226)))));
            this.ProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.ProgressBar.Size = new System.Drawing.Size(1120, 31);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 5;
            this.ProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // FLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.Gif);
            this.Controls.Add(this.ImageTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1200, 650);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "FLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLoading";
            this.Load += new System.EventHandler(this.FLoading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageTop)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow AnimatedWindow;
        private Guna.UI2.WinForms.Guna2Elipse MainWindow;
        private System.Windows.Forms.Timer Timer;
        private Guna.UI2.WinForms.Guna2PictureBox Gif;
        private Guna.UI2.WinForms.Guna2GradientPanel BottomPanel;
        private Guna.UI2.WinForms.Guna2ProgressBar ProgressBar;
        private Guna.UI2.WinForms.Guna2PictureBox ImageTop;
    }
}