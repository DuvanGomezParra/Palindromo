using System;

namespace Palindromos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            Random r = new Random();

            int b = 65;
            string palabra = "";

            for (int count = 0; count < 10; count++)
            {
                palabra += (char)(64+r.Next(0,26));
                b++;
            }

            Console.WriteLine($"la palabra es: {palabra}");

            if (palabra[0] == palabra[palabra.Length - 1])
            {
                Console.WriteLine($"Es palindroma");
            }
            else
            {
                Console.WriteLine("No es Palindroma");
            }

           

            Console.ReadKey();
        }
    }
}
