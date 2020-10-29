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
            običniDuplić = (double)nulabilniDuplić;
            nulabilniDuplić = 10;
            nulabilniDuplić = običniDuplić;
            Console.WriteLine(nulabilniDuplić);
            Console.ReadKey();
        }
    }
}
