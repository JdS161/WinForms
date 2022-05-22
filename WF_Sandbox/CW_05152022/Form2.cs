using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_05152022
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //1
        //private void Form2_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    Pen pn = new Pen(Brushes.Red, 5);
        //    pn.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        //    g.DrawEllipse(pn, 50, 100, 170, 40);
        //    g.Dispose();
        //}


        //2
        //private void Form2_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    Rectangle rect1 = new Rectangle(20,20, 200, 40);
        //    LinearGradientBrush lbr = new LinearGradientBrush(rect1, Color.Aqua, Color.Gold, 0.0f, true);
        //    g.FillRectangle(lbr, rect1);

        //    Rectangle rect2 = new Rectangle(80, 80, 200, 40);
        //    HatchBrush hatchBrush = new HatchBrush(HatchStyle.Cross, Color.Beige);
        //    g.FillRectangle(hatchBrush, rect2);

        //    Rectangle rect3 = new Rectangle(20, 140, 200, 50);
        //    TextureBrush textureBrush = new TextureBrush(new Bitmap("picture.bmp"));
        //    g.FillRectangle(textureBrush, rect3);


        //    g.Dispose();
        //}


        //3
        //private void Form2_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    Rectangle rect = this.ClientRectangle;
        //    Image img = new Bitmap("picture.bmp");
        //    g.DrawImage(img, rect);

        //    g.Dispose();
        //}


        //4

        List <Point> points = new List<Point>();
        //private void Form2_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    foreach(Point p in points)
        //    {
        //        g.FillEllipse(Brushes.Green, p.X, p.Y, 15f, 15f);
        //    }

        //    g.Dispose();
        //}

        //5
        //private void Form2_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    int x = 23;
        //    int y = 33;
        //    int height = 60;
        //    int width = 60;
        //    Pen pn = new Pen(Brushes.Red, 4);
        //    Point pt = new Point(10, 10);
        //    Size sz = new Size(160, 160);
        //    Rectangle rect1 = new Rectangle(pt, sz);
        //    Rectangle rect2 = new Rectangle(x, y, width, height);
        //    g.FillEllipse(Brushes.Black, rect1);
        //    g.DrawEllipse(pn, rect2);

        //    g.Dispose();
        //}


        ////6
        //private void Form2_Paint(object sender, PaintEventArgs e)
        //{

        //    Graphics g = e.Graphics;
        //    int x = 20;
        //    int y = 30;
        //    int height = 60;
        //    int width = 60;
        //    Point pt = new Point(10, 10);
        //    Size sz = new Size(160, 140);
        //    Rectangle rect1 = new Rectangle(pt, sz);
        //    Rectangle rect2 = new Rectangle(x, y, width, height);
        //    g.FillRectangle(Brushes.Black, rect1);
        //    g.DrawRectangle(new Pen(Brushes.Red, 2), rect2);

        //    g.Dispose();
        //}


        //7 Line Drawing
        //private void Form2_Paint(object sender, PaintEventArgs e)
        //{

        //    Graphics g = e.Graphics;
        //    g.TranslateTransform(10, 50);
        //    Point A = new Point(0, 0);
        //    Point B = new Point(120, 120);
        //    g.DrawLine(new Pen(Brushes.Blue, 3), A, B);

        //    g.Dispose();
        //}

        //8 Text drawing
        private void Form2_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Font f = new Font("Verdana", 14, FontStyle.Bold | FontStyle.Italic);
            g.DrawString("Hello Font!", f, Brushes.Blue, 30, 55);

            g.Dispose();
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(new Point(e.X, e.Y));
            Invalidate();
        }
    }
}
