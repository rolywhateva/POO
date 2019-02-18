using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsLambdaExpressions
{
    class ActionAndFunc
    {
        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            // Set color of console text.
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;
            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }
            // Restore color.
            Console.ForegroundColor = previous;
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static string SumToString(int x, int y)
        {
            return (x + y).ToString();
        }
        static int Produs(int x, int y)
        {
            return x * y;
        }
        static void Main()
        {
            // Use the Action<> delegate to point to DisplayMessage.
            //Poate arata catre o functie cu tip returnat void si maxim 16 argumente.
            Action<string, ConsoleColor, int> actionTarget =
            new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget("Action Message!", ConsoleColor.Yellow, 5);


            Func<int, int, int> funcTarget = new Func<int, int, int>(Add);
            int result = funcTarget.Invoke(40, 40);
            Console.WriteLine("40 + 40 = {0}", result);


            Func<int, int, string> funcTarget2 = new Func<int, int, string>
            (SumToString);


            string sum = funcTarget2(90, 300);
            Func<int, int, int> funTarget3 = new Func<int, int, int>(Produs);
            Console.WriteLine(funTarget3(3, 4));
            Console.WriteLine(sum);
            Console.ReadLine();
            Console.ReadKey();
            return;
        }
    }
}
