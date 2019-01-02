using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    abstract class character
    {
        protected string name;
        protected int age;
        public character(string name="",int age=0)
        {
            this.name = name;
            this.age = age;
        }
    public  virtual void Attack(){}
        
    }
    //knight = clasa derivata; character =super clasa/ clasa parinte
    
    class knight : character
    {
        string typeofsword;
        public  knight(string name="",int age=0,string typeofsword="wood")
             :base(name,age)
        {
            this.typeofsword = typeofsword;
        }
        public  void    Attack()
        {
            Console.WriteLine($"{name} proudly swings his {typeofsword} sword");
        }

    }
class mage :character 
{
    string typeofwand;
    public  mage(string name="", int age =0, string typeofwand="acacia")
         :base(name,age)
    {
        this.typeofwand = typeofwand;
    }
    public   void Attack()
    {
        Console.WriteLine($"{name} casts a spell with their {typeofwand} wand");
    }
}
    public class Inheritance
    {
       

        static void Main()
        {
            knight k = new knight("Charles", 32, "iron");
            k.Attack();
        mage m = new mage("Merlin", 102, "staff");
        m.Attack();

            Console.ReadKey();
        }
    }

