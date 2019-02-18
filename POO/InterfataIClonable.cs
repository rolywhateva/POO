using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Point:ICloneable 
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString()
        {
            return $"({X},{Y})";
        }
        public PointDescription desc;
        public Point(int xPos, int yPos, string petName)
        {
            X = xPos; Y = yPos;
            desc = new PointDescription();
            desc.PetName = petName;
        }
        public object Clone()
        {
            //Copierea
            Point newPoint = (Point)this.MemberwiseClone();
             //Completarea
            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;
            return newPoint;
            //sau in loc de toate astea
            //return new Point(X, Y, desc.PetName);
        }
    }
    public class PointDescription
    {
        public string PetName { get; set; }
        public Guid PointID { get; set; }
        public PointDescription()
        {
            PetName = "No-name";
            PointID = Guid.NewGuid();
        }
    }
    class InterfataIClonable
    {
        static void Main()
        {
            Console.WriteLine("***** Fun with Object Cloning *****\n");
            Console.WriteLine("Cloned p3 and stored new Point in p4");
            Point p3 = new Point(100, 100, "Jane");
            Point p4 = (Point)p3.Clone();
            Console.WriteLine("Before modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);
            p4.desc.PetName = "My new Point";
            p4.X = 9;
            Console.WriteLine("\nChanged p4.desc.petName and p4.X");
            Console.WriteLine("After modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);
            Console.WriteLine(p3.desc.PetName);
            Console.WriteLine(p4.desc.PetName);
            Console.ReadLine();
        }

    }
}
