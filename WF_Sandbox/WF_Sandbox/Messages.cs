using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Sandbox
{
    internal class Messages
    {
        public static DialogResult ShowExitConfirmation()
        {
            string _message = "Are you sure, you want to exit?";
            string _caption = "Exit";
            DialogResult result = MessageBox.Show(_message, _caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

            return result;
        }

        public static DialogResult ShowCompletion(string _msg)
        {
            string _caption = "Congratulation!";
            DialogResult result = MessageBox.Show(_msg, _caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}
