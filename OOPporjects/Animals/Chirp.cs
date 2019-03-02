using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Chirp : SoundBehaviour
    {
        public uint SoundFrequency
        {
            get; set;
        }
      
        public string Name { get; set; }

        public Chirp(string Name, uint SoundFrequency)
        {
            this.Name = Name;
            this.SoundFrequency = SoundFrequency;
        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name} chirps :");
            Console.WriteLine(Utils.MultipleStrings("Chirp", SoundFrequency));


        }
    }
}