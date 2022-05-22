using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_05152022
{
    public partial class Form3 : Form
    {

        Graphics myGraphics;
        SolidBrush myBrush;
        bool isDrawing = false;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            myBrush = new SolidBrush(pnlColor.BackColor);
            myGraphics = pnlCanvas.CreateGraphics();
        }

        private void pnlColor_DoubleClick(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                pnlColor.BackColor = colorDialog1.Color;
                myBrush.Color = colorDialog1.Color;
            }
        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
        }

        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(isDrawing == true)
            {
                myGraphics.FillEllipse(myBrush, e.X, e.Y, trackBar1.Value, trackBar1.Value);
            }
        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;

        }
    }
}
