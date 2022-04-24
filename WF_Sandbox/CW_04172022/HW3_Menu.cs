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
    public partial class HW3_Menu : Form
    {
        public HW3_Menu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Messages.CloseConfirmationDialog();
        }

        private void btnTask2_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.ShowDialog();
        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            GoodsParent goods = new GoodsParent();
            goods.ShowDialog();
        }
    }
}
