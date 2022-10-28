using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // TODO:020 Otkomentirati donje naredbe koje ispisuju najveće brojeve koji se mogu pohraniti u tip int odn. long.
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);

            // TODO:021 Dodati naredbe koje će ispisati najmanje brojeve koji se mogu pohraniti u tip int odn. u tip long.
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MinValue);

            // Primjeri pridruživanja cjelobrojnih varijabli različitih tipova
            // TODO:022 Deklarirati varijablu tipa int i dodijeliti joj vrijednost 1. 
            int i = 1;

            // TODO:023 Deklarirati varijablu tipa long i pridružiti joj vrijednost gornje varijable tipa int.
            long l = i;
            // TODO:024 Deklarirati varijablu tipa short i pridružiti joj vrijednost gornje varijable tipa int. 
            short sh = (short)i;
            // Primjeri numeričkog preljeva
            // TODO:025 Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MaxValue. Ispisati vrijednost varijable uvećane za 1.
            var maxInt = int.MaxValue;
            Console.WriteLine(maxInt + 1);
            // TODO:026 Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MinValue. Ispisati vrijednost varijable umanjenu za 1.
            var minInt = int.MinValue;
            Console.WriteLine(minInt - 1);

            // TODO:027 U postavkama projekta uključiti opciju za provjeru numeričkog preljeva. Ponovno pokrenuti program i provjeriti što će se dogoditi.

            // Primjer cjelobrojnog dijeljenja nulom
            // TODO:028 Definirati varijablu tipa int te dodati naredbu kojom se ta varijabla dijeli s nulom. Pokrenuti program i provjeriti što će se dogoditi.
            int a = 3;
            a = a / 0;
            Console.ReadKey();
        }
    }
}
