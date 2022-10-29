using System;
using System.Data;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // Otkomentirati donje naredbe koje ispisuju najveće brojeve koji se mogu pohraniti u tip int odn. long.
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);

            // Dodati naredbe koje će ispisati najmanje brojeve koji se mogu pohraniti u tip int odn. u tip long.
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MinValue);
            // Primjeri pridruživanja cjelobrojnih varijabli različitih tipova
            // Deklarirati varijablu tipa int i dodijeliti joj vrijednost 1. 
            int a = 1;
            // Deklarirati varijablu tipa long i pridružiti joj vrijednost gornje varijable tipa int.
            long b = a;

            Console.WriteLine("a (int) = {0}, b (long) = {1}", a, b);
            // Deklarirati varijablu tipa short i pridružiti joj vrijednost gornje varijable tipa int. 

            short c = (short)b;
            // Primjeri numeričkog preljeva
            // Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MaxValue. Ispisati vrijednost varijable uvećane za 1.
            int d = int.MaxValue;
            Console.WriteLine("d = {0}", d);
            Console.WriteLine("d + 1 = {0}", d+1);
            // Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MinValue. Ispisati vrijednost varijable umanjenu za 1.
            int e = int.MinValue;
            Console.WriteLine("e = {0}", e);
            Console.WriteLine("e - 1 = {0}", e - 1);
            // U postavkama projekta uključiti opciju za provjeru numeričkog preljeva. Ponovno pokrenuti program i provjeriti što će se dogoditi.

            // Primjer cjelobrojnog dijeljenja nulom
            // Definirati varijablu tipa int te dodati naredbu kojom se ta varijabla dijeli s nulom. Pokrenuti program i provjeriti što će se dogoditi.

            int f = 5;
            Console.WriteLine(f/0);

            Console.ReadKey();
        }
    }
}
