using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1766
{
    internal class CommonAccount : AbstractAccount
    {
        public override void Calculate()
        {
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }

        public override string GetAccountType()
        {
            return "Обычный";
        }
    }
}
