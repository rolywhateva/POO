using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{   //Defineste  o metoda care specifica felul cum doua obiecte de o anumita clasa 
    //sunt comparate 
    class person :IComparable
    {
        public string Name { get; set; }
        public  int Age { get; set; }
        public static IComparer CompareByName
        {
            get { return new PersonNameComparer(); }
        }
        public person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        // fara modificator de acces
      int IComparable.CompareTo(object obj)
        {
            person temp = obj as person;
            if (temp != null)
            {
                if (this.Age > temp.Age)
                    return 1;
                else
                     if (this.Age < temp.Age)
                    return -1;
                else return 0;
            }
            else
                throw new ArgumentException("Object not a  person");

        }
        

    }
    //Cand vreau sa pot   sorta in mai multe moduri == > IComparer
    class PersonNameComparer : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            person person1 = x as person;
            person person2 = y as person;
            if (person1 != null && person2 != null)
                return string.Compare(person1.Name, person2.Name);
            else
                throw new ArgumentException("no  people");
        }
    }
    class InterfataIComparable
    {

        static void Main()
        {
            person[] personArray = new person[]
                {
                 new person("Jake",27),
                 new person("Anna",16),
                 new person("Paul",8),
                 new person("Andra",67),
                 new person("Junko",19)
                };
            Array.Sort(personArray);
            foreach(person p in personArray)
            {
                Console.WriteLine("{0} -{1}",p.Name,p.Age);
            }
            Array.Sort(personArray, person.CompareByName);
            Console.WriteLine();
            Console.WriteLine();
            foreach (person p in personArray)
            {
                Console.WriteLine("{0} -{1}", p.Name, p.Age);
            }
            Console.ReadKey();


            return;
        }
    }
}
