using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_04102022
{
    public partial class Coordinates : Form
    {
        public Coordinates()
        {
            InitializeComponent();
        }

        private string ShowCoordinates(MouseEventArgs e)
        {
            return "Mouse coordinates: X = " + e.X.ToString() + "; Y = " + e.Y.ToString();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = ShowCoordinates(e);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            string _msg = "";
            if (e.Button == MouseButtons.Left)
                _msg =$"Left button clicked!\n {ShowCoordinates(e)}";
            if (e.Button == MouseButtons.Right)
                _msg = $"Right button clicked!\n {ShowCoordinates(e)}";

            string _caption = "Mouse click";

            MessageBox.Show(_msg, _caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
