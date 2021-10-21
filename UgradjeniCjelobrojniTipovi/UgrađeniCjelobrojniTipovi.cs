using System;
using System.Runtime.Remoting.Messaging;

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
            // 022 Deklarirati varijablu tipa int i dodijeliti joj vrijednost 1. 
            int one = 1; 
            // 023 Deklarirati varijablu tipa long i pridružiti joj vrijednost gornje varijable tipa int.
            long longer = one;  // no dangerous 
            // 024 Deklarirati varijablu tipa short i pridružiti joj vrijednost gornje varijable tipa int. 
            //short shorter = one;  it is not possible, because shorter is "smaller" 
            // Primjeri numeričkog preljeva
            // 025 Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MaxValue. Ispisati vrijednost varijable uvećane za 1.
            int max = int.MaxValue;
            Console.WriteLine(max+1); // it write min value!!!!!!!! the largest negative number 
            // 026 Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MinValue. Ispisati vrijednost varijable umanjenu za 1.
            int min = int.MinValue;
            Console.WriteLine(min -1);
            // 027 U postavkama projekta uključiti opciju za provjeru numeričkog preljeva. Ponovno pokrenuti program i provjeriti što će se dogoditi.

            // Primjer cjelobrojnog dijeljenja nulom
            // 028 Definirati varijablu tipa int te dodati naredbu kojom se ta varijabla dijeli s nulom. Pokrenuti program i provjeriti što će se dogoditi
            int i = 5;
            Console.WriteLine(i / 0); // baci exception 
            Console.ReadKey();
        }
    }
}
