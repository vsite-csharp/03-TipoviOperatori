using System;

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
            int int1 = 1;
            //Deklarirati varijablu tipa long i pridružiti joj vrijednost gornje varijable tipa int.
            long long1 = int1;
            // Deklarirati varijablu tipa short i pridružiti joj vrijednost gornje varijable tipa int. 
            short s1 = (short)int1;
            // Primjeri numeričkog preljeva
            // Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MaxValue. Ispisati vrijednost varijable uvećane za 1.
            int i2 = Int32.MaxValue;
            i2++;
            Console.WriteLine(i2);
            // Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MinValue. Ispisati vrijednost varijable umanjenu za 1.
            int i3 = Int32.MinValue;
            i3--;
            Console.WriteLine(i3);
            // U postavkama projekta uključiti opciju za provjeru numeričkog preljeva. Ponovno pokrenuti program i provjeriti što će se dogoditi.

            // Primjer cjelobrojnog dijeljenja nulom
            // Definirati varijablu tipa int te dodati naredbu kojom se ta varijabla dijeli s nulom. Pokrenuti program i provjeriti što će se dogoditi.
            int i4 = 4;
            var k = i4 / 0;
            Console.WriteLine(k);

            Console.ReadKey();
        }
    }
}
