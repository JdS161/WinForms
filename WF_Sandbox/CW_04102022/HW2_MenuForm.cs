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
    public partial class HW2_MenuForm : Form
    {
        public HW2_MenuForm()
        {
            InitializeComponent();

           
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Messages.CloseConfirmationDialog();
        }
    }
}
