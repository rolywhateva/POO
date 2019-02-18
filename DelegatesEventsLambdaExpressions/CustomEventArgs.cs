using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsLambdaExpressions
{  
    class Example
    {
        public int Nr { get; set; }

        public delegate void MessageHandler(object sender, ExampleArgs e);
        public event MessageHandler Verifiers;
        public void Increase()
        {
            Nr++;
            Console.WriteLine(Nr);
              Verifiers?.Invoke(this, new ExampleArgs("Property notification"));
            System.Threading.Thread.Sleep(5000);
            Increase();

        }
    }
    class ExampleArgs:EventArgs
    {
        public readonly string msg;
        public  ExampleArgs(string message)
        {
            msg = message;
        }
    }
    class CustomEventArgs
    {
        static public void IsSquare(object sender, ExampleArgs e)
        {
            var number = (sender as Example).Nr;
            if(Math.Sqrt(number)==(int)Math.Sqrt(number))
            {
                Console.WriteLine("{0}:{1} is square", e.msg, number);
            }
        }
        static public void IsPrime(object sender,ExampleArgs e)
        {
            var number = (sender as Example).Nr;
            bool prim = true;
            if (number < 2) prim = false;
            for (int i = 2; i * i <= number && prim; i++)
                if (number % i == 0)
                    prim = false;
            if(prim)
            {
                Console.WriteLine("{0}:{1} is prime", e.msg, number);
            }

        }
        static void Main()
        {
            Example ex = new Example();
            ex.Nr = 5;
            ex.Verifiers += IsSquare;
            ex.Verifiers += IsPrime;
            ex.Increase();

            Console.ReadKey();
            return;
        }
    }
}
