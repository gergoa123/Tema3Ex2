using System;

namespace Tema3Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul:");
            int numar = int.Parse(Console.ReadLine());
            int numarBinar = 0;
            int aux;
            int i = 1;

            while (numar != 0)
            {
                aux = numar % 2;
                numarBinar = numarBinar + aux * i;
                i *= 10;
                numar = numar / 2;
            }

            Console.WriteLine(numarBinar);
        }
    }
}
