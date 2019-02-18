using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsLambdaExpressions
{
    class GenericDelegates
    {
        static void PrintInt(int msg)
        {
            Console.WriteLine("Int:{0}", msg);
        }
        static void PrintMsg(string msg)
        {
            Console.WriteLine("String:'{0}'",msg);
        }
        public delegate void GenericPrint<T>(T msg);
        static void Main()
        {
            GenericPrint<int> intPrintDelegate = PrintInt;
            intPrintDelegate(5);


            Console.ReadKey();
            return;
        }
    }
}
