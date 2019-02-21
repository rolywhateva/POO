using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAdventureRPGClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Character Jake = new Knight();
            Jake.Weapon = new AxeBehaviour();
            Jake.Fight();
            Console.ReadKey();
            return;
        }
    }
}
