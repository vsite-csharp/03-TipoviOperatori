using System;

namespace Vsite.Csharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(int.MaxValue);
			Console.WriteLine(int.MinValue);

			
			int a = int.MaxValue;
			a++;
			Console.WriteLine(a);
			
			int b = int.MaxValue;
			a--;
			Console.WriteLine(a);
			
			
			Console.WriteLine(double.MaxValue);
			
			Console.WriteLine(double.MaxValue);
			
			double c = 3.0;
			Console.WriteLine(c / 0);
			double d = -3.0;
			Console.WriteLine(d / 0);

			
			double f = 0;
			Console.WriteLine(f / 0);
			
			double e = 5;
			
			//int g = double.MaxValue;

			
			decimal s = decimal.MaxValue;
			decimal j = decimal.MinValue;
			Console.WriteLine(s);
			Console.WriteLine(j);
			
			double naj = double.MaxValue;
			Console.WriteLine(naj);
			Console.ReadKey();
        }
    }
}
