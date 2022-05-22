using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_05152022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateColor();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 50;
            progressBar1.Step = 1;

            for (int i=0; i<progressBar1.Maximum; i++)
            {
                progressBar1.PerformStep();
                label1.Text = "Value = " + progressBar1.Value.ToString();
                Update();
                Thread.Sleep(50);
            }
        }

        private void UpdateColor()
        {
            Color color = Color.FromArgb(trBarRed.Value, trBarGreen.Value, trBarBlue.Value);
            BackColor = color;
        }

        private void trBarRed_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void trBarGreen_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void trBarBlue_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }
    }
}
