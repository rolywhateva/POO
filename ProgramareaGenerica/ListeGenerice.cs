using System;
using System.Collections.Generic;


namespace ListeGenerice
{
    class ListeGenerice
    {
        static void Main(string[] args)
        {
            List<int> listaDeIntregi = new List<int>();
            List<int> lista = new List<int>(5);
            for (int i = 0; i < 10; i++)
                listaDeIntregi.Add(i);
            listaDeIntregi.AddRange(new int[] { -1, -2, -3, -4, -5 });
            listaDeIntregi.AddRange(new List<int> { 20, 30, 40 });
            foreach (int x in listaDeIntregi)
                Console.Write($"{x}\t");
            Console.WriteLine();
            for (int i = 0; i < listaDeIntregi.Count; i++)
                Console.WriteLine($"{listaDeIntregi[i]}\t");
            Console.WriteLine();
            listaDeIntregi.Sort();
            Console.WriteLine("("+String.Join(",", listaDeIntregi)+")");
            listaDeIntregi.Reverse();
            listaDeIntregi.Find(x=>x%2==0);
            Console.WriteLine(string.Join(",",listaDeIntregi.FindAll(x => x % 2 == 0)));
            Console.ReadKey();

            return; 
        }
    }
}
