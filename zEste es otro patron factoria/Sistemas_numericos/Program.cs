using System;

namespace Sistemas_numericos
{
    class Program
    {

        //Basado en el patron factory
        static void Main(string[] args)
        {
            string select_opcion;
            int valor;

            do
            {
                Console.WriteLine("1 --> Decimal a Binario ");
                Console.WriteLine("2 --> Decimal a Hexadecimal");
                Console.WriteLine("3 --> Binario a Decimal");
                Console.WriteLine("x --> Salir");
                Console.WriteLine("Introduzca el numero: ");
                select_opcion = (Console.ReadLine());

                if (select_opcion == "1")
                {
                    Console.Clear();
                    TransformadorDeSistemas DaB;


                    Console.WriteLine("Entre el valor 'Decimal': ");
                    valor = Convert.ToInt32(Console.ReadLine());

                    DaB = CrearCalculo.calculo(CrearCalculo.DecimalAbinario); //crea un objecto
                    Console.WriteLine("El resultado de Decimal a Binario  es: " + DaB.ConvertidorBaC(valor));
                }
                else if (select_opcion == "2")
                {
                    Console.Clear();
                    TransformadorDeSistemas DaB1;

                    Console.WriteLine("Entre el valor 'Decimal': ");
                    int valor1 = Convert.ToInt32(Console.ReadLine());

                    DaB1 = CrearCalculo.calculo(CrearCalculo.DecimalAhexa);//crea un objecto
                    Console.WriteLine("El resultado de Decimal a Hexadecimal es: " + DaB1.ConvertidorBaC(valor1));


                }
                else if (select_opcion == "3")
                {
                    Console.Clear();
                    TransformadorDeSistemas DaB1;
                    Console.WriteLine("Entre el valor 'Binario': ");
                    int valor1 = Convert.ToInt32(Console.ReadLine());

                    DaB1 = CrearCalculo.calculo(CrearCalculo.binarioAdecimal);//crea un objecto
                    Console.WriteLine("El resultado de Binario a Decimal es: " + DaB1.ConvertidorBaC(valor1));

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
