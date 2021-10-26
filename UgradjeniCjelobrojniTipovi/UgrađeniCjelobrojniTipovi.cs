using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // 020 Otkomentirati donje naredbe koje ispisuju najveće brojeve koji se mogu pohraniti u tip int odn. long.
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);

            // 021 Dodati naredbe koje će ispisati najmanje brojeve koji se mogu pohraniti u tip int odn. u tip long.
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MinValue);

            // Primjeri pridruživanja cjelobrojnih varijabli različitih tipova
            // : jedan = 1;

            // :023 Deklarirati varijablu tipa long i pridružiti joj vrijednost gornje varijable tipa int.
            long dugacak = 1;

            // :024 Deklarirati varijablu tipa short i pridružiti joj vrijednost gornje varijable tipa int. 
            short kratak = (short)dugacak;

            // Primjeri numeričkog preljeva
            // :025 Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MaxValue. Ispisati vrijednost varijable uvećane za 1.
            int max = int.MaxValue;
            Console.WriteLine(max+1);
            // 026 Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MinValue. Ispisati vrijednost varijable umanjenu za 1.
            int min = int.MinValue;
            Console.WriteLine(min - 1);
            // :027 U postavkama projekta uključiti opciju za provjeru numeričkog preljeva. Ponovno pokrenuti program i provjeriti što će se dogoditi.
            // Ovaj solution, desni klik miša, properties, build -> Check arithmetic overflow
            // Exception Settings
            // Primjer cjelobrojnog dijeljenja nulom
            // 028 Definirati varijablu tipa int te dodati naredbu kojom se ta varijabla dijeli s nulom. Pokrenuti program i provjeriti što će se dogoditi.
            int a = 5;
            Console.WriteLine(a);
            //var b = a / 0;
            // System divided by zero exception
            Console.ReadKey();
        }
    }
}
