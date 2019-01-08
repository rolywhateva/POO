using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{   //Interfata =  entitate ce defineste  metode abstracte
    //O clasa poate mosteni mai multe interfete.
    interface IPainter
     {
        void Paint();
        void BeginNewPaiting();
     }
    interface IWallPainter
    {
        void Paint();
        void BeginNewPaiting();
    }
     class  wallartist : artist,IPainter,IWallPainter
    {
         public string Color { get; set; }
        //cand se precizeaza interfata explicit, functia se defineste
        //fara public si alte cele.
          void IPainter.Paint()
        {
            Console.WriteLine($"{Name} is painting   the wall with his new project");

        }
        void IWallPainter.Paint()
        {
            Console.WriteLine($"{Name} is painting the wall");
        }
        void IPainter.BeginNewPaiting()
        {
            Console.WriteLine($"{Name} is starting a new   painting!");

        }
        void IWallPainter.BeginNewPaiting()
        {
            Console.WriteLine($"{Name} is banging down the wall");
        }
        public wallartist(string name="",int income=0)
            :base(name,income)
        {
          
        }
    }
    interface IDesigner
    {
        void Draw();
        void BeginNewProject();
    }
    abstract class artist
    {
        public string Name { get; set; }
        public int Income { get; set; }
        public artist(string name="",int income=0)
        {
            Name = name;
            Income = Income;
        }
    }
    class painter:artist,IPainter
    {
       private int PictureCount { get; set; }
       private string CurrentPicture { get; set; }
        public painter(int count, string picture,string name="",int income=0)
             :base(name,income)
        {
            PictureCount = count;
            CurrentPicture = picture;
        }
        public void Paint()
        {
            Console.WriteLine($"{Name} is paiting '{CurrentPicture}'");
        }
        public void BeginNewPaiting()
        {
            Console.WriteLine($"{Name} is thinking of an  new picture");
            PictureCount++;
        }
    }
    class designer:artist,IDesigner
    {
        private int ProjectCount { get; set; }
        private string CurrentProject { get; set; }
        public designer(string project, int count, string name = "", int income = 0)
           : base(name, income)
        {
            ProjectCount = count;
            CurrentProject = project;
        }
        public void Draw()
        {
            Console.WriteLine($"{Name} is drawing  the '{CurrentProject}'");

        }
        public void BeginNewProject()
        {
            Console.WriteLine($"{Name} is thinking of a new project, maybe he'll design a 30 inch dick...");
        }

    }

    class Interfete
    {
        static void CallPainter(IPainter painter)
        {
            painter.Paint();
        }
        static void Main()
        {
            painter Jordan = new painter(3, "The naughty willy", "Jordan", 300);
            designer Park = new designer("The pointy vagina", 4, "Park", 300);

            if (Park is IPainter)
                Console.WriteLine($"{Park.Name} is a designer");
            else
                Console.WriteLine($"{Park.Name} is not a designer");


            IPainter ip = Park as IPainter;
            if (ip == null)
                Console.WriteLine("Error : Park is not a painter");

            CallPainter(Jordan);
            object[] artists = new object[] { Jordan, Park};
            foreach(object var in artists)
                 if(var is IPainter)
                    Console.WriteLine($"{(var as painter).Name} is a painter" );
                 else
                    if(var is IDesigner)
                    Console.WriteLine($"{(var as designer).Name} is a designer");
            wallartist Allie = new wallartist("Allie", 200);
            (Allie as IWallPainter).BeginNewPaiting();
            (Allie as IWallPainter).Paint();


            Console.ReadKey();
            return;
        }
    }
}
