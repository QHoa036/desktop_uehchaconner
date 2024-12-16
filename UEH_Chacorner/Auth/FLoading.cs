using System;
using System.Windows.Forms;

namespace UEH_ChaCorner
{
    public partial class FLoading : Form
    {
        public FLoading()
        {
            InitializeComponent();
        }

        private void FLoading_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (ProgressBar.Value == 100)
            {
                timer.Stop();
            }
            else
            {
                ProgressBar.Increment(2);
            }
        }
    }
}