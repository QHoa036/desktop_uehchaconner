using System;
using System.Windows.Forms;

namespace UEH_ChaCorner
{
    public partial class FHomepage : Form
    {
        public static FHomepage Mainmenu;

        private Form _activeForm;

        private bool _bbanan, _bmenu, _bnhanvien, _bthongke;
        private string _manv = "", _quyennv = "", _tennv = "";

        public FHomepage()
        {
            InitializeComponent();
            Mainmenu = this;
        }

        #region Method
        private void OpenChildForm(Form childForm)
        {
            _activeForm?.Hide();
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void EnableMnt()
        {
            btStaff.Visible = false;
            btStatistic.Visible = false;
            btMenu.Visible = false;
            btManage.Visible = false;
            btExit.Visible = false;
            lbquyen.Hide();
        }

        internal void EnableQuyen(string quyennv, string tennv, string idnv)
        {
            switch (quyennv)
            {
                case @"ADMIN":
                    btStaff.Visible = true;
                    btStatistic.Visible = true;
                    btMenu.Visible = true;
                    btManage.Visible = true;
                    btExit.Visible = true;
                    lbquyen.Show();
                    lbquyen.Text = @"Admin: " + tennv;
                    _manv = idnv;
                    _quyennv = quyennv;
                    _tennv = tennv;
                    break;

                case @"NhanVien":
                    btManage.Visible = true;
                    btExit.Visible = true;
                    lbquyen.Show();
                    lbquyen.Text = @"Nhân viên: " + tennv;
                    _manv = idnv;
                    _quyennv = quyennv;
                    _tennv = tennv;
                    break;
            }
        }

        #endregion

        #region Event
        
        private void FMainMenu_Load(object sender, EventArgs e)
        {
            EnableMnt();
            var dn = new FLogin();
            dn.FormClosing += dn.FLogin_FormClosing;
            dn.ShowDialog();
        }

        private void FMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btAccount_Click(object sender, EventArgs e)
        {
            var dn = new FAccount {TenNV = _tennv, Quyen = _quyennv, MaNV = _manv};
            dn.FormClosing += dn.FAccount_FormClosing;
            dn.ShowDialog();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Hide();
            var h = new FHomepage();
            h.ShowDialog();
            Application.Exit();
        }

        #endregion
    }
}