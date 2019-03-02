using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punct
{
    class Triangle
    {
        Point p1, p2, p3;


        public Point P1
        {
            get { return p1; }
            set { p1 = value; }
        }

        public Point P2
        {
            get { return p2; }
            set { p2 = value; }

        }
        public Point P3
        {
            get { return p3; }
            set { p3 = value; }

        }
        public double L1
        {
            get
            {
                return Point.Distance(p1, p2);
            }
        }
        public double L2
        {
            get
            {
                return Point.Distance(p2, p3);
            }
        }
        public double L3
        {
            get { return Point.Distance(p1, p3); }
        }
        public Triangle(Triangle T)
        {
            P1 = T.P1;
            P2 = T.P2;
            P3 = T.P3;
        }
        public Triangle(Point p1, Point p2, Point p3)
        {
            double L1, L2, L3;
            L1 = Point.Distance(p1, p2);
            L2 = Point.Distance(p2, p3);
            L3 = Point.Distance(p3, p1);
            if (L1 + L2 > L3 && L1 + L3 > L2 && L3 + L2 > L1)
            {
                P1 = p1;
                P2 = p2;
                P3 = p3;
            }
            else
                Console.WriteLine("Nu este triunghi");
        }
      
        public double Perimeter
        {
            get
            {
                return L1 + L2 + L3;
            }
        }
        public double Area
        {
            get
            {
                double p = Perimeter / 2;
                return Math.Sqrt(p * (p - L1) * (p - L2) * (p - L3));
            }
        }


    }
}
