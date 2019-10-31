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

            //običniDuplić = null;

            Nullable<int> nulabilniInt = null;
            Console.WriteLine("Nullable<int> " + nulabilniInt);


            nulabilniInt = 3;
            Console.WriteLine("Nullable<int> " + nulabilniInt);

            Console.ReadKey();
        }
    }
}
