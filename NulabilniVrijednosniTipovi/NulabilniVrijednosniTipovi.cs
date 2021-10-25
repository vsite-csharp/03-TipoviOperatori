using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            double? nulabilniDuplić = Math.PI;
            Console.WriteLine(nulabilniDuplić);

            double običniDuplić = Math.PI;
            Console.WriteLine(običniDuplić);

            //050  Dodati naredbu kojom se vrijednost nulabilniDuplić postavlja na null referencu te ispisati nakon toga sadržaj varijable.
            nulabilniDuplić = null;
            Console.WriteLine(nulabilniDuplić);

            //051 Pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić. Provjeriti što će se dogoditi.
            //običniDuplić = nulabilniDuplić;//Severity	Code	Description	Project	File	Line	Suppression State
            //Error CS0266  Cannot implicitly convert type 'double?' to 'double'.An explicit conversion exists (are you missing a cast?)   NulabilniVrijednosniTipovi C:\Users\katap\03-TipoviOperatori\NulabilniVrijednosniTipovi\NulabilniVrijednosniTipovi.cs	20	Active

            //052 Postaviti vrijednost varijable nulabilniDuplić na konačnu vrijednost te ispisati sadržaj.
            nulabilniDuplić = 5;
            Console.WriteLine(nulabilniDuplić);

            //053 Ponovno pokušati pridružiti varijabli običniDuplić vrijednost varijable nulabilniDuplić.
            //običniDuplić = nulabilniDuplić;//Severity	Code	Description	Project	File	Line	Suppression State
            //Error CS0266  Cannot implicitly convert type 'double?' to 'double'.An explicit conversion exists (are you missing a cast?)   NulabilniVrijednosniTipovi C:\Users\katap\03-TipoviOperatori\NulabilniVrijednosniTipovi\NulabilniVrijednosniTipovi.cs	28	Active

            Console.ReadKey();
        }
    }
}
