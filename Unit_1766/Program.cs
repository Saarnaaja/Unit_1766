using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1766
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractAccount[] accounts = new AbstractAccount[]
            {
                new SalaryAccount() { Balance = 100000 },
                new CommonAccount() { Balance = 50000 }
            };

            foreach (var account in accounts)
            {
                Calculator.CalculateInterest(account);
            }
        }
    }
}
