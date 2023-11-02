namespace Vsite.CSharp.TipoviOperatori
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);

            int var1 = 1;
            long var2 = var1;
            short var3 = (short)var1;

            int maxOverflow = int.MaxValue;
            Console.WriteLine(maxOverflow + 1);

            int minOverflow = int.MinValue;
            Console.WriteLine(minOverflow - 1);

            

            //int divisionByZero = 5 / 0;


            Console.ReadKey();
        }
    }
}
