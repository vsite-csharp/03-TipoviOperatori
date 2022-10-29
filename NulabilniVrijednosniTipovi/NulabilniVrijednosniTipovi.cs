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

            nulabilniDuplić=null;
            Console.WriteLine(nulabilniDuplić);


            
            try { običniDuplić = nulabilniDuplić.Value; }catch(Exception ex) { Console.WriteLine(ex); }
            
            nulabilniDuplić = 5;
            try { običniDuplić = nulabilniDuplić.Value; } catch (Exception ex) { Console.WriteLine(ex); }
            Console.WriteLine(običniDuplić);
            

            Console.ReadKey();
        }
    }
}
