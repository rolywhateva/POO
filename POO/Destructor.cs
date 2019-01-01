using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    //destructor = functie apelata atunci cand nu ramane niciun obiect de tipul clasei respective.
    class Robot
    {
        string name;
        static int nr;
        static  Robot()
        {
            Console.WriteLine("Let the robo fun begin!");
            nr = 0;
        }
        public Robot(string s)
        {
           
            name = s;
            Console.WriteLine($"{this.name} was added to the team!");
            nr++;
        }
        public string GetName()
        {
            return name;
        }
        ~Robot()
        {
            Console.WriteLine(this.name + " self destructs.");
            nr--;
         
        }

    }
  
    class Destructor
    {
        static void foo()
        {
            Robot poo = new Robot("foo");
        }
        static void Main()
        {
            foo();
            
            Console.ReadKey();
          
        }
    }
}
