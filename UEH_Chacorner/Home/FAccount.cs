using System;
using System.Windows.Forms;

namespace UEH_ChaCorner
{
    public partial class FAccount : Form
    {
        public FAccount()
        {
            InitializeComponent();
        }

        public string MaNV { get; set; }

        public string TenNV { get; set; }

        public string Quyen { get; set; }

        private void FAccount_Load(object sender, EventArgs e)
        {
            lbName.Text = TenNV;
            lbRole.Text = Quyen;
        }

        public void FAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            FHomepage.MainMenu.setVisible(Quyen, TenNV, MaNV);
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btChangePassword_Click(object sender, EventArgs e)
        {

        }
    }
}