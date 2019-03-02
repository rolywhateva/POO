using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Wilson = new Dog("Wilson", 42);
            Wilson.Sound.MakeSound();

            Wilson.ChangeSound(new Meow("", 5));
            Wilson.Sound.MakeSound();
          

            Console.ReadKey();
        }
    }
}
