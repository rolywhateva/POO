using System;
using System.Collections.Generic;


namespace ProgramareaGenerica
{
    class StivaSiCoada
    {
        static void Main()
        {
            Stack<int> stiva = new Stack<int>();
            for (int i = 0; i < 10; i++)
                stiva.Push(i);
            while(stiva.Count>0)
            {
                Console.WriteLine(stiva.Pop());
            }
            Queue<int> coada = new Queue<int>();
            for (int i = 0; i < 10; i++)
                coada.Enqueue(i);
            Console.WriteLine();
            Console.WriteLine();
            while(coada.Count>0)
                Console.WriteLine(coada.Dequeue());

            Console.ReadKey();
            return;
        }
    }
}
