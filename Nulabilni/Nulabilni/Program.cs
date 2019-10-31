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

            Nullable<int> nulabilniint = null;
            Console.WriteLine(nulabilniint);
            nulabilniint = 314;
            Console.WriteLine(nulabilniint);

            Console.ReadKey();
        }
    }
}
