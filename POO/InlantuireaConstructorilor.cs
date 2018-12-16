using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class InlantuireaConstructorilor
    {
        //Cu ajutorul  lui"this", se pot inlantui constructori
        //astfel, se ia constructorul cu cele mai multe parametrii
        //si asta este apelat inainte oricarui alt 

        class Persoana
        {
            string nume;
            int varsta;
            public string GetNume() { return nume; }
            public int GetVarsta() { return varsta; }
            public void Prezint()
            {
                Console.WriteLine("Ma numesc {0} si am {1} ani", nume, varsta);
            }
            public Persoana() { }
            public Persoana(string nume, int varsta)
            {
                this.nume = nume;
                this.varsta = varsta;
            }
            public Persoana(string nume)
                :this(nume,0)
            {

            }
            public Persoana(int varsta)
                :this("",varsta)
            {

            }
            
         
        }
        static void Main()
        {
            return;
        }
    }
}
