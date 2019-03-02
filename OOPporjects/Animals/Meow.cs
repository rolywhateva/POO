using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Meow : SoundBehaviour
    {
        public uint SoundFrequency
        {
            get; set;
        }
        public string Name { get; set; }
     

        public Meow(string Name, uint SoundFrequency)
        {
            this.Name = Name;
            this.SoundFrequency = SoundFrequency;
        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name}  meows :");
            Console.WriteLine(Utils.MultipleStrings("Meow", SoundFrequency));


        }
    }
}