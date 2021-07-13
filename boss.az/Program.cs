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

            Worker w1 = new Worker("Nebi Nebili", "Nebi18", 18,  "nnabili035@gmail.com", "Azerbaycan123");
            Worker w2 = new Worker("Kamal Eliyev", "KamalQazax", 15,  "kamaleliyev7@gmail.com", "Salam qaqa");
            Category category1 = new Category("Software developer", 1);
            Category category2 = new Category("Web/Graphic design", 2);
            Announcement announcement1 = new Announcement("React developer", "Sumgait", "18-25", new DateTime(2020, 09, 21), new DateTime(2020, 10, 21), 800, "1 to 3 years", "Amiraslan", "emiraslaneliyev45@gmail.com", "+994557134655");
            Announcement announcement2 = new Announcement("Php developer", "New york", "20-40", new DateTime(2021, 02, 10), new DateTime(2020, 03, 10), 1300, "More than 1 year", "Kenan", "Kenan23@gmail.com", "+994558557498");
            Announcement announcement3 = new Announcement("UI/UX Designer", "Ganja", "25-40", new DateTime(2019, 03, 5), new DateTime(2019, 04, 10), 800, "More than 3 year", "Nebi", "nnabili@gmail.com", "+994557135755");
            Announcement announcement4 = new Announcement("Graphic Designer", "Istanbul", "20-30", new DateTime(2021, 10, 21, 23, 30, 40), new DateTime(2020, 11, 21), 800, "More than 2 year", "Burak", "burakaktas@gmail.com", "+9043239430");
            Employee emp1 = new Employee("Kenan Idayatov", "Akula", 18,  "kenannidayatov@gmail.com", "Progress32");
            Employee emp2 = new Employee("Hormet Hemidov", "idayatov.k", 19,  "hhormethemidov@gmail.com", "29092001");
            emp1.AddAnnoucment(announcement1);
            emp1.AddAnnoucment(announcement2);
            emp1.AddAnnoucment(announcement3);
            emp1.AddAnnoucment(announcement4);         
            Database db = new Database
            {
                Workers = new List<Worker> { w1, w2 },
                Employees = new List<Employee> { emp1, emp2 }
            };
        FirstPart:
            int choise1 = ConsoleHelper.MultipleChoice(44, 9, "Worker", "Employee");
            if (choise1 == 0)
            {
                SecondPart:
                int choise2 = ConsoleHelper.MultipleChoice(44, 9, "Sign up", "Sign in", "Exit");
                if (choise2 == 0)
                {                   
                    while (true)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Enter your Fullname: ");
                        string fullName = Console.ReadLine();
                        Console.Write("Enter your Username: ");
                        string userName = Console.ReadLine();
                        Age:
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
                            goto Age;
                        }
                    Email:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Enter your email: ");
                        string email = Console.ReadLine();
                        if (db.IsValidEmail(email)) { }
                        else {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Incorrect email try again!!\n");                           
                            Console.ForegroundColor = ConsoleColor.White;                           
                            goto Email; 
                        }

                        Password:
                        Console.WriteLine("--Warning!!Password length min 8 max 15.Password must be 1 uppercase letter, 1 lower case lettter and 1 decimal digt---");
                        Console.Write("Enter your password: ");
                        string password = Console.ReadLine();
                        if (db.ValidatePassword(password)) { }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Incorrect password try again!!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto Password;
                        }
                        Worker worker = new Worker(fullName, userName, int.Parse(age), email, password);
                        db.Workers.Add(worker);
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("---You succesfully signed up---"); Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(1500);
                        goto SecondPart;
                    }

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
