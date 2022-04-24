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

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            TimerForm timer = new TimerForm();
            timer.ShowDialog();
        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            Coordinates coordinates = new Coordinates();
            coordinates.ShowDialog();
        }

        private void buttonTask3_Click(object sender, EventArgs e)
        {
            PersInfo_Compl persInfo_Compl = new PersInfo_Compl();
            persInfo_Compl.ShowDialog();
        }
        
        private void buttonTask4_Click(object sender, EventArgs e)
        {
            Messages.CurriculumVitae();
        }
        
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Messages.CloseConfirmationDialog();
        }
    }
}
