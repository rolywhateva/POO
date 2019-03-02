using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Dog : Animal
    {
        SoundBehaviour sound;
        public SoundBehaviour Sound
        {
            get { return sound; }
            set { sound = value; }
        }
        public  Dog(string name, uint age)
        {
            Age = age;
            Name = name;
            Sound = new Bark(name, 5);
            

           

        }
        public Dog(Dog d)
        {
            Name = d.Name;
            sound = d.Sound;
            Age = d.Age;

        }
        public void ChangeSound(SoundBehaviour newSound)
        {
            Sound = newSound;
            Sound.Name = this.Name;
        }
        public void Bark()
        {
            sound.MakeSound();
        }

    }
}