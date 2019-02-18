using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Indexatori
    {
        public class point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public override string ToString()
            {
                return $"({X},{Y})";
            }
        }
        public class PointCollection
        {
            private ArrayList points = new ArrayList();
            public int Length { get; }
            public point  this[int index]
            {
                get { return (point)(points[index]); }
                set { points[index] = value; }
            }
            public PointCollection(params point[] p)
            {
                Length = 0;
                foreach (point x in p)
                {
                    points.Add(x);
                    Length++;
                }
            }
        }
        static void Main()
        {
            PointCollection p = new PointCollection(
                new point(2, 3), new point(5, -7), new point(7, 0));
            for(int i=0;i<p.Length;i++)
                Console.WriteLine(p[i]);


           
            Console.ReadKey();
        }
    }
}
