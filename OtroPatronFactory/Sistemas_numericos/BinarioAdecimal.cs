using System;
using System.Collections.Generic;
using System.Text;

namespace Sistemas_numericos
{
    class BinarioAdecimal : TransformadorDeSistemas
    {
        public override string ConvertidorBaC(int a)
        {
            int residuo;
            int exp = 0;
            int res = 0;

            int n = a;

            do
            {
                residuo = n % 10;
                n = n / 10;
                res += (int)(residuo * Math.Pow(2, exp));
                exp++;
            } while (n != 0);

            return res.ToString();

        }
    }
}
