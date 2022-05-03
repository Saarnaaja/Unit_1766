using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1766
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки
        public static void CalculateInterest(AbstractAccount account)
        {
            account.Calculate();
        }
    }
}
