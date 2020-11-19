using System;
using System.Collections.Generic;
using System.Text;

namespace Patrón_Factoría
{
    class CreadorRopa
    {
        public const string Ropa_Dormirr = "Ropa para dormir";
        public const string TrajedeBañoo = "Ropa para bañarse";

        public static Ropa CrearRopa(string tipo) {

            switch (tipo)
            {
                case Ropa_Dormirr:
                    return new Ropa_Dormir();
                case TrajedeBañoo:
                    return new TrajedeBaño();
                default: return null;
            }

            
        }


    }
}
