using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            double? nulabilniDuplić = Math.PI;
            Console.WriteLine("nulabilniDuplić = {0}", nulabilniDuplić);
            Console.WriteLine("nulabilniDuplić ima vrijednost: {0}\n", nulabilniDuplić.HasValue);

            double običniDuplić = Math.PI;
            Console.WriteLine("običniDuplić = {0}", običniDuplić);
            Console.WriteLine("običniDuplić je tipa: {0}\n", običniDuplić.GetType());

            // 050  Dodati naredbu kojom se vrijednost nulabilniDuplić postavlja na null referencu te ispisati nakon toga sadržaj varijable.
            nulabilniDuplić = null;
            Console.WriteLine("nulabilniDuplić = {0}", nulabilniDuplić);
            Console.WriteLine("nulabilniDuplić ima vrijednost: {0}\n", nulabilniDuplić.HasValue);

            // 051 Pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić. Provjeriti što će se dogoditi.
            // Message = Nullable object must have a value.
            Console.WriteLine("Ne prolazi build s porukom: Message = Nullable object must have a value.");
            // običniDuplić = nulabilniDuplić.Value;
            // Console.WriteLine(običniDuplić);


            // 052 Postaviti vrijednost varijable nulabilniDuplić na konačnu vrijednost te ispisati sadržaj.
            nulabilniDuplić = 45.8;
            Console.WriteLine("nulabilniDuplić = {0}", nulabilniDuplić);
            Console.WriteLine("nulabilniDuplić ima vrijednost: {0}\n", nulabilniDuplić.HasValue);

            // 053 Ponovno pokušati pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić.
            običniDuplić = nulabilniDuplić.Value;
            Console.WriteLine("običniDuplić = {0}", običniDuplić);
            Console.WriteLine("običniDuplić je tipa: {0}\n", običniDuplić.GetType());

            Console.ReadKey();
        }
    }
}
