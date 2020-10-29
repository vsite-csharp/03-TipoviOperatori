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
            int i = 1;
            long lng = i;
            short sht = (short)i;

            // Primjeri numeričkog preljeva
            int najveca = int.MaxValue;
            ++najveca;
            Console.WriteLine(najveca);
            int najmanja = int.MinValue;
            --najmanja;
            Console.WriteLine(najmanja);

            // Primjer cjelobrojnog dijeljenja nulom
            Console.WriteLine(i / 0);
            Console.ReadKey();
        }
    }
}
