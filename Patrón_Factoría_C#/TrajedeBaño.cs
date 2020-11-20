 using System;
using System.Collections.Generic;
using System.Text;

namespace Patrón_Factoría
{
    class TrajedeBaño : Ropa
    {
        string material;
        public override string Carateristicas()
        {
            return "Fuerte,Durable y resistente";
        }

        public override string MaterialDeLaRopa(int a = 1)
        {
            {
                switch (a)
                {
                    case 1:
                        material = "Poliester";
                        break;
                    case 2:
                        material = "Nailon";
                        break;
                }
                return material;


            }
        }
    }
}
