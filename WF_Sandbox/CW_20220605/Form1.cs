using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_20220605
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        List<Bitmap> images = new List<Bitmap>();
        int np = 0;
        Bitmap one;
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 500;
            timer.Tick += next_Click();
            Bitmap one_im = new Bitmap("Hello.jpg");
            one = new Bitmap(one_im, pictBox1.Size);
            pictBox1.Image = one;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextPicture();
        }

        private void NextPicture()
        {
            if (images.Count ==0)
            {
                return;
            }
            np++;
            if (np>= images.Count)
            {
                np = 0;
            }
            pictBox1.Image = images[np];
            labelCounter.Text = Convert.ToString((np + 1) + "/" + images.Count);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void Prev()
        {
            if (images.Count == 0)
            {
                return;
            }
            np--;
            if(np<0)
            {
                pictBox1 = images.Count - 1;
            }
            pictBox1.Image = images[np];
            labelCounter.Text = Convert.ToString((np + 1) + "/" + images.Count);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (images.Count !=0)
            {
                timer.Start();
            }
            else
            {
                MessageBox.Show("Folder does not defined");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            btnStop_Click(null, null);
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK);
            {
                timer.Stop();
                if (images.Count!=0)
                {
                    foreach (var item in images)
                    {
                        item.Dispose();
                    }
                    images.Clear();
                    pictBox1.Image = one;
                }

                DirectoryInfo direct = new DirectoryInfo(folder.SelectedPath);
            }
        }
    }
}
