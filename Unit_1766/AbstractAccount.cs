using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1766
{
    public abstract class AbstractAccount : IAccount
    {
        // тип учетной записи
        public abstract string GetAccountType();

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public abstract void Calculate();
    }
}
