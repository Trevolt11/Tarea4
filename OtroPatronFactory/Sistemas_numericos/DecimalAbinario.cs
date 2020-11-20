using System;
using System.Collections.Generic;
using System.Text;

namespace Sistemas_numericos
{
    class DecimalAbinario : TransformadorDeSistemas
    {

        public override string ConvertidorBaC(int a)
        {
            string binario = "";

            while (a > 0)
            {
                binario = a % 2 + binario;

                a = a / 2;
            }
            return binario;
        }
    }
}
