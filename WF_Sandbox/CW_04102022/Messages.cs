using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_04102022
{
    internal class Messages
    {
        public static DialogResult CloseConfirmationDialog()
        {
            string _message = "Already leaving?";
            string _caption = "Exit";
            DialogResult result;
            result = MessageBox.Show(_message, _caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit(); 

            return result;
        }
    
        public static DialogResult CurriculumVitae()
        {
            int msgBoxes = 0;

            DialogResult result;
            string _msgP1 = "Hello! My name is Vasilchenko Alexander!";
            string _caption = "Page #1";
            result = MessageBox.Show(_msgP1, _caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);

            string _msgP2 = "Since July 2013 I'm working as engineer in interational organisations.";
            _caption = "Page #2";
            result = MessageBox.Show(_msgP2,_caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            string _msgP3 = "Since 2013 up to 2017 I used to be working as 'Lead engineer for adjustment and tests' for Alstom transport and TMH Joint Venture in Novocherkassk";
            _caption = "Page #3";
            result = MessageBox.Show(_msgP3,_caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            string -msgP4 =

            return result;

        }
    
    
    
    
    }



}
