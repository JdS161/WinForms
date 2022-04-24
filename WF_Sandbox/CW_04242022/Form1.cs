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

namespace CW_04242022
{
    public partial class Form1 : Form
    {
        Color c;
        public Form1()
        {
            InitializeComponent();
            c = this.BackColor;
            menuStripENG.Visible = false;
            btnLang.Text = "English";
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem it = (ToolStripMenuItem) sender;
            if (it.Checked)
                BackColor = Color.Red;
            else
                BackColor = c;
        }

        private void btnLang_Click(object sender, EventArgs e)
        {
            if (btnLang.Text.CompareTo("English")==0) 
            {
                menuStripRUS.Visible = false;
                menuStripENG.Visible = true;
                btnLang.Text = "Русский";
                this.MainMenuStrip = menuStripENG;
            }
            else
            {
                menuStripRUS.Visible = true;
                menuStripENG.Visible = false;
                btnLang.Text = "English";
                this.MainMenuStrip = menuStripRUS;
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text FIles (*.txt) | *.txt| All Files (*.*) | *.*";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName == "") return;
                else
                {
                    //Option 1
                    using (StreamReader sr = new StreamReader(openFileDialog.FileName))

                    {
                        richTextBox1.Text = sr.ReadToEnd();
                    }
                    
                    //Option 2
                    //StreamReader sr = new StreamReader(openFileDialog.FileName);
                    //richTextBox1.Text = sr.ReadToEnd();
                    //sr.Close();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) //save as
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName == "") return ;
                else
                {
                    using (StreamWriter swr = new StreamWriter(saveFileDialog1.FileName))
                    {
                        swr.Write(richTextBox1.Text);
                    }
                }
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = false;
            fontDialog1.Font = richTextBox1.SelectionFont;
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = richTextBox1.SelectionColor;
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //add dialog window save/not save
            Application.Exit();
        }
    }
}
