using System;
using System.Collections.Generic;
using System.Text;

namespace Patrón_Factoría
{
    public abstract class Ropa
    {
        string material;

        public abstract string MaterialDeLaRopa(int a);

        public abstract string Carateristicas();

    }
}
