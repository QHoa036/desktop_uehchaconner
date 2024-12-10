using System;
using System.Windows.Forms;

namespace UEH_Chacorner
{
    public partial class FAccount : Form
    {
        public FAccount()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        #region Method

        public string MaNV { get; set; }

        public string TenNV { get; set; }

        public string Quyen { get; set; }

        #endregion

        #region Event

        private void FAccount_Load(object sender, EventArgs e)
        {
            lbName.Text = MaNV;
            lbRole.Text = Quyen;
            lbId.Text = MaNV;
        }

        public void FAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            FHomepage.Mainmenu.EnableQuyen(Quyen, TenNV, MaNV);
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}