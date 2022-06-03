using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CW_04102022
{
    public partial class TimerForm : Form
    {
        Stopwatch stopWatch = new Stopwatch();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        
        public TimerForm()
        {
            InitializeComponent();
            buttonStop.Enabled = false;
            timer.Tick += new EventHandler(ShowTimer);
        }

        private void ShowTimer(object sender, EventArgs e)
        {
            timer.Stop();
            MessageBox.Show("Timer finished", "Timer");
            buttonStop.Enabled = false;
        }
        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if(numericCounter.Value <=0)
            {
                MessageBox.Show("Seconds are not specified!", "Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            else
            {
                buttonStop.Enabled = true;
                timer.Interval = Decimal.ToInt32(numericCounter.Value) * 1000;
                timer.Start();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();

            if (numericCounter.Value > 0)
                MessageBox.Show("Timer had been stopped too early! \n", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            buttonStop.Enabled = false;
        }
    }
}
