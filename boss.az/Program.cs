using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;

namespace boss.az
{

    class Program
    {

        static void Main(string[] args)
        {
            Worker w1 = new Worker("Nebi", "Nebili", 18, "Male", "nnabili035@gmail.com", "Azerbaycan123");
            Worker w2 = new Worker("Kamal", "Eliyev", 15, "Male", "kamaleliyev7@gmail.com", "Salam qaqa");
            Category category1 = new Category("Software developer", 1);
            Category category2 = new Category("Web/Graphic design", 2);
            Announcement announcement1 = new Announcement("React developer","Sumgait", "18-25", new DateTime(2020, 09, 21), new DateTime(2020, 10, 21), 800, "1 to 3 years", "Amiraslan", "emiraslaneliyev45@gmail.com", "+994557134655");
            Announcement announcement2 = new Announcement("Php developer","New york","20-40", new DateTime(2021, 02, 10), new DateTime(2020, 03, 10), 1300, "More than 1 year", "Kenan", "Kenan23@gmail.com", "+994558557498");
            Announcement announcement3 = new Announcement("UI/UX Designer", "Ganja", "25-40", new DateTime(2019, 03, 5), new DateTime(2019, 04, 10), 800, "More than 3 year", "Nebi", "nnabili@gmail.com", "+994557135755");
            Announcement announcement4 = new Announcement("Graphic Designer", "Istanbul", "20-30", new DateTime(2021, 10, 21, 23, 30, 40), new DateTime(2020, 11, 21), 800, "More than 2 year", "Burak", "burakaktas@gmail.com", "+9043239430");
            Employee emp1 = new Employee("Kenan", "Idayat", 18, "Male", "kenannidayatov@gmail.com", "Progress32");
            Employee emp2 = new Employee("Hormet", "Hemidov", 19, "Male", "hhormethemidov@gmail.com", "29092001");
            emp1.AddAnnoucment(announcement1);
            emp1.AddAnnoucment(announcement2);
            emp1.AddAnnoucment(announcement3);
            emp1.AddAnnoucment(announcement4);
            emp1.PrintAnnoucments();
            //Thread.Sleep(10000);
            Database db = new Database
            {
                Workers = new List<Worker> { w1, w2 },
                Employees = new List<Employee> { emp1, emp2 }
            };
            foreach (var item in db.Workers)
            {
                Console.WriteLine(item);
                //Thread.Sleep(5000);
            }
        FirstPart:
            int choise1 = ConsoleHelper.MultipleChoice(44,9,"Worker", "Employee");
            if (choise1 == 0)
            {
                int choise2 = ConsoleHelper.MultipleChoice(44,9,"Sign up", "Sign in", "Exit");
                if (choise2 == 0)
                {
                    
                }
                else if (choise2 == 1)
                {

                }
                else if (choise2 == 2)
                {
                    goto FirstPart;
                }
            }
            else if (choise1 == 1)
            {

            }
        }
    }
}
