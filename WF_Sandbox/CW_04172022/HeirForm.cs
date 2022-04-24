using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_04172022
{
    public partial class HeirForm : Form
    {

        //1.1
        //public HeirForm(string _str)
        //{
        //    InitializeComponent();
        //    tbHeirForm.Text = _str;
        //}

        //private void btnCloseHeirForm_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}


        //1.2

        //public string PropText 
        //{
        //    set
        //    {
        //        tbHeirForm.Text = value;
        //    }
        //}
        //public HeirForm()
        //{
        //    InitializeComponent();

        //}
        //private void btnCloseHeirForm_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}


        //1.3

        //public DialogResult ShowDialog(string _str)
        //{
        //    tbHeirForm.Text = _str;            
        //    return ShowDialog();
        //}
        //public HeirForm()
        //{
        //    InitializeComponent();
        //}
        //private void btnCloseHeirForm_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}



        //2.1
        public HeirForm()
        {
            InitializeComponent();
        }

        private void btnCloseHeirForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public string PropText 
        { 
           get
            {
                return tbHeirForm.Text;
            }
                
        }



    }
}
