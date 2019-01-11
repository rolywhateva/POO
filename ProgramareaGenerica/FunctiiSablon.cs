using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramareaGenerica
{
    class FunctiiSablon
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T aux;
            aux = a;
            a = b;
            b = aux;
        }
        static void Main()
        {
            int a = 3, b = 5;
            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");
            Swap<int>(ref a, ref b);
            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");
            string s1 = "Hello", s2 = "Kitty";
            Console.WriteLine($"s1={s1}");
            Console.WriteLine($"s2={s2}");
            Console.WriteLine();
            Console.WriteLine("Interschimbare");
            //tipul se poate omite dar nu e recomandat!
            Swap<string>(ref s1, ref s2); // <==> Swap(ref s1,ref s2);
            Console.WriteLine($"s1={s1}");
            Console.WriteLine($"s2={s2}");


            Console.ReadKey();

        }
    }
}
