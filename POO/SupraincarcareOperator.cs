using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Complex
    {
        public double Re { get; set; }
        public double Im { get; set; }
        public Complex(double  Re,double Im)
        {
            this.Re = Re;
            this.Im = Im;
        }
        public override string ToString()
        {
            if (Re == 0 && Im == 0)
                return "0";
            else
                if (Re != 0 && Im == 0)
                    return Re.ToString();
            else
                if (Re == 0 && Im != 0)
                    return Im.ToString() + "i";
            else
                if (Im > 0)
                    return $"{Re}+{Im}i";
            else
                    return $"{Re}{Im}i";
        }
        static public Complex operator+(Complex a,Complex b)
        {
            return new Complex(a.Re + b.Re, a.Im + b.Im);
        }
        static public Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Re - b.Re, a.Im - b.Im);
        }
        //Daca se supraincarca un operator relational, opusul  sau trebuie
        //supraincarcat.
        static public  bool  operator ==(Complex a, Complex b)
        {
            return a.Im == b.Im && a.Re == b.Re;
        }
        static public bool operator !=(Complex a, Complex b)
        {
            return !(a == b);
        }

    }
    class SupraincarcareOperator
    {
        static void Main()
        {
            Complex a = new Complex(3, 4);
            Complex b = new Complex(3, 4);
            Console.WriteLine(a+b);
            Console.WriteLine(a - b);

            Console.ReadKey();
        }
    }
}
