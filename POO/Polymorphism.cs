using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    //Polimorfism = Mai multe  subclase suprascriu aceeasi functie.
    abstract class character
    {
        protected string name;
        protected int age;
        public character(string name = "", int age = 0)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void Attack() { }

    }
    //knight = clasa derivata; character =super clasa/ clasa parinte
    //Functiile virtuale sunt suprascrise in  subclase.
    class knight : character
    {
        string typeofsword;
        public knight(string name = "", int age = 0, string typeofsword = "wood")
             : base(name, age)
        {
            this.typeofsword = typeofsword;
        }
        public override void Attack()
        {
            Console.WriteLine($"{name} proudly swings his {typeofsword} sword");
        }

    }
    class Polymorphism
    {
        static void Main()
        {

            Console.ReadKey();
        }
    }
}
