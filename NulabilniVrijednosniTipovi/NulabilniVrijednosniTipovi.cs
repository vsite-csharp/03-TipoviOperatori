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

            nulabilniDuplić = null;
            Console.WriteLine(nulabilniDuplić);
            nulabilniDuplić = 10;
            Console.WriteLine(nulabilniDuplić);
            običniDuplić = (double)nulabilniDuplić;
            Console.WriteLine(običniDuplić);
            Console.ReadKey();
        }
    }
}
