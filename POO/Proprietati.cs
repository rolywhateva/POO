using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class robot
    {
        string name;
        int type;
        public  robot(string name, int type)
        {
            this.name = name;
            this.type = type;
        }
        public  robot()
        {

        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public void Present()
        {
            Console.WriteLine($"Hey, I am {name} and I am a type {type} robot.");
        }
    }
    class Proprietati
    { 
        static void Main()
        {
            robot jasper = new robot("Jasper", 32);
            jasper.Present();
            robot mycin = new robot();
            mycin.Name = "Mycin";
            mycin.Type = 12;
            mycin.Present();
            Console.ReadKey();
        }

    }
}
