using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(0,4);
            Point p2 = new Point(3, 0);
            Point p3 = new Point(0,0);
            Triangle T = new Triangle(p1,p2,p3);
            Console.WriteLine(T.Area);
            Console.WriteLine(T.Perimeter);
           
            Console.ReadKey();
        }
    }
}
