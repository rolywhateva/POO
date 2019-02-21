using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPporjects
{
   
  
    class Program
    {
        /*
         *
         * 
         * 
         * 
         * 
         * */
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.Name = "Funky";
            mallard.performQuack();
            mallard.performFly();

            Console.ReadKey();
            return;

        }
    }
}
