using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // OK-TODO:020 Otkomentirati donje naredbe koje ispisuju najveće brojeve koji se mogu pohraniti u tip int odn. long.
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);

            // OK-TODO:021 Dodati naredbe koje će ispisati najmanje brojeve koji se mogu pohraniti u tip int odn. u tip long.
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MinValue);

            // Primjeri pridruživanja cjelobrojnih varijabli različitih tipova
            // OK-TODO:022 Deklarirati varijablu tipa int i dodijeliti joj vrijednost 1. 
            int jedan = 1;

            // OK-TODO:023 Deklarirati varijablu tipa long i pridružiti joj vrijednost gornje varijable tipa int.
            long dugacak = jedan;

            // OK-TODO:024 Deklarirati varijablu tipa short i pridružiti joj vrijednost gornje varijable tipa int. 
            short kratak = (short)jedan;

            // Primjeri numeričkog preljeva
            // OK-TODO:025 Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MaxValue. Ispisati vrijednost varijable uvećane za 1.
            int max = int.MaxValue;

            // OK-TODO:026 Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MinValue. Ispisati vrijednost varijable umanjenu za 1.
            Console.WriteLine(max++);

            // OK-TODO:027 U postavkama projekta uključiti opciju za provjeru numeričkog preljeva. Ponovno pokrenuti program i provjeriti što će se dogoditi.
            int min = int.MinValue;

            // Primjer cjelobrojnog dijeljenja nulom
            // OK-TODO:028 Definirati varijablu tipa int te dodati naredbu kojom se ta varijabla dijeli s nulom. Pokrenuti program i provjeriti što će se dogoditi.
            //Console.Write(min--); 
            int a = 5;
            var b = a / 0;

            Console.ReadKey();
        }
    }
}
