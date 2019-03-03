using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageIntegratedQuery
{
    /*
     * System.Core.dll
Defines the types that represent the core LINQ API. This is the one
assembly you must have access to if you want to use any LINQ API,
including LINQ to Objects.
System.Data.DataSetExtensions.dll Defines a handful of types to integrate ADO.NET types into the LINQ
programming paradigm (LINQ to DataSet).
System.Xml.Linq.dll Provides functionality for using LINQ with XML document data
(LINQ to XML).
     * 
     * */
    class Program
    {
        static void Main(string[] args)
        {
            string[] currentVideoGames = {"Morrowind", "Uncharted 2",
"Fallout 3", "Daxter", "System Shock 2"};
            var  subset = from g in currentVideoGames
                          where g.Contains(" ")
                          orderby g
                          select g;
            foreach(string s in subset)
            {
                Console.WriteLine(s);
            }
            int[] numbers = { 1, -3, 4, -3, 4, -2, -3, -10, 11, -23, 0, 0, 2, 0, 3, 4, -5, 10 };
            var subset2 = from i in numbers where i > 0 && i % 2 == 0 select i;
            subset2.ToArray();
            Console.WriteLine("Positive  even numbers : ({0})", string.Join(",", subset2));
            var subset3 = (from i in numbers
                           where i % 2 == 0
                           orderby i
                           select i/2
                           ).ToArray();
            Console.WriteLine("Positive  even numbers : ({0})", string.Join(",", subset2));
            string[] colors = new string[] { "Lightred", "deep red", "dick red", "yellow", "lime", "crimson" };
            var subset4 = (from s in colors
                           where s.ToLower().Contains("red")
                           select s.ToUpper()
                           ).ToArray();
            Console.WriteLine("({0})", string.Join(",", subset4));
            var subset5 = colors.Where(s => s.ToLower().Contains("red"));


            ArrayList students = new ArrayList();
            students.Add(new Student(Guid.NewGuid(), "Alan", 16));
            students.Add(new Student(Guid.NewGuid(), "Bitch", 15));
            students.Add("bitch");
            var set = from s in  students.OfType<Student>()
                      select s;
            foreach(Student s in set)
                Console.WriteLine(s);
            var nameSet = from s in students.OfType<Student>()
                          select s.Name;
            foreach(string s in nameSet)
                Console.WriteLine(s);
            var orderedSet = from s in students.OfType<Student>()
                             orderby s.Age ascending
                             select s;
            Console.WriteLine(string.Join<Student>("\n", orderedSet.ToArray()));
            students.Add(new Student(Guid.NewGuid(), "Bitch", 14));
            orderedSet = students.OfType<Student>().
                         OrderBy(s => s.Name).
                         ThenByDescending(s => s.Age);
            var d  = orderedSet.ToArray();
            Console.WriteLine("===========================");
            Console.WriteLine("{0}",string.Join<Student>("\n",d));











            Console.ReadKey();
        }
    }
}
