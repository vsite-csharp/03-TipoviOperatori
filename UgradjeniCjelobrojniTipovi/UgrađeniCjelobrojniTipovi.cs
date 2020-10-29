using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            //  Otkomentirati donje naredbe koje ispisuju najveće brojeve koji se mogu pohraniti u tip int odn. long.
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);

            //  Dodati naredbe koje će ispisati najmanje brojeve koji se mogu pohraniti u tip int odn. u tip long.
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MinValue);

            // Primjeri pridruživanja cjelobrojnih varijabli različitih tipova
            // Deklarirati varijablu tipa int i dodijeliti joj vrijednost 1. 
            int a = 1;

            // Deklarirati varijablu tipa long i pridružiti joj vrijednost gornje varijable tipa int.
            long dugi = a;

            // Deklarirati varijablu tipa short i pridružiti joj vrijednost gornje varijable tipa int. 
            short kraatki = (short)a;
            //short.MaxValue;

            // Primjeri numeričkog preljeva
            // Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MaxValue. Ispisati vrijednost varijable uvećane za 1.
            int najveća = int.MaxValue;
            ++najveća;
            Console.WriteLine(najveća);

            // Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MinValue. Ispisati vrijednost varijable umanjenu za 1.
            int najmanja = int.MinValue;
            --najmanja;
            Console.WriteLine(najmanja);

            // U postavkama projekta uključiti opciju za provjeru numeričkog preljeva. Ponovno pokrenuti program i provjeriti što će se dogoditi.

            // Primjer cjelobrojnog dijeljenja nulom
            // Definirati varijablu tipa int te dodati naredbu kojom se ta varijabla dijeli s nulom. Pokrenuti program i provjeriti što će se dogoditi.
            Console.WriteLine(a/0);


            Console.ReadKey();
        }
    }
}
