using System.Reflection;
using System.Runtime.Intrinsics.X86;

namespace Vsite.CSharp.TipoviOperatori
{
    static class Program
    {
        static void Main()
        {
            Type t = typeof(System.DateTime);

            Console.WriteLine($"*** Svi članovi klase {t.Name} ***");

            // 130 Pokrenuti program i pogledati što će ispisati donja petlja.
            /*foreach (MemberInfo mi in t.GetMembers())
            {
                Console.WriteLine($"{mi.Name} {mi.MemberType.ToString()}");
            }*/

            Console.WriteLine($"*** Sve metode klase {t.Name} ***");
          

            //131 Dodati petlju koja će za svaki član kojeg vrati metoda GetMethods ispisati ime metode i povratni tip.
            foreach(MemberInfo mi in t.GetMethods())
            {
                Console.WriteLine($"{mi.Name} {mi.MemberType.ToString()}");
                MethodInfo method = mi  as MethodInfo;
                ParameterInfo[] parametri = method.GetParameters();
                foreach(ParameterInfo pi in parametri) 
                {
                    Console.WriteLine($"Parametar: {pi.Name}, Tip:{pi.ParameterType}");
                }
                if(method.IsPublic) { Console.WriteLine("Public"); }
                else if (method.IsPrivate) { Console.WriteLine("Private"); }
                else { Console.WriteLine("Protected");}
            }
            //132 Proširiti tijelo petlje tako da se za svaku metodu ispišu i njeni parametri(tip i ime parametra).

            //133 Proširiti tijelo petlje tako da se za svaku metodu ispišu ima li public, protected ili private pravo pristupa.

            //134 Napisati petlju koja će za donju instancu klase Object ispisati imena svih njenih članova.
            object o = new object();
            Console.WriteLine($"*** Svi članovi instance klase {o.GetType().Name} ***");
            Type type = o.GetType();
            MemberInfo[] member = type.GetMembers();
            foreach(MemberInfo m in member)
            { Console.WriteLine(member); }
            Console.ReadKey();
        }
    }
}
