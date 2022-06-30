using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_20220612_WPF
{
    internal class Person
    {
        public string Surname 
        { get
            {
                return "Ivanov";
            }
        }

        public override string ToString()
        {
            return "User Person";
        }

    }
}
