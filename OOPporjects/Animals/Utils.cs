using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    static class Utils
    {
        public  static  string MultipleStrings(string  msg, uint times)
        {
            string toReturn = "";
            for (int i = 0; i < times; i++)
                toReturn += msg + "\t";
            return toReturn;
        }
    }
}
