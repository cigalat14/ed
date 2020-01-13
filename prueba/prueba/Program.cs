using System;

namespace prueba
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Dime tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);

            Console.WriteLine("Dime tu edad");
            int edad = int.Parse (Console.ReadLine());
            Console.WriteLine("Tienes " + edad + " años");

            Console.WriteLine("Intoduce el primer número");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Intoduce el segundo número");
            int num2 = int.Parse(Console.ReadLine());

            int num3 = num1 + num2;
            Console.WriteLine("La suma de tus números es " + num3);
        }
    }
}
