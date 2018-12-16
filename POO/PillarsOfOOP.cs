using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    /*
     * Tipul class este  un tip de date definit de catre utilizator si este 
     * tipul de baza in C#,el fiind orientat pe obiecte.
     * O clasa  este un tip de date care contine  variabile care se numesc
     * campuri,si  functii(aici numite metode) care opereaza cu acestea
     * O "variabila" de  un tip care este clasa se numeste obiect, sau 
     * o instanta a clasei respective(Clasa Pisica ==> Garfield este o instanta
     * a clasei pisica) 
     * Clasa se afla la baza programarii orientate pe obiecte.
     * Pillars of OOP:
     *  Encapsulation(Incapsularea) - se refera la   felul cum datele 
     *  sunt protejate prin modificatoarele de acces si nu numai.
     *  Inheritance(Mostenire) - clasele pot mosteni   campuri si metode de la o alta
     *  clasa.
     *  Polymorphism(Polimorfism) - O clasa poate implementa  altcumva o functie 
     *  mostenita , dupa nevoie.
     * 
     * 
     * 
     * */
     /*
      * public -  membrul poate fi accesat de oricine(incepe cu litera mare)
      * private - membrul poate fi accesat doar de metodele  din clasa
      * (incepe cu litera mica) 
      * */
     class Car
    {
        public string Name;
        int price; //Implicit, campurile si metodele au modificatorul "private"
         private int age;
        public void SetAge(int val)
        {
            age = val;
        }
        public  int GiveAge()
        {
            return age;
        }
            

    }
    class PillarsOfOOP
    {
        static void Main(string[] args)
        {
            //Pas 1, se declara referinta catre o entitate de tipul "Car"
           
            Car c;
            //Pas 2.Instantierea  obiectului c de tipul Car
            c=new Car();
            c.Name = "Bubu";
            Console.WriteLine("Am o masina,o numesc '{0}'", c.Name);
            //c.price = 30; <-- Eroare! price este privat!NU!

            //Asa da! 
            c.SetAge(20);
            Console.WriteLine("Este o masina de {0} de ani.",c.GiveAge());


            Console.ReadKey();
            //Campurile sunt private, iar functiile  publice.
        }
    }
}
