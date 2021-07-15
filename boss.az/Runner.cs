using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace boss.az
{
    class Runner
    {
        public static void Run()
        {
            Worker w1 = new Worker("Nebi Nebili", "Nebi18", 18, "nnabili035@gmail.com", "Azerbaycan123");
           
            Worker w2 = new Worker("Kamal Eliyev", "KamalQazax", 15, "kamaleliyev7@gmail.com", "Salam qaqa");
            Category category1 = new Category("Software developer", 1);
            Category category2 = new Category("Web/Graphic design", 2);
            Announcement announcement1 = new Announcement("React developer", "Sumgait", "18-25", new DateTime(2020, 09, 21), new DateTime(2020, 10, 21), 800, "1 to 3 years", "Amiraslan", "emiraslaneliyev45@gmail.com", "+994557134655");
            Announcement announcement2 = new Announcement("Php developer", "New york", "20-40", new DateTime(2021, 02, 10), new DateTime(2020, 03, 10), 1300, "More than 1 year", "Kenan", "Kenan23@gmail.com", "+994558557498");
            Announcement announcement3 = new Announcement("UI/UX Designer", "Ganja", "25-40", new DateTime(2019, 03, 5), new DateTime(2019, 04, 10), 800, "More than 3 year", "Nebi", "nnabili@gmail.com", "+994557135755");
            Announcement announcement4 = new Announcement("Graphic Designer", "Istanbul", "20-30", new DateTime(2021, 10, 21, 23, 30, 40), new DateTime(2020, 11, 21), 800, "More than 2 year", "Burak", "burakaktas@gmail.com", "+9043239430");
            CV cv1 = new CV(1, "Node.js + Java Senior backend engineer", "Nebi", 18, "Sumgait",  new DateTime(2021, 10, 21, 23, 30, 00), new DateTime(2021, 11, 21, 23, 30, 00), "Java,Node.js", "More than 2 year");
            CV cv2 = new CV(1, "Node.js + Java Senior backend engineer", "Nebi", 18, "Sumgait",  new DateTime(2021, 10, 21, 23, 30, 00), new DateTime(2021, 11, 21, 23, 30, 00), "Java,Node.js", "More than 2 year");
            w1.AddCv(cv1);
            w1.AddCv(cv2);
            Employee emp1 = new Employee("Kenan Idayatov", "Akula", 18, "kenannidayatov@gmail.com", "Progress32");
            Employee emp2 = new Employee("Hormet Hemidov", "idayatov.k", 19, "hhormethemidov@gmail.com", "29092001");
            emp1.AddAnnoucment(announcement1);
            emp1.AddAnnoucment(announcement2);
            emp1.AddAnnoucment(announcement3);
            emp1.AddAnnoucment(announcement4);
            Database db = new Database
            {
                Workers = new List<Worker> { w1, w2 },
                Employees = new List<Employee> { emp1, emp2 },
                Categories = new List<Category> { category1, category2 }
            };
        FirstPart:
            int choise1 = ConsoleHelper.MultipleChoice(44, 9, true, "Worker", "Employee");
            if (choise1 == 0)
            {
            SecondPart:
                int choise2 = ConsoleHelper.MultipleChoice(44, 9, true, "Sign up", "Sign in", "Back");
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
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Incorrect email try again!!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto Email;
                        }

                    Password:
                        Console.ForegroundColor = ConsoleColor.Cyan;
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
                    Console.Clear();
                    int check = 0;
                email:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    db.ClearCurrentConsoleLine();
                    Console.Write("Enter your email:");
                    string email = Console.ReadLine();
                    foreach (var worker in db.Workers)
                    {
                        if (worker.Email == email)
                        {
                            while (true)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("Enter your password:");
                                string password = Console.ReadLine();
                                if (password == worker.Password)
                                {
                                    ++check;
                                workeroptions:
                                    int choise4 = ConsoleHelper.MultipleChoice(50, 9, true, "Add Cv", "Delete Cv", "Update Cv", "Show your Cvs", "Find work","Back");
                                    if (choise4 == 0)
                                    {
                                        int categoryId;
                                        int choise5 = ConsoleHelper.MultipleChoice(50, 9, true, "Software developer", "Web/Graphic design");
                                        if (choise5 == 0)
                                        {
                                            Console.Clear();
                                            foreach (var category in db.Categories)
                                            {
                                                if (category.Name == "Software developer")
                                                {
                                                    categoryId = category.Id;
                                                    break;
                                                }
                                            }
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
                                            Thread.Sleep(1500); Console.ForegroundColor = ConsoleColor.White;
                                            goto workeroptions;

                                        }
                                        if (choise5 == 1)
                                        {
                                            Console.Clear();
                                            foreach (var category in db.Categories)
                                            {
                                                if (category.Name == "Web/Graphic design")
                                                {
                                                    categoryId = category.Id;
                                                    break;      
                                                }
                                            }
                                        }
                                    }
                                    if (choise4 == 1)
                                    {
                                        Console.Clear();
                                        worker.PrintCvs();
                                    deletecv:
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.Write("Which cv you want delete(with id): ");
                                        string id;
                                        int check1 = 0;
                                        if (db.isNumber( id=Console.ReadLine()))
                                        {
                                            foreach (var cv in worker.Cvs)
                                            {
                                                if (cv.ThisId.ToString() == id)
                                                {
                                                    ++check1;
                                                    break;
                                                }                                                
                                            }
                                            if (check1 == 0)
                                            {                                             
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("You haven't cv this id"); Console.ForegroundColor = ConsoleColor.White;
                                                    goto deletecv;                                              
                                            }
                                            var item = worker.Cvs.Single(x => x.ThisId ==int.Parse(id));
                                            worker.Cvs.Remove(item);
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("Your cv deleted succesfully"); Console.ForegroundColor = ConsoleColor.White;
                                            Thread.Sleep(1500);
                                            goto workeroptions;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Incorrect Id"); Console.ForegroundColor = ConsoleColor.White;
                                            goto deletecv;
                                        }
                                    }
                                    if (choise4 == 2)
                                    {
                                        Console.Clear();
                                        worker.PrintCvs();
                                        Console.WriteLine("Which cv you want update (with id)");
                                        string id = Console.ReadLine();
                                       
                                    }
                                    if (choise4 == 3)
                                    {
                                        Console.Clear();
                                        worker.PrintCvs();
                                        if (worker.IsListEmpty(worker.Cvs)) {
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("Your  cv list empty"); Console.ForegroundColor = ConsoleColor.White;
                                        }                                       
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.Write("If you want back press any key->");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.ReadLine();
                                        goto workeroptions;
                                    }
                                    if (choise4 == 4)
                                    {
                                        //FInd work**********
                                    }
                                    if (choise4 == 5)
                                    {
                                        goto SecondPart;
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("Incorrect password try again!!\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    int choise3 = ConsoleHelper.MultipleChoice(50, 5, false, "Continue", "Back");
                                    if (choise3 == 1) { goto SecondPart; }
                                    if (choise3 == 0) { db.ClearCurrentConsoleLine(); db.ClearLastLine(); Console.WriteLine(); continue; }
                                }
                            }
                        }
                    }
                    if (check == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Incorrect email try again!!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        int choise3 = ConsoleHelper.MultipleChoice(50, 9, false, "Continue", "Back");
                        if (choise3 == 1) { goto SecondPart; }
                        if (choise3 == 0) { Console.Clear(); goto email; }

                    }
                  

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
