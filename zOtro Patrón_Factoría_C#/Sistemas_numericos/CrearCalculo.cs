using System;
using System.Collections.Generic;
using System.Text;

namespace Sistemas_numericos
{
    class CrearCalculo
    {
        public const string DecimalAbinario = "";
        public const string DecimalAhexa = "a";
        public const string binarioAdecimal = "b";


        public static TransformadorDeSistemas calculo(string tipo)
        {
            switch (tipo)
            {
                case DecimalAbinario:
                    return new DecimalAbinario();
                case DecimalAhexa:
                    return new DecimalAhexa();
                case binarioAdecimal:
                    return new BinarioAdecimal();

                default: return null;
            }

        }
    }
}
