using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            double? nulabilniDuplić = Math.PI;
            Console.WriteLine(nulabilniDuplić); //3,14159265358979

            double običniDuplić = Math.PI;
            Console.WriteLine(običniDuplić); //3,14159265358979
           

            // 050  Dodati naredbu kojom se vrijednost nulabilniDuplić postavlja na null referencu te ispisati nakon toga sadržaj varijable.

            nulabilniDuplić = null;
            Console.WriteLine("Nullable :" + nulabilniDuplić); // empty


            // 051 Pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić. Provjeriti što će se dogoditi.

            //običniDuplić = nulabilniDuplić; /*  Cannot implicitly convert type 'type1' to 'type2'. An explicit conversion exists (are you missing a cast?)*/


            // 052 Postaviti vrijednost varijable nulabilniDuplić na konačnu vrijednost te ispisati sadržaj.

            nulabilniDuplić = 52;
            Console.WriteLine("Final value: " + nulabilniDuplić);

            // 053 Ponovno pokušati pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić.

            //običniDuplić = nulabilniDuplić;
            /*  Cannot implicitly convert type 'type1' to 'type2'. An explicit conversion exists (are you missing a cast?)*/

            Console.WriteLine("nulabilniDuplic " + običniDuplić);

            Console.ReadKey();
        }
    }
}
