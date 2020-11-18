using System;
using System.Collections.Generic;
using System.Text;

namespace Patrón_Factoría
{
    class CreadorRopa
    {
        public const string Ropa_Dormirr = "Ropa para dormir";
        public const string TrajedeBaño0 = "Ropa para bañarse";

        public static Ropa CrearRopa(string tipo) {

            switch (tipo)
            {
                case Ropa_Dormirr:
                    return new Ropa_Dormir();
                case TrajedeBaño0:
                    return new TrajedeBaño();
                default: return null;
            }

            
        }


    }
}
