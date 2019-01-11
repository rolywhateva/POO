using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramareaGenerica
{
    class Dictionar
    {
        static void Main()
        {
            Dictionary<int, int> frecq = new Dictionary<int, int>();
            for (int i = 0; i < 10; i++)
                frecq.Add(i, 0);

            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
                frecq[rnd.Next(10)]++;
            for(int i=0;i<frecq.Count;i++)
                Console.WriteLine($"{i}-{frecq[i]}");
            foreach (int x in frecq.Keys)
                Console.WriteLine(x);
           
            return;
        }
    }
}
