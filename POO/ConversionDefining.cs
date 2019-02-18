using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
   public struct  Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(int w, int h) : this()
        {
            Width = w; Height = h;
        }
        public void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    public struct Square
    {
        public int Length { get; set; }
        public Square(int l) : this()
        {
            Length = l;
        }
        public void Draw()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public override string ToString()
        { return string.Format("[Length = {0}]", Length); }
        public static explicit operator Square(Rectangle r)
        {
            Square s = new Square();
            s.Length = r.Height;
            return s;
        }

    }
        class ConversionDefining
    {

        static void Main()
        {
            Console.WriteLine("***** Fun with Conversions *****\n");
            // Make a Rectangle.
            Rectangle r = new Rectangle(15, 4);
            Console.WriteLine(r.ToString());
            r.Draw();
            Console.WriteLine();
            // Convert r into a Square,
            // based on the height of the Rectangle.
            Square s = (Square)r;
            Console.WriteLine(s.ToString());
            s.Draw();
            Console.ReadLine();

            return;
        }
    }
}
