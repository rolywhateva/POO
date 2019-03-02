using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private string name;

        private uint age;
        public uint Age
        {
            get;set;
        }
        public string Name
        {
            get;set;
        }
    }
}