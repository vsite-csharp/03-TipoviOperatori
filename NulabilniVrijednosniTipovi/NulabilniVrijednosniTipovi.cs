using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class MojaKlasa
    {
       public int a = 10;
    }
    class Program
    {
        static void Main()
        {
            double? nulabilniDuplić = Math.PI;
            Console.WriteLine(nulabilniDuplić);

            double običniDuplić = Math.PI;
            Console.WriteLine(običniDuplić);

            // 050  Dodati naredbu kojom se vrijednost nulabilniDuplić postavlja na null referencu te ispisati nakon toga sadržaj varijable.
            nulabilniDuplić = null;
            Console.WriteLine(nulabilniDuplić);
            if (nulabilniDuplić.HasValue) {
                običniDuplić = nulabilniDuplić.Value; 
            }
            Console.WriteLine(običniDuplić);
            // 051 Pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić. Provjeriti što će se dogoditi.

            // 052 Postaviti vrijednost varijable nulabilniDuplić na konačnu vrijednost te ispisati sadržaj.

            // 053 Ponovno pokušati pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić.
            // 054
            // 055
            // 056
            MojaKlasa? mk = new MojaKlasa();
            Console.WriteLine(mk.a);
            mk = null;
            if (mk != null) // ili if(mk is not null)
            {
                Console.WriteLine(mk.a);
            }
            Console.ReadKey();
        }
    }
}
