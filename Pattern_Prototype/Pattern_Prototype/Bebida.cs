using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Prototype
{
    class Bebida : ICloneable
    {

        public string nombre { get; set; }
        public string grado_alcohol{ get; set; }
        public int precio { get; set; }

        public Info infor { get; set; }

        public class Info
        {
            public string fecha_inventario { get; set; }
            public string Color { get; set; }
        }

        public object Clone()
        {
            Bebida clonar = this.MemberwiseClone() as Bebida;

            clonar.infor = new Info();
            clonar.infor.fecha_inventario = infor.fecha_inventario;
            clonar.infor.Color = infor.Color;
            return clonar;
        }

        public override string ToString()
        {
            return "\n Nombre: " + nombre +"\n Precio: "+ precio +"\n Grado de alcohol: "+ grado_alcohol;
        }
    }
}
