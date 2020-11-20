using System;
using System.Collections.Generic;
using System.Text;

namespace Patrón_Factoría
{
    class Ropa_Dormir : Ropa
    {
        string material;

        public override string Carateristicas()
        {
            return "Suave y Liviana";
        }

        public override string MaterialDeLaRopa(int a)
            
        {
            switch (a) {
                case 1:
                    material = "Saten";
                    break;
                case 2:
                    material = "Lanilla";
                    break;
            }
            return material;

            
        }
    }
}
