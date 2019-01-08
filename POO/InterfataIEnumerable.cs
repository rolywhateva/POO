using System;
using System.Collections.Generic;
using System.Collections; // <-- Necesar! 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class painting 
    {
        public string Title { get; set; }
        public string Painter { get; set; }
        public int Price { get; set; }
        public painting( int CPrice = 0,string CTitle="Mona Liza",string CPainter="Picaso")
        {
            Title = CTitle;
            Painter = CPainter;
            Price = CPrice;
        }



    }
    class Museum : IEnumerable
    {
        public string Name { get; set; }
        public painting[] Stock
        {
            get; set;
        }
        public Museum(painting[] CStock, string CName = "Louvre")
        {
            Stock = new painting[CStock.Length];
            Array.Copy(CStock, Stock, CStock.Length);
            Name = CName;
        }
        
        public IEnumerator GetEnumerator()
        {
            return Stock.GetEnumerator();
        }
        //iterator
        public IEnumerable GetPictureBetween(int MinPrice=0,int MaxPrice=0)
        {
            foreach (painting picture in Stock)
                  if(MinPrice<=picture.Price&&picture.Price<=MaxPrice)
                yield return picture;
        }
    }

    class InterfataIEnumerable
    {
        static void Main()
        {
            Museum Louvre = new Museum(
                                       new painting[] {
                                                       new painting(200),
                                                       new painting(300,"Chateau bitch"),
                                                       new painting(400,"Mongoose","Pierre"),
                                                       new painting(500,"Tom","Tom")
                                                      }
                                       ,"Louvre");
            foreach(painting picture in Louvre)
            {
                Console.WriteLine(picture.Title);
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach(painting picture in Louvre.GetPictureBetween(100,300))
                Console.WriteLine(picture.Title);
      
            Console.ReadKey();
            return;
        }
    }
}
