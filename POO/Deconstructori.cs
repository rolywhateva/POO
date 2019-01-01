using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    /*
     * Deconstructor = o functie care returneaza  valorile  properietatilor prin 
     * parametrii de iesire
     * */
    class Employee
    {
        private string name;
        private int age;
        public static int nr;
        public static List<Employee> EmployeeList;

        static Employee()
        {
            EmployeeList = new List<Employee>();
            nr = 0;
        }
        public Employee(string name = "", int age = 16)
        {
            this.name = name;
            this.age = age;
            EmployeeList.Add(this);
            nr++;
        }
    public void  Deconstruct(out string name, out int age)
    {
        name = this.name;
        age = this.age;
    }
        public string GetName()
        {
            return name;
        }
    }
    class Deconstructori
    {
       

        static void Main()
        {
        Employee Jack = new Employee("Jack", 41);
        /**
         * 
         * Jack.Deconstruct(out nume, out varsta);
         * */
        var (nume, varsta) = Jack;
        Console.WriteLine($"{nume} lucreaza la noi si are varsta de {varsta}");
        Employee Sarah = new Employee("Sarah", 23);
        string numeSarah;
        int  varstaSarah;
        (numeSarah, varstaSarah) = Sarah;
        Console.WriteLine($"{numeSarah} lucreaza la noi si are varsta de {varstaSarah}");

        Console.ReadKey();
        }
    }

