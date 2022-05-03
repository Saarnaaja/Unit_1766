using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1766
{
    public class SalaryAccount : AbstractAccount
    {

        public override void Calculate()
        {
            Interest = Balance * 0.5;
        }

        public override string GetAccountType()
        {
            return "Зарплатный";
        }
    }
}
