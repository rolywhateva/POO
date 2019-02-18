using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsLambdaExpressions
{
    class Delegates
    {
        /*
         * O delegata  retine trei informatii:
         * ->adresa  functiei
         * ->tipul returnat(daca exista) 
         * ->parametrii(daca exista) 
         * Cand se defineste un tip delegata, compilatorul automat genereaza o clasa
         * sealed  pentru acel tip,derivat de la tipul System.MulticastDelegate.Ea (clasa
         * derivata) contine metode precum: 
         * Invoke, BeginInvoke,EndInvoke
         *sealed class NumeleTipuluiDelegata : System.MulticastDelegate
{
public tipReturnat Invoke(<parametrii>);
public IAsyncResult BeginInvoke(<parametrii>,
AsyncCallback cb, object state);
public tipReturnat EndInvoke(IAsyncResult result);
}
         * 
         * 
         * */
        public delegate int BinaryOp(int a, int b);
        public delegate void PrintMessage(string msg);
        static void DisplayDelegateInfo(Delegate delObj)
        {

            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method Name: {0}", d.Method);
                Console.WriteLine("Type Name: {0}", d.Target);
            }
        }
        static public int Add(int a, int b)
        {
            return a + b;
        }
        class MessageClass
        {
            public void PrintMessage(string msg)
            {
                Console.WriteLine(msg);
            }
            public void PrintReverseMessage(string msg)
            {
                Console.WriteLine(msg.Reverse());
            }
        }

        static void Main(string[] args)
        {
            BinaryOp operationDelegate = new BinaryOp(Delegates.Add);
            //sau operationDelegate = Program.Add;
            Console.WriteLine(operationDelegate(3, 5));
            Console.WriteLine(operationDelegate.Invoke(3, 5));
            DisplayDelegateInfo(operationDelegate);
            MessageClass message = new MessageClass();
            PrintMessage messageDelegate = message.PrintMessage;
            messageDelegate("Hello world!");
            messageDelegate = message.PrintReverseMessage;
            messageDelegate("Hello world!");
            DisplayDelegateInfo(messageDelegate);



            Console.ReadKey();
        }
    }
}
