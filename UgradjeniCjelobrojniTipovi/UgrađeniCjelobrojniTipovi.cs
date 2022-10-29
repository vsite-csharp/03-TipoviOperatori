using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);

            
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MinValue);
            // Primjeri pridruživanja cjelobrojnih varijabli različitih tipova
            // TODO:022 Deklarirati varijablu tipa int i dodijeliti joj vrijednost 1. 
            int a = 1;

            // TODO:023 Deklarirati varijablu tipa long i pridružiti joj vrijednost gornje varijable tipa int.
            long b = a;

            // TODO:024 Deklarirati varijablu tipa short i pridružiti joj vrijednost gornje varijable tipa int. 
            
            
                short c = (short)a;
            

            // Primjeri numeričkog preljeva
            // TODO:025 Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MaxValue. Ispisati vrijednost varijable uvećane za 1.
            int maxint = int.MaxValue;
            try { Console.WriteLine(maxint + 1); }
            catch (Exception ex) { Console.WriteLine(ex); }
            
             
            // TODO:026 Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MinValue. Ispisati vrijednost varijable umanjenu za 1.
            int minint=int.MinValue;
            try { Console.WriteLine(minint + 1); }
            catch (Exception ex) { Console.WriteLine(ex); }
            // TODO:027 U postavkama projekta uključiti opciju za provjeru numeričkog preljeva. Ponovno pokrenuti program i provjeriti što će se dogoditi.

            // Primjer cjelobrojnog dijeljenja nulom
            // TODO:028 Definirati varijablu tipa int te dodati naredbu kojom se ta varijabla dijeli s nulom. Pokrenuti program i provjeriti što će se dogoditi.
            try { Console.WriteLine(minint/0); }
            catch (Exception ex) { Console.WriteLine(ex); }
            Console.ReadKey();
        }
    }
}
