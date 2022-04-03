using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_04032022_CW
{
    internal static class Program
    {

        static DialogResult ShowMessageBoxes()
        {
            //1
            string message = "Window, displaying text message";
            MessageBox.Show(message);
            //2
            message = "Window with text and two buttons OK and CANCEL";
            string _caption = "WIndow woith two buttons";

            DialogResult result = MessageBox.Show(message, _caption, MessageBoxButtons.OKCancel);
            string _button = result.ToString();
            //3
            result = MessageBox.Show("You've pushed" + _button + " Repeat?",  _button, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);
            return result;
        }

        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            DialogResult result;

            do
            {
               result = ShowMessageBoxes();
            } while (result == DialogResult.Retry);


        }
    }
}
