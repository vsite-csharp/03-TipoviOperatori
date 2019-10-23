namespace Vsite.CSharp.TipoviOperatori
{
    static class Program
    {
        static void Main()
        {
            // ODO:020 Otkomentirati donje naredbe koje ispisuju najveće brojeve koji se mogu pohraniti u tip int odn. long.
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);

            // ODO:021 Dodati naredbe koje će ispisati najmanje brojeve koji se mogu pohraniti u tip int odn. u tip long.
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MinValue);
            // Primjeri pridruživanja cjelobrojnih varijabli različitih tipova
            // ODO:022 Deklarirati varijablu tipa int i dodijeliti joj vrijednost 1. 
            int i = 1;
            // ODO:023 Deklarirati varijablu tipa long i pridružiti joj vrijednost gornje varijable tipa int.
            long l = i;
            // ODO:024 Deklarirati varijablu tipa short i pridružiti joj vrijednost gornje varijable tipa int. 
            short s = (short)i;
            // Primjeri numeričkog preljeva
            // ODO:025 Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MaxValue. Ispisati vrijednost varijable uvećane za 1.
            int i2 = int.MaxValue;
            //Console.WriteLine(int.MaxValue + 1);
            Console.WriteLine($"Rezultat: {i2 + 1}");
            // ODO:026 Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MinValue. Ispisati vrijednost varijable umanjenu za 1.
            int i3 = int.MinValue;
            Console.WriteLine($"Rezultat: {i3 - 1}");
            // ODO:027 U postavkama projekta uključiti opciju za provjeru numeričkog preljeva. Ponovno pokrenuti program i provjeriti što će se dogoditi.

            // Primjer cjelobrojnog dijeljenja nulom
            // ODO:028 Definirati varijablu tipa int te dodati naredbu kojom se ta varijabla dijeli s nulom. Pokrenuti program i provjeriti što će se dogoditi.
            //Console.WriteLine(i / 0);
            Console.ReadKey();
        }
    }
}
