using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            //Otkomentirati donju naredbu koja ispisuje najveći broj koji se može pohraniti u tip int.
            Console.WriteLine(int.MaxValue);
           
            Console.WriteLine(long.MaxValue);
            

            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MinValue);
            int a = 1;
            long dugi = a;
           
            short kratki = (short)a;


            int najveca = int.MaxValue;
            ++najveca;
            Console.WriteLine(najveca);


            int najmanja = int.MinValue;
            --najmanja;
            Console.WriteLine(najmanja);
            
            
            
            Console.WriteLine(a/0);







            Console.ReadKey();
        }
    }
}
