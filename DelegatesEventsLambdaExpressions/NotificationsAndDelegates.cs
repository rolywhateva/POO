using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsLambdaExpressions
{
    class NotificationsAndDelegates
    {
        public class Car
        {

            public int CurrentSpeed { get; set; }
            public int MaxSpeed { get; set; } = 100;
            public string PetName { get; set; }

            private bool carIsDead;

            public Car() { }
            public Car(string name, int maxSp, int currSp)
            {
                CurrentSpeed = currSp;
                MaxSpeed = maxSp;
                PetName = name;
            }
            public delegate void CarEngineHandler(string msgForCaller);
            private CarEngineHandler listOfHandlers;
            public void RegisterWithCarEngine(CarEngineHandler methodToCall)
            {
                //sau Combine
                listOfHandlers += methodToCall; //multicasting
            }
            public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
            {
                //sau Remove
                listOfHandlers -= methodToCall; //retragere
            }
            public void Accelerate(int delta)
            {
                // If this car is "dead," send dead message.
                if (carIsDead)
                {
                    if (listOfHandlers != null)
                        listOfHandlers("Sorry, this car is dead...");
                }
                else
                {
                    CurrentSpeed += delta;
                    // Is this car "almost dead"?
                    if (10 == (MaxSpeed - CurrentSpeed)
                    && listOfHandlers != null)
                    {
                        listOfHandlers("Careful buddy! Gonna blow!");
                    }
                }
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }
        }
        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("***********************************\n");
        }
        public static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("=> {0}", msg.ToUpper());
        }
        public static void OnCarEngineEvent3(string msg)
        {
            Console.WriteLine("=>{0}",msg.Reverse());
        }
        static void Main()
        {
                // First, make a Car object.
                Car c1 = new Car("SlugBug", 100, 10);
                // Now, tell the car which method to call
                // when it wants to send us messages.
                c1.RegisterWithCarEngine(new
                Car.CarEngineHandler(OnCarEngineEvent));
            Car.CarEngineHandler handler2 = new Car.CarEngineHandler( OnCarEngineEvent2);
            c1.RegisterWithCarEngine(handler2);
                // Speed up (this will trigger the events).
                Console.WriteLine("***** Speeding up *****");
                for (int i = 0; i < 6; i++)
                    c1.Accelerate(20);
            // Unregister from the second handler.
            c1.UnRegisterWithCarEngine(handler2);
            // We won’t see the "uppercase" message anymore!
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
            Car c2 = new Car("Bitchy", 100, 5);
            c2.RegisterWithCarEngine(handler2);
            c2.RegisterWithCarEngine(OnCarEngineEvent3); //method group
            for (int i = 0; i < 6; i++)
                c2.Accelerate(20);
           




            Console.ReadKey();
            return;
        }
    }
}
