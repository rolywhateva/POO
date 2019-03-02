using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punct
{
    class Point
    {
        private double x, y;
        public double X
        {
            get
            {
                return x;

            }
            set
            {

                x = value;

            }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point()
        {
            x = y = 0;
        }
        public Point(double x, double y)
        {
            X = x;
            Y = y;

        }
        public Point(Point ToCopy)
        {
            X = ToCopy.X;
            Y = ToCopy.Y;
        }

        static public double Distance(Point A, Point B)
        {
            return Math.Sqrt((B.Y - A.Y) * (B.Y - A.Y) + (B.X - A.X) * (B.X - A.X));
        }


   


      
    }
}
