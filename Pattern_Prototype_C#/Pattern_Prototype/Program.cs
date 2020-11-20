using System;

namespace Pattern_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = DateTime.Now;
            string v = date1.ToString("yyyy/MM/dd");
            

            Bebida bebida_ins = new Bebida() {nombre = "Ron Barcelo", grado_alcohol = 20 + "%", precio = 1230 };


            bebida_ins.infor = new Bebida.Info();

            Console.WriteLine("Original ");

            Console.WriteLine("" + bebida_ins.infor.fecha_inventario);
            Console.WriteLine(bebida_ins.ToString());
            bebida_ins.infor.fecha_inventario = "2020/10/29";
            Console.WriteLine(" Fecha que fue agregada la bebida: " + bebida_ins.infor.fecha_inventario + "");
            bebida_ins.infor.Color = "Blanco";
            Console.WriteLine(" Color de la bebida: " + bebida_ins.infor.Color + "\n");




            Console.WriteLine("Clon \n");

            Bebida bebida_insClone = bebida_ins.Clone() as Bebida;
            bebida_insClone.infor.Color = "Rojo vino";
            bebida_insClone.precio = 1500;
            bebida_insClone.infor.fecha_inventario = v;
            

            Console.WriteLine(" Nombre clon : " + bebida_insClone.nombre);
            Console.WriteLine(" Precio clon: " + bebida_insClone.precio);
            Console.WriteLine(" Grado de alcohol clon: " + bebida_insClone.grado_alcohol);
            Console.WriteLine(" Fecha que fue agregada la bebida clon: " + bebida_insClone.infor.fecha_inventario);
            Console.WriteLine(" Color del clon: " + bebida_insClone.infor.Color);
            
            



        }
    }
}
