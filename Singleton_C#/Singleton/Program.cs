using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el nombre: ");
            string nombre_Res = (Console.ReadLine()); 
            Singleton_class Nombre1 = Singleton_class.Nombre(nombre_Res);// Se le manda el dato registrado y crea una instancia
            Console.WriteLine(Nombre1.nombre); //imprimer el valor almacenado de la instancia




            Console.WriteLine("Digite otro nombre: ");
            string nombre_Res1 = (Console.ReadLine()); 

            Singleton_class Nombre2 = Singleton_class.Nombre(nombre_Res1);// Se le manda el dato registrado, pero no crea otra instancia por que ya se una con el dato anterior 
            Console.WriteLine(Nombre2.nombre); //imprimer el valor almacenado de la instancia 


            Console.WriteLine("Aqui imprime el primer valor que registramos, ya que no crea otra instancia sino que usa la que ya creo anterior mente con el valor ingresado" +
                "ya que no crea otra instancia por que ya existe una.");







        }
    }
}
