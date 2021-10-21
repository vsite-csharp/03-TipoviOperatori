using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // TODO:000 Prevesti program te generirani kod pogledati ILDASM-om (IL disassemblerom).
            // Pogleda li se generirani medjukod (IL), npr. pomocu ILDasm-a vidi se da svi tipovi osim 
            // decimal imaju direktne operacije u medjujeziku!
            int i = 5;
            long l = 10;
            l = 4294967296;
            float f = 10.3F;
            double dbl = 12.8;
            double dbl2 = 1.28;
            decimal dec = 134.45M;
            decimal dec2 = 1344.5M;
            decimal dec3 = 13445M;

            string mirko = "slavko";

        }
    }
}
