using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsLambdaExpressions
{
    /**
     * 
     * Eveniment = obiect de tip delegata,  scurtatura pentru functiile 
     * care adauga si retrag functii din lista de invocari.
     * */
    class Dog
    {
        public string Name { get; set; }
        public uint Weight { get; set; }
        public string[] Favs { get; set; }
        public  Dog(string name, uint weight,string[] favs)
        {
            Name = name;
            Weight = weight;
            Favs = favs;
        }
        public  delegate void  TreatHandler(string msg);
        public event TreatHandler TooMuch;
        public delegate bool PreferenceHandler(string s, string[] pref);
        public event TreatHandler DontLike;
        public  void Feed(uint noOfTreats,string treat)
        {
            if (Weight >= 100)
                Console.WriteLine("This dog is too fat!");
            else
            {
                if (noOfTreats >= 16 && TooMuch != null)
                {
                    TooMuch("You are overfeeding the dog!");
                    return;
                }
                bool found = false;
                for (int i = 0; i < Favs.Length && !found; i++)
                    if (Favs[i] == treat)
                        found = true;
                if(!found)
                {
                    DontLike?.Invoke($"{Name} doesn't like {treat}");
                    return;
                }
                Weight += noOfTreats;

                

            }
        }

    }
  
    class EventType
    {
        static public void PreferenceInformer(string msg)
        {
            Console.WriteLine("The dog does not like this!");
            Console.WriteLine(msg);

        }
        static public void QuantityInformer(string msg)
        {
            Console.WriteLine("Too much!");
            Console.WriteLine(msg);




        }
        static void Main()
        {
            Dog dog1 = new Dog("Bundy", 28, new string[] { "fries", "meat", "biscuit" });
            dog1.DontLike += PreferenceInformer;
            dog1.TooMuch += QuantityInformer;
            dog1.Feed(15, "dicks");



            Console.ReadKey();
            return;
        }

      
    }
}
