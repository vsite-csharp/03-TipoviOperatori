using System;

namespace Vsite.CSharp.TipoviOperatori
{
    class Program
    {
        static void Main()
        {
            // ODO:000 Prevesti program te generirani kod pogledati ILDASM-om (IL disassemblerom).
            // Pogleda li se generirani međukod (IL), npr. pomoću ILDasm-a vidi se da svi tipovi osim 
            // decimal imaju direktne operacije u međujeziku!
            int i = 5;
            long l = 10;
            l = 4294967296;
            float f = 10.3F;
            double dbl = 12.8;
            decimal dec = 134.45M;
            string mirko = "slavko";
        }
    }
}
