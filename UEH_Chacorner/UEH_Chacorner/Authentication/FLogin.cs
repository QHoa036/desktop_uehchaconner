using System;
using System.Windows.Forms;

using BLL;

namespace UEH_Chacorner
{
    public partial class FLogin : Form
    {
        private const int CpNocloseButton = 0x200;
        private readonly TAIKHOAN_BLL _accountPul = new TAIKHOAN_BLL();
        private string _quyen = "", _ten = "", _idnv = "";

        public FLogin()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var myCp = base.CreateParams;
                myCp.ClassStyle |= CpNocloseButton;
                return myCp;
            }
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            AcceptButton = btnLogin;
        }

        public void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var dk = new FRegister();
            dk.ShowDialog();
        }

        private void splash()
        {
            Application.Run(new FLoading());
        }
    }
}