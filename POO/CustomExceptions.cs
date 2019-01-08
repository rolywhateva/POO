using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Fighter
    {

        private int health;
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private int Health
        {
            get
            {
                return health;
            }
            set
            {
                int aux = health;
                health = value;
                if (aux > health)
                    Console.WriteLine($"{Name} had been damaged for {aux - health}");
                if(health<0)
                    Console.WriteLine();
            }
        }
  
        private int Maxpower { get; set; }
        public Fighter(string name, int health, int maxPower)
        {
            Name = name;
            Health = health;
            Maxpower = maxPower;
        }
        public void Attack(Fighter d)
        {
            int hit = new Random().Next() % 30 + 1;
            Console.WriteLine($"{Name} swings his sword at {d.Name} and deals {hit} damage");
            d.Health -= hit;
            if (d == this)
            {
                
                SelfHarmException hitsHimself = new SelfHarmException(
                    string.Format($"{Name} has gone mad! He hit himself!"),
                    string.Format($"This is not normal!"),
                    DateTime.Now,hit);
                throw hitsHimself;
            }
            
          
           

        }

    }
    class SelfHarmException : Exception
    {
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }
        public int CausedDamage { get; set; }
        public SelfHarmException(string message,string cause, DateTime time, int damage)
            :base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
            CausedDamage = damage;

        }
       
    }
   

    class CustomExceptions
    {
        static void Main()
        {
        Fighter Charles = new Fighter("Charles", 300,15);
        Fighter John = new Fighter("John", 250,25);
        Console.WriteLine("Charles and John are fighting");
            try
            {

                John.Attack(John);
            }catch(SelfHarmException e)
            {
              
               
                Console.WriteLine(e.Message);
                Console.WriteLine(e.CauseOfError);
            }


            Console.ReadKey();
        }
    }
}
