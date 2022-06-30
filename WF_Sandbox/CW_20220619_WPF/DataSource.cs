using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_20220619_WPF
{
    internal class DataSource
    {
        private readonly  IEnumerable<Transaction> transactions;
        public IEnumerable<Transaction> Transactions => transactions;
        public DataSource()
        {
            transactions = new[]
            {
                new Transaction("Coffee", -10.2),
                new Transaction("Tea", 2.4),
                new Transaction("Bread", 1.9),
                new Transaction("Cheese", 103.2),
                new Transaction("Jam", -100.3),
                new Transaction("Vine", 32.9),
                new Transaction("Water", 49.99),
                new Transaction("Milk", -5.9),
                new Transaction("Raspberry", 50.1)

            };
        }
    }
}
