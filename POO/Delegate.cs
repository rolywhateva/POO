using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Delegate
    {
        //Delegata = pointer catre functie
        //O delegata implicit declara o clasa care se deriva
        //din System.MulticastDelegate
        public delegate int BinaryOp(int a, int b);
        static class MathOperations
        {
           public static int Add(int a, int b) => a + b;
           public  static int Sub(int a, int b) => a- b;
           public  static int Mult(int a, int b) => a * b;
           public  static int Div(int a, int b) => a/b;
           public  static int Rem(int a, int b) => a % b;
        }
        
        static void Main()
        {
            BinaryOp addOp = new BinaryOp(MathOperations.Add);
            Console.WriteLine(  addOp(3, 5));
            Console.ReadKey();

        }
    }
}
