using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
     class Persoana
    {
        private int varsta;
        public string Name { get; set; }
        public int Varsta
        {
            get
            {
                return varsta;
            }
            set
            {
                if (value <= 18)
                    throw new Exception("Persoana minora");
                else
                    varsta = value;

             
            }
        }
    }
    class Exceptii
    {  //try,catch,finally,when
        static void Main()
        {
            /*
            int a = 3, b = 0;
            try
            {
                Console.WriteLine(a/b);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */
            Persoana p = new Persoana();
            try
            {
                p.Varsta = 8;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
                Console.WriteLine("Nice try, little bitch!");

            }
          
            Console.ReadKey();
        }
    }
}
