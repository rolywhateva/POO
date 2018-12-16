using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    /**
     * Constructorii sunt metode speciale care sunt apelate cand 
     * un obiect este instantiat.Rolul lor este de a initializa campurile
     * 
     * 
     * 
     * */
     class Persoana
    {
        string nume;
        int varsta;
        public string GetNume() { return nume; }
        public int GetVarsta() { return varsta; }
        public void Prezint()
        {
            Console.WriteLine("Ma numesc {0} si am {1} ani",nume,varsta);
        }
        //asa se defineste un constructor - nu are tip retunat! 
        public Persoana(string nume,int varsta)
        {
            //operatorul this arata explicit
            // ca this.nume se refera la campul "nume"
            //iar nume se refera la  parametrul  "nume"
            this.nume = nume;

            this.varsta = varsta;
        }
        //Daca se defineste un  alt constructor si este
        // inca nevoie de cel implicit, acesta trebuie
        //rescris.
        public Persoana() { }


    }
    class Constructori
    {
        static void Main()
        {
            Persoana p = new Persoana();//Persoana() este practic constructorul
            //Implicit, este apelat un constructor
            //implicit care intializeaza fiecare membru de tip valoare
            // cu  valorea sa  implicita, si pe membrii de tip referinta
            //cu null.
            if (p.GetNume() == null)
                Console.WriteLine("null");
            Console.WriteLine(p.GetVarsta());
            p = new Persoana("Gabriel", 18);
            p.Prezint();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
