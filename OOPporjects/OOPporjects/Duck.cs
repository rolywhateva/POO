using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPporjects
{
    public abstract class Duck
    {
        protected QuackBehaviour quackBehaviour;
        protected FlyBehaviour flyBehaviour;
        public string Name { get; set; }

      
        public void performQuack()
        {
            quackBehaviour.quack(Name);
        }
        public void performFly()
        {
            flyBehaviour.fly(Name);

        }

        public abstract void Display();
        public void swim()
        {
            Console.WriteLine("All ducks float!");

        }
        public void setFlyBehavior(FlyBehaviour fb)
        {
            flyBehaviour = fb;
        }
        public void setQuackBehavior(QuackBehaviour qb)
        {
            quackBehaviour = qb;
        }


    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehaviour = new Quack();
            flyBehaviour = new FlyWithWings();

        }
        public  override void  Display()
        {

            Console.WriteLine("I am a mallard duck!");
        }
    }
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            quackBehaviour = new Quack();
            flyBehaviour = new FlyNoWay();
        }
        public override void Display()
        {
            Console.WriteLine("I am a model duck!");

        }

    }
}



