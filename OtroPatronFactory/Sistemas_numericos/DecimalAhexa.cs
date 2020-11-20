using System;
using System.Collections.Generic;
using System.Text;

namespace Sistemas_numericos
{
    class DecimalAhexa : TransformadorDeSistemas
    {
        public override string ConvertidorBaC(int a)
        {
            int n = 0;
            string hex = "";

            n = a;

            while (true)
            {
                if ((n % 16) != 0)
                {
                    if ((n % 16) > 9)
                        switch (n % 16)
                        {
                            case 10:
                                hex = "A" + hex;
                                break;
                            case 11:
                                hex = "B" + hex;
                                break;
                            case 12:
                                hex = "C" + hex;
                                break;
                            case 13:
                                hex = "D" + hex;
                                break;
                            case 14:
                                hex = "E" + hex;
                                break;
                            case 15:
                                hex = "F" + hex;
                                break;
                        }
                    else
                        hex = (n % 16).ToString() + hex;
                }
                else
                    hex = "0" + hex;
                n /= 16;
                if (n <= 0)
                    break;
            }

            return hex;
    
        }
    }
}

