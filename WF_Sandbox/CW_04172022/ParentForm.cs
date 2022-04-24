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
    public partial class ParentForm : Form
    {
        //1.1
        //public ParentForm()
        //{
        //    InitializeComponent();
        //}

        //private void btnShowParentForm_Click(object sender, EventArgs e)
        //{
        //    HeirForm heir = new HeirForm(tbParentForm.Text);
        //    heir.ShowDialog();
        //}


        //1.2
        //public ParentForm()
        //{
        //    InitializeComponent();
        //}

        //private void btnShowParentForm_Click(object sender, EventArgs e)
        //{
        //    HeirForm heir = new HeirForm();
        //    heir.PropText = tbParentForm.Text;
        //    heir.ShowDialog();
        //}

        //1.3
        //public ParentForm()
        //{
        //    InitializeComponent();
        //}

        //private void btnShowParentForm_Click(object sender, EventArgs e)
        //{
        //    HeirForm heir = new HeirForm();
        //    heir.ShowDialog(tbParentForm.Text);
        //}


        //2.1
        public ParentForm()
        {
            InitializeComponent();
        }

        private void btnShowParentForm_Click(object sender, EventArgs e)
        {
            HeirForm heir = new HeirForm();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HeirForm heir = new HeirForm();
            if (heir.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(heir.PropText); 
            }
        }
    }
}
