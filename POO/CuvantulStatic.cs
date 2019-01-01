using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Cuvantul  static poate fi atribuita unui camp, clase, sau unei metode sau unui constructor.
 *  O clasa statica nu poate fi instantiata.(ex.  clasa Math) 
 * Un camp( o metoda) static(a) inseamna ca acel camp(acea metoda) este  comun tuturor obiectelor.
 * 
 * 
 * */
namespace POO
{
    class Employee
    {
        private string name;
        private int age;
        public static  int nr;
       public  static List<Employee> EmployeeList;
        static Employee()
        {
            EmployeeList = new List<Employee>();
            nr = 0;
        }
       public  Employee(string name="", int age=16)
        {
            this.name = name;
            this.age = age;
            EmployeeList.Add(this);
            nr++;
        }
        public string  GetName()
        {
            return name;
        }

    }
    class CuvantulStatic
    {
        static void Main()
        {
            Employee Richard = new Employee("Richard", 32);
            Employee Joe = new Employee("Joe");
            Employee Tommy = new Employee("Tommy", 56);
            //accesare de la nivelul clasei 
            Console.WriteLine("Numar de angajati:"+Employee.nr);
            foreach(Employee e in Employee.EmployeeList)
                Console.WriteLine(e.GetName());
             



            Console.ReadKey();
        }




    }
}
