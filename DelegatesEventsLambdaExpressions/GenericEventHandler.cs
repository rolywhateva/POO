using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsLambdaExpressions
{
    class AB
    {
        public int A { get; set; }
        public int B { get; set; }
        public AB(int a, int b)
        {
            A = a;
            B = b;
        }
        public event EventHandler<ABEventArgs> Stats;
        public void Increase()
        {
          
            if (A > B)
                Stats(this, new ABEventArgs($"{A}>{B}"));
            else
                 if (A < B)
                Stats(this, new ABEventArgs($"{A} < {B}"));
            else
            {
                Stats(this, new ABEventArgs($"{A}={B}"));
                return;
            }
            System.Threading.Thread.Sleep(5000);
            A++;
            B--;
            Increase();

        }

    }
    class ABEventArgs : EventArgs
    {
        public readonly string msg;
        public ABEventArgs(string s)
        {
            msg = s;
        }
    }

    class GenericEventHandler
    {
        static void Main()
        {
            int fired = 0;
            AB ab = new AB(25, 78);
            //metoda anonima
            ab.Stats += delegate (object o, ABEventArgs e)
            {
                Console.WriteLine(e.msg);
                fired++;
                if(fired>=25)
                {
                    Console.WriteLine("The event has been fired {0} times.", fired);
                    fired = 0;
                }
            };
            ab.Increase();


            Console.ReadKey();
            return;
        }

    }
}

