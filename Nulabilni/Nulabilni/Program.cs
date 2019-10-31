using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            double? nulabilniDuplić = Math.PI;
            Console.WriteLine(nulabilniDuplić);

            nulabilniDuplić = null;
            Console.WriteLine(nulabilniDuplić);

            double običniDuplić = Math.PI;
            Console.WriteLine(običniDuplić);

            //obićniDuplić = null;

            Nullable<double> nullableD = null;
            Console.WriteLine(nullableD);

            nullableD = 25.2525252525;
            Console.WriteLine(nullableD);

            Console.ReadKey();
        }
    }
}
