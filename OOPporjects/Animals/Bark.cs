using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Bark : SoundBehaviour
    {
        public uint SoundFrequency
        {
            get;set;
        }
        private  Animal animal
        {
            get;set;
        }
        public string Name
        {
            get;set;
        }

        public Bark(string Name,uint SoundFrequency)
        {
            this.Name = Name;
            this.SoundFrequency = SoundFrequency;
        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name} barks :");
            Console.WriteLine(Utils.MultipleStrings("Woof", SoundFrequency));


        }
    }
}