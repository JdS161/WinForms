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
    public partial class PersInfo_Simple : Form
    {
        public PersInfo_Simple()
        {
            InitializeComponent();
        }

        private void buttonResults_Click(object sender, EventArgs e)
        {
            string _msg = $"\tLast name: \t{textBoxLastName.Text}\n\tFirst name: \t{textBoxFirstName.Text}\n\tPatronim: \t{textBoxPatronim.Text}\n\n\tCountry: \t\t{textBoxCountry.Text}\n\tCity: \t\t{textBoxCity.Text}\n\tPhone: \t\t{maskedTbPhone.Text}     \n\tDate of Birth: \t{dateTimeBirthdate.Text}\n\tGender: \t\t{ShowGender()} ";
            string _caption = "Personal information:";
            MessageBox.Show(_msg, _caption, MessageBoxButtons.OK);
        }

        private void Gender()
        {
            if (rbMale.Checked == true)
                rbFemale.Checked = false;
            if (rbFemale.Checked == true)
                rbMale.Checked = false;
        }
        private string ShowGender()
        {
            if (rbMale.Checked == true)
                return "Male";
            else
                return "Female";
        }
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender();
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender();
        }

       
    }
}
