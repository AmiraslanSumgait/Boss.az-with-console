using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace boss.az
{
     class Helper
    {
        public static CV CvObject(int categoryId)
        {
            Console.Clear();
            Database db = new Database();
        Cvdisplay:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Your name: ");
            string name = Console.ReadLine();
            Console.Write("Your job: ");
            string workName = Console.ReadLine();
            Console.Write("Your age: ");
        Age1:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--Age must be more than 18--");
            Console.Write("Enter your Age: ");
            string age = Console.ReadLine();
            if (db.IsValidAge(age)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect age try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto Age1;
            }
            Console.Write("Your city: ");
            string city = Console.ReadLine();
            Console.Write("Your Skills: ");
            string skills = Console.ReadLine();
            Console.Write("Your Experience: ");
            string experience = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("You succefully added Cv");
            CV cv = new CV(categoryId, workName, name, int.Parse(age), city, DateTime.Now, DateTime.Now.AddDays(30), skills, experience);
            Thread.Sleep(1500); Console.ForegroundColor = ConsoleColor.White;
            return cv;
            
        }
    }
}
