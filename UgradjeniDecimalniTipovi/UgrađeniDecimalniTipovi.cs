namespace Vsite.CSharp.TipoviOperatori
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine($"Double Max Value: {double.MaxValue}");
            Console.WriteLine($"Double Min Value: {double.MinValue}");
            Console.WriteLine($"Float Max Value: {float.MaxValue}");
            Console.WriteLine($"Float Min Value: {float.MinValue}");
            Console.WriteLine($"Decimal Max Value: {decimal.MaxValue}");
            Console.WriteLine($"Decimal Min Value: {decimal.MinValue}");

            float f1 = 1234567890;
            float f2 = 1234567990;
            float f3 = 9;
            Console.WriteLine($"f1 - f2 = {f1 - f2:F2}");
            Console.WriteLine($"f1 - f3 = {f1 - f3:F2}");

            double trećina1 = 1.0 / 3.0;
            double trećina2 = 1.0 - 2.0 / 3.0;
            Console.WriteLine($"trećina1 = {trećina1:F15}");
            Console.WriteLine($"trećina2 = {trećina2:F15}");
            Console.WriteLine($"trećina1 - trećina2 = {trećina1 - trećina2:F15}");

            Console.WriteLine($"double.MaxValue * 2 = {double.MaxValue * 2}");
            Console.WriteLine($"double.MinValue * 2 = {double.MinValue * 2}");

            double result1 = 5.0 / 0;
            double result2 = 0.0 / 0; 
            Console.WriteLine($"5.0 / 0 = {result1}");
            Console.WriteLine($"0.0 / 0 = {result2}");

            double var1 = 5.0;

            int var2 = (int)var1;
            Console.WriteLine($"var2 = {var2}");


            Console.ReadKey();
        }
    }
}
