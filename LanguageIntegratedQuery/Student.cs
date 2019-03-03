using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageIntegratedQuery
{
    class Student
    {
        public Guid StudentGuid
        {
            get;set;
        }
        public string Name
        {
            get;set;
        }
        public int Age
        {
            get;set;
        }
        public  Student(Guid guid, string name, int age)
        {
            StudentGuid = guid;
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return string.Format("StudentID:{0}\nName:{1}\nAge:{2}", 
                                StudentGuid.ToString(), Name, Age);
        }
    }
}
