using System.Windows.Forms;

namespace UEH_ChaCorner.Common
{
    public static class Utils
    {
        public static void ShowError(string message)
        {
            MessageBox.Show(message, @"Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowSuccess(string message)
        {
            MessageBox.Show(message, @"Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}