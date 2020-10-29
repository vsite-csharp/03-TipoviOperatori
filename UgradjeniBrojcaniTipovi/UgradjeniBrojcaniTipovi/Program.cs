using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);


          
            int veliki = int.MaxValue;
            Console.WriteLine(++veliki);
           
            int mali = int.MinValue;
            Console.WriteLine(--veliki);

            Console.WriteLine(mali / 0);

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            
            double a = 3.0;

            Console.WriteLine(a / 0);


            double b = 5.0;

            // TODO:037 Dvjema varijablama tipa int pridružiti vrijednost prethodno definirane varijable, odnosno najvećeg broja tipa double i ispisati njihove vrijednosti.
            int c =(int)b;
            // TODO:038 Ispisati najveće i najmanje vrijednosti tipa decimal.
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            decimal d1 = decimal.MaxValue;
            // TODO:039 Varijabli tipa double pridružiti najveću vrijednost tipa double i ispisati rezultat.
            double d = (double)decimal.MaxValue; //mogući gubitak znamenki (mogao bi broj stati, ali doći će do gubitka inf.)-napraviti cast

            double f1 = 1.23456789e23F; //double ima veci raspon od floata-(F)
            double f2 = 1.23456788e23F;

            Console.WriteLine(f1 - f2);

            Console.ReadKey();
        }
    }
}
