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
    public partial class GoodsParent : Form
    {
        Goods good;
        //bool flag = false;
        public GoodsParent()
        {
            InitializeComponent();
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) MessageBox.Show("Error");
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            good = new Goods();
            GoodsHeir addForm = new GoodsHeir(good, true); 
            if (addForm.ShowDialog() == DialogResult.OK) listBox1.Items.Add(good);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //listBox1.SelectedItem;
        }
    }
}
