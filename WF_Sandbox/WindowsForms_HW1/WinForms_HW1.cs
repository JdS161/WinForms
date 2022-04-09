using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_HW1
{
    public partial class WinForms_HW1 : Form
    {
        public WinForms_HW1()
        {
            InitializeComponent();
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            WF_Sandbox.Form1 mazeForm = new WF_Sandbox.Form1();
            mazeForm.Show();
            //Application.Run(new WF_Sandbox.Form1());
        }

        private void buttonTask2_1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = Messages.ShowPart1();
        }

        private void buttonTask2_2_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = Messages.ShowPart2();
        }
    }
}
