using System;

namespace Patrón_Factoría
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string select_opcion;
            int select_Material;
            
            do
            {

                Console.WriteLine("1 --> Crea Ropa para dormir");
                Console.WriteLine("2 --> Crea un traje de baño");
                Console.WriteLine("x --> Salir");
                Console.WriteLine("Introduzca el numero de lo que quiere crear:");
                select_opcion = (Console.ReadLine());

                if (select_opcion == "1")
                {
                    Console.Clear();
                    Ropa TipoDeRopa = CreadorRopa.CrearRopa(CreadorRopa.Ropa_Dormirr);
                    Console.WriteLine("Elija el material");
                    Console.WriteLine("------------------------");
                    Console.WriteLine("1 --> Saten");
                    Console.WriteLine("2 --> Lanilla");
                    Console.WriteLine("Introduzca el numero del material: ");
                    select_Material = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("");
                    Console.WriteLine ( "El material elegido es: " + TipoDeRopa.MaterialDeLaRopa(select_Material));
                    Console.WriteLine ("Carateristicas: " + TipoDeRopa.Carateristicas());
                    Console.WriteLine("");
                }
                else if (select_opcion == "2")
                {
                    Console.Clear();
                    Ropa TipoDeRopa1 = CreadorRopa.CrearRopa(CreadorRopa.TrajedeBaño0);

                    Console.WriteLine("Elija el material");
                    Console.WriteLine("------------------------");
                    Console.WriteLine("1 --> Poliester");
                    Console.WriteLine("2 --> Nailon");
                    Console.WriteLine("Introduzca el numero del material: ");
                    select_Material = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("");
                    Console.WriteLine("El material elegido es: " + TipoDeRopa1.MaterialDeLaRopa(select_Material));
                    Console.WriteLine("Carateristicas: " + TipoDeRopa1.Carateristicas());
                    Console.WriteLine("");
                }

                else if (select_opcion == "x") {
                    Console.ReadKey();
                
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Seleccione una opcion correcta");
                    Console.WriteLine("");

                }
            } while (select_opcion != "x");


        }
    }
}
