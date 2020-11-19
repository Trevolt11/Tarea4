using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Singleton_class
    {
        private static Singleton_class registro = null;

        public String nombre = "";

        public String h;

        protected Singleton_class(String h)
        {
            nombre = "El nombre almacenado es: " + h + "\n";
        }

        public static Singleton_class Nombre(String f)
        {
                if (registro == null) //verifica la existencia de la instancia
                    registro = new Singleton_class(f);
                return registro;
        }
    }
}
