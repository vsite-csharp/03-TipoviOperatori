using System.Reflection;

namespace Vsite.CSharp.TipoviOperatori
{
    static class Program
    {
        static void Main()
        {
            Type t = typeof(System.DateTime);

            Console.WriteLine($"*** Svi članovi klase {t.Name} ***");

            // :130 Pokrenuti program i pogledati što će ispisati donja petlja.
            foreach (MemberInfo mi in t.GetMembers())
            {
                Console.WriteLine($"{mi.Name} {mi.MemberType.ToString()}");
            }

            //Console.WriteLine($"*** Sve metode klase {t.Name} ***");

            // :131 Dodati petlju koja će za svaki član kojeg vrati metoda GetMethods ispisati ime metode i povratni tip.
            foreach (var meth in t.GetMethods())
            {
                Console.WriteLine($"{meth.Name} {meth.ReturnType}");
            }

            // :132 Proširiti tijelo petlje tako da se za svaku metodu ispišu i njeni parametri(tip i ime parametra).
            foreach (var meth in t.GetMethods())
            {
                Console.WriteLine($"{meth.Name} {meth.ReturnType}");

                foreach (var pars in meth.GetParameters())
                {
                    Console.WriteLine($"{pars.Name} {pars.ParameterType}");
                }
            }

            // :133 Proširiti tijelo petlje tako da se za svaku metodu ispišu ima li public, protected ili private pravo pristupa.
            foreach (var meth in t.GetMethods())
            {
                string pristup = "";
                if (meth.IsPrivate)
                {
                    pristup = "private";
                }
                else if (meth.IsPublic)
                {
                    pristup = "public";
                }
                else if (meth.IsFamily)
                {
                    pristup = "protected";
                }

                Console.WriteLine($"{meth.Name} {meth.ReturnType} {pristup}");
            }
            // :134 Napisati petlju koja će za donju instancu klase Object ispisati imena svih njenih članova.
            object o = new object();
            Console.WriteLine($"*** Svi članovi instance klase {o.GetType().Name} ***");

            foreach (var mem in o.GetType().GetMembers())
            {
                Console.WriteLine($"{mem.Name}");
            }

            Console.ReadKey();
        }
    }
}
