using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public interface SoundBehaviour
    {
        uint SoundFrequency { get; set; }
        string Name { get; set; }
        void MakeSound();
    }
}