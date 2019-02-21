using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPporjects
{
    public interface FlyBehaviour
    {
        /// <summary>
        /// The method for flying
        /// </summary>
        void fly(string name);
    }

    public class FlyWithWings : FlyBehaviour
    {
        public void fly(string name )
        {
            Console.WriteLine($"{name} flies with their wings!");
        }
    }

    public class FlyNoWay : FlyBehaviour
    {
        public void fly(string name)
        {
            Console.WriteLine($"{name} can't fly!");
        }
    }

    public class FlyRocketPowered : FlyBehaviour
    {
        public void fly(string name)
        {
            Console.WriteLine($"{name} is flying with a  rocket!");
        }
    }
}