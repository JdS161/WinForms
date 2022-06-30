using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_20220619_WPF
{
    internal class Transaction
    {
        private string description;
        private double price;

        public Transaction(string _description, double _price)
        {
            description = _description;
            price = _price;
        }
        public string Description => description;
        public double Price => price;
        public bool isExpense => price < 0.0;
        public bool IsExpenseAllowable => isExpense && Math.Abs(price) < 50.0;

        public bool IsIncome => price > 0.0;

    }
}
