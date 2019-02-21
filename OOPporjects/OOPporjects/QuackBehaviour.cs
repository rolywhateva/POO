using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPporjects
{
    public interface QuackBehaviour
    {
        /// <summary>
        /// The method to quack
        /// </summary>
        void quack(string name);
    }

    public class Quack : QuackBehaviour
    {
        public void quack(string name)
        {
            Console.WriteLine($"{name} quacked!");
        }
    }

    public class Squeak : QuackBehaviour
    {
        public void quack(string name)
        {
            Console.WriteLine($"{name} squeaked!");
        }
    }

    public class MuteQuack : QuackBehaviour
    {
        public void quack(string name)
        {
            Console.WriteLine($"{name}<<<Silence!>>>");
        }
    }
}