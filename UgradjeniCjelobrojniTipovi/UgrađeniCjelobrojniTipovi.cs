namespace Vsite.CSharp.TipoviOperatori
{
    static class Program
    {
        static void Main()
        {
            // :020 Otkomentirati donje naredbe koje ispisuju najveće brojeve koji se mogu pohraniti u tip int odn. long.
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);

            // :021 Dodati naredbe koje će ispisati najmanje brojeve koji se mogu pohraniti u tip int odn. u tip long.
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MinValue);

            // Primjeri pridruživanja cjelobrojnih varijabli različitih tipova
            // :022 Deklarirati varijablu tipa int i dodijeliti joj vrijednost 1. 
            int jedan = 1;
            // :023 Deklarirati varijablu tipa long i pridružiti joj vrijednost gornje varijable tipa int.
            long jedanLong = jedan;
            // :024 Deklarirati varijablu tipa short i pridružiti joj vrijednost gornje varijable tipa int. 
            short jedanShort = (short)jedan;
            // Primjeri numeričkog preljeva
            // :025 Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MaxValue. Ispisati vrijednost varijable uvećane za 1.
            int maxPreko = int.MaxValue;
            Console.WriteLine(maxPreko + 1);
            // :026 Deklarirati varijablu tipa int i dodijeliti joj vrijednost int.MinValue. Ispisati vrijednost varijable umanjenu za 1.
            int minIspod = int.MinValue;
            Console.WriteLine(minIspod - 1);
            // :027 U postavkama projekta uključiti opciju za provjeru numeričkog preljeva. Ponovno pokrenuti program i provjeriti što će se dogoditi.
            //Greska se generira, dešava se preljev

            // Primjer cjelobrojnog dijeljenja nulom
            // :028 Definirati varijablu tipa int te dodati naredbu kojom se ta varijabla dijeli s nulom. Pokrenuti program i provjeriti što će se dogoditi.
            try
            {
                int nekiBroj = 123;
                Console.WriteLine(nekiBroj / 0);
            }
            catch(Exception ex){
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }
    }
}
