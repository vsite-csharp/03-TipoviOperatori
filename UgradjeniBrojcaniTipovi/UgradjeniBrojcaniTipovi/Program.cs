using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            //int a = int.Parse("two");   //neće
            int a = int.Parse("12");    //da

            
            int veliki = int.MaxValue;
            Console.WriteLine(++veliki);
            
            int mali = int.MinValue;
            Console.WriteLine(--mali);
           
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            
            double aDouble=3.0;  //potrebno staviti . ili .0
            Console.WriteLine(aDouble / 0); //beskonačno
            //Console.WriteLine(mali / 0);    //OPREZ: za int....Unhandled Exception:
            Console.WriteLine(aDouble / -1);    //-3

            
            aDouble = 0;
            Console.WriteLine(aDouble / 0);     //NaN
            

            double b = 5.0;

            
            //int c = b;        //NE ide jer kompajler sprječava preljev koji bi omogućio gubitak podataka 
            int c =(int) b;     //castamo
                             
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            
            //double bDouble =decimal.MaxValue;     //greška....stvar je u preciznosti pa nas kompajler upozorava
            double bDouble = (double)decimal.MaxValue;

            float f1 = 1.23456789e23F;  //staviti F za razliku double i float-a
            float f2 = 1.2345678988e23F;

            double f3 = 1.23456789e23F;  //staviti F za razliku double i float-a
            double f4 = 1.2345678988e23F;

            Console.WriteLine(f1 - f2);     //dobijemo: 0....jer float pamti 7 znamenaka pa zbog viška odreže i da 0
            Console.WriteLine(f3 - f4);
            Console.ReadKey();
        }
    }
}
