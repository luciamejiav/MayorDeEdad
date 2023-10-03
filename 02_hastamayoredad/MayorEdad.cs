// crear en la terminal dotnet new console
using System;
using System.Linq.Expressions;

namespace _02_hastamayoredad
{ //poner el mismo nombre que en el RootNamespace 
    internal class MayorEdad
    {
        static void Main(string[] args)
        {
            string? edad; //para evitar el warning poner ? detras de string
            int e;
            do
            {
                Console.Write("Introduce tu edad: ");
                edad = Console.ReadLine();
                //convertimos el string a int
                e = Int32.Parse(edad);
                if (e >= 18) //si es mayor termina el programa
                {
                    Console.WriteLine("Enhorabuena");
                    break;
                }
                else //sino hacemos el bucle
                {
                    Console.WriteLine("Intentelo de nuevo");
                }

            } while (e < 18);

        }
    }
}
