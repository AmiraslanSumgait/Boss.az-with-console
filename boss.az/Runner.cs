using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
//using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace boss.az
{
    class Runner
    {

        public static void Run()
        {
            Checker checker = new Checker();
            Worker w1 = new Worker("Nebi Nebili", "Nebi18", 18, "nnabili035@gmail.com", "Azerbaycan123");
            Worker w2 = new Worker("Kamal Eliyev", "KamalQazax", 15, "kamaleliyev7@gmail.com", "Salam qaqa");
           // Category category1 = new Category("Software developer", 1);
            //Category category2 = new Category("Web/Graphic design", 2);
           // Category category3 = new Category("IT / Telecommunications", 3);
           // Category category4 = new Category("Economy", 4);
           // Category category5 = new Category("Marketing / Media / PR", 5);
           // Category category6 = new Category("Human Resources / Staff Management ", 6);
            Announcement announcement1 = new Announcement(1, "React developer", "Sumgait", "18-25", new DateTime(2020, 09, 21), new DateTime(2020, 10, 21), 900, "1 to 3 years", "Amiraslan", "emiraslaneliyev45@gmail.com", "994557134655");
            Announcement announcement2 = new Announcement(1, "Php developer", "Baku", "20-40", new DateTime(2021, 02, 10), new DateTime(2020, 03, 10), 1500, "More than 1 year", "Kenan", "Kenan23@gmail.com", "994558557498");
            Announcement announcement3 = new Announcement(2, "UI/UX Designer", "Ganja", "25-40", new DateTime(2019, 03, 5), new DateTime(2019, 04, 10), 2100, "More than 3 year", "Nebi", "nnabili@gmail.com", "994557135755");
            Announcement announcement4 = new Announcement(2, "Graphic Designer", "Qabala", "20-30", new DateTime(2021, 10, 21, 23, 30, 40), new DateTime(2020, 11, 21), 3100, "More than 2 year", "Burak", "burakaktas@gmail.com", "9043239430");
            Announcement announcement5 = new Announcement(5, "Administrative assistant", "Ganja", "20-30", new DateTime(2021, 10, 21, 23, 30, 40), new DateTime(2020, 11, 21), 3500, "More than 2 year", "Burak", "burakaktas@gmail.com", "9043239430");
            Database.FilitrAnnoucments.Add(announcement5);
            Database.FilitrAnnoucments.Add(announcement4);
            Database.FilitrAnnoucments.Add(announcement3);
            Database.FilitrAnnoucments.Add(announcement2);
            Database.FilitrAnnoucments.Add(announcement1);
            CV cv1 = new CV(1, "Node.js + Java Senior backend engineer", "Nebi", 45, "Sumgait", new DateTime(2021, 10, 21, 23, 30, 00), new DateTime(2021, 11, 21, 23, 30, 00), "Java,Node.js", "More than 2 year");
            CV cv2 = new CV(2, "Product designer", "Akif", 20, "Ganja", new DateTime(2021, 8, 22, 22, 00, 10), new DateTime(2021, 9, 22, 23, 30, 00), "A high degree of technical knowledge balanced with creative ability and a hands-on approach.", "More than 1 year");
            CV cv3 = new CV(3, "Digital & Web Coordinator", "Kamal", 24, "Baku", new DateTime(2021, 12, 19, 19, 00, 00), new DateTime(2022, 01, 21, 23, 30, 00), "Able to deliver quality results under time constraints in a fast-paced environment.", "Minimum 2 year");
            CV cv4 = new CV(4, "Junior Relationship Manager", "Samir", 51, "Lankaran", new DateTime(2021, 10, 21, 23, 30, 00), new DateTime(2021, 11, 21, 23, 30, 00), "Able to work with key stakeholders to a high level", "Minimum 1.5 year");
            CV cv5 = new CV(5, "English Copywriter UX/UI", "Samir", 32, "Shaki", new DateTime(2021, 10, 21, 23, 30, 00), new DateTime(2021, 11, 21, 23, 30, 00), "Creating, writing and reviewing varied content in English for Swissquotes web interfaces, particularly its applications.", "Minimum 1.5 year");
            CV cv6 = new CV(6, "HR Intern", "Kamal", 29, "Quba", new DateTime(2021, 10, 21, 23, 30, 00), new DateTime(2021, 11, 21, 23, 30, 00), "*Support the employee lifecycle through administrative tasks (contracts, addendums,…)\n*Prepare the onboarding of new joiners", "Minimum 1.5 year");
            Database.FilitrCvs.Add(cv1);
            Database.FilitrCvs.Add(cv2);
            Database.FilitrCvs.Add(cv3);
            Database.FilitrCvs.Add(cv4);
            Database.FilitrCvs.Add(cv5);
            Database.FilitrCvs.Add(cv6);
            w1.AddCv(cv1);
            //w1.AddCv(cv2);
            //w1.AddCv(cv3);
            //w2.AddCv(cv4);
            //w2.AddCv(cv5);
            w2.AddCv(cv6);
            Employee emp1 = new Employee("Kenan Idayatov", "Akula", 18, "kenannidayatov@gmail.com", "Progress32");
            Employee emp2 = new Employee("Hormet Hemidov", "idayatov.k", 19, "hhormethemidov@gmail.com", "29092001");
            emp1.AddAnnoucment(announcement1);
            emp1.AddAnnoucment(announcement2);
            emp1.AddAnnoucment(announcement3);
            emp1.AddAnnoucment(announcement4);
            emp2.AddAnnoucment(announcement5);
            Database db = new Database();
            //Database db = new Database
            //{
            //    //Workers = new List<Worker> { w1, w2 },
            //    //Employees = new List<Employee> { emp1, emp2 },
            //    //Categories = new List<Category> { category1, category2, category3, category4, category5, category6 }
            //};
            db.Workers = new List<Worker>();
            db.Employees = new List<Employee>();
            db.Categories = new List<Category>();
            var workersText = File.ReadAllText("Workers.json");
            db.Workers = JsonConvert.DeserializeObject<List<Worker>>(workersText);
            var categoriesText = File.ReadAllText("Categories.json");
            db.Categories = JsonConvert.DeserializeObject<List<Category>> (categoriesText);
            var employeesText = File.ReadAllText("Employees.json");
            db.Employees = JsonConvert.DeserializeObject<List<Employee>>(employeesText);
            // JsonFormat.WriteToJsonFile(db.Workers, "Workers.json");
            // JsonFormat.WriteToJsonFile(db.Employees, "Employees.json");
             // JsonFormat.WriteToJsonFile(db.Categories, "Categories.json");
        FirstPart:
            int choise1 = ConsoleHelper.MultipleChoice(44, 9, true, 1, "Worker", "Employee");
            if (choise1 == 0)
            {
            SecondPart:
                int choise2 = ConsoleHelper.MultipleChoice(44, 9, true, 2, "Sign up", "Sign in", "<-Back");
                if (choise2 == 0)
                {
                    while (true)
                    {
                        Console.Clear();
                    fullName:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Enter your Fullname: ");
                        string fullName = Console.ReadLine();
                        if (checker.isString(fullName)) { }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Incorrect fullname try again!!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto fullName;
                        }
                    username:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Enter your Username: ");
                        string userName = Console.ReadLine();
                        if (checker.isString(userName)) { }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Incorrect username try again!!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto username;
                        }
                    Age:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("--Age must be more than 18--");
                        Console.Write("Enter your Age: ");
                        string age = Console.ReadLine();
                        if (checker.IsValidAge(age)) { }
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
                        if (checker.IsValidEmail(email)) { }
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
                        if (checker.ValidatePassword(password)) { }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Incorrect password try again!!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto Password;
                        }
                        Worker worker = new Worker(fullName, userName, int.Parse(age), email, password);
                        db.Workers.Add(worker);
                        JsonFormat.WriteToJsonFile(db.Workers, "Workers.json");
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
                    checker.ClearCurrentConsoleLine();
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
                                    int choise4 = ConsoleHelper.MultipleChoice(50, 9, true, 1, "Add Cv", "Delete Cv", "Update Cv", "Show your Cvs", "Find work", "Notifications", "<-Back");
                                    if (choise4 == 0)
                                    {
                                        Console.Clear();
                                        Console.SetCursorPosition(38, 7);
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("-----------Category-----------");
                                        int choise5 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "Software developer", "Web/Graphic design", "IT / Telecommunications", "Ecenomy", "Marketing / Media / PR", "Human Resources / Staff Management", "<-Back");
                                        switch (choise5)
                                        {
                                            case 0:
                                                worker.AddCv(Helper.CvObject(1));
                                                goto workeroptions;
                                                break;
                                            case 1:
                                                worker.AddCv(Helper.CvObject(2));
                                                goto workeroptions;
                                                break;
                                            case 2:
                                                worker.AddCv(Helper.CvObject(3));
                                                goto workeroptions;
                                                break;
                                            case 3:
                                                worker.AddCv(Helper.CvObject(4));
                                                goto workeroptions;
                                                break;
                                            case 4:
                                                worker.AddCv(Helper.CvObject(5));
                                                goto workeroptions;
                                                break;
                                            case 5:
                                                worker.AddCv(Helper.CvObject(6));
                                                goto workeroptions;
                                                break;
                                            case 6:
                                                goto workeroptions;
                                        }
                                    }
                                    if (choise4 == 1)
                                    {
                                        Console.Clear();
                                        worker.PrintCvs();
                                    deletecv:
                                        if (worker.IsListEmpty(worker.Cvs))
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("Your  cv list empty"); Console.ForegroundColor = ConsoleColor.White;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("Press enter key to go back.."); Console.ForegroundColor = ConsoleColor.White;
                                            Console.ReadLine();
                                            goto workeroptions;
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.Write("Which cv you want delete(with id): ");
                                        string id;
                                        int check1 = 0;
                                        if (checker.isNumber(id = Console.ReadLine()))
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
                                            var item = worker.Cvs.SingleOrDefault(x => x.ThisId == int.Parse(id));
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
                                        int check2 = 0;
                                        Console.Clear();
                                        if (worker.Cvs.Count == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("Your  cv list empty"); Console.ForegroundColor = ConsoleColor.White;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("Press enter key to go back.."); Console.ForegroundColor = ConsoleColor.White;
                                            Console.ReadLine();
                                            goto workeroptions;
                                        }
                                        worker.PrintCvs();
                                    updatecv:
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.WriteLine("Which cv you want update (with id)");
                                        string id = Console.ReadLine();
                                        if (checker.isNumber(id))
                                        {
                                            foreach (var cv in worker.Cvs)
                                            {
                                                if (cv.ThisId.ToString() == id)
                                                {
                                                    ++check2;
                                                    break;
                                                }
                                            }
                                            if (check2 == 0)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("You haven't cv this id"); Console.ForegroundColor = ConsoleColor.White;
                                                goto updatecv;
                                            }
                                            var cvUpdate = worker.Cvs.SingleOrDefault(x => x.ThisId == int.Parse(id));
                                            Console.Clear();

                                        updateoptions:
                                            Console.Clear();
                                            Console.SetCursorPosition(38, 7);
                                            Console.WriteLine("Which parameter you want update: ");
                                            int choise8 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "Work Name", "Worker Name", "Age", "City", "Skills", "Experience", "<-Back");
                                            switch (choise8)
                                            {
                                                case 0:
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("New Work Name: "); Console.ForegroundColor = ConsoleColor.White;
                                                    string workName = Console.ReadLine();
                                                    if (checker.isString(workName)) { }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.WriteLine("Incorrect work name!!");
                                                        Thread.Sleep(1000);
                                                        goto case 0;
                                                    }
                                                    cvUpdate.WorkName = workName;
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("Your Work name updated sucesfully"); Console.ForegroundColor = ConsoleColor.White;
                                                    break;
                                                case 1:
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("New Worker Name: "); Console.ForegroundColor = ConsoleColor.White;
                                                    string workerName = Console.ReadLine();
                                                    if (checker.isString(workerName)) { }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.WriteLine("Incorrect worker name!!");
                                                        Thread.Sleep(1000);
                                                        goto case 1;
                                                    }
                                                    cvUpdate.Name = workerName;
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("Your Worker name updated sucesfully"); Console.ForegroundColor = ConsoleColor.White;
                                                    break;
                                                case 2:
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("---Age must be more than 18---");
                                                    Console.WriteLine("New Age: "); Console.ForegroundColor = ConsoleColor.White;
                                                    string age = Console.ReadLine();
                                                    if (checker.IsValidAge(age)) { }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.WriteLine("Incorrect Age!!");
                                                        Thread.Sleep(1000);
                                                        goto case 2;
                                                    }
                                                    cvUpdate.Age = int.Parse(age);
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("Your Age updated sucesfully"); Console.ForegroundColor = ConsoleColor.White;
                                                    break;
                                                case 3:
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("New City: "); Console.ForegroundColor = ConsoleColor.White;
                                                    string city = Console.ReadLine();
                                                    if (checker.isString(city)) { }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.WriteLine("Incorrect city name!!");
                                                        Thread.Sleep(1000);
                                                        goto case 3;
                                                    }
                                                    cvUpdate.City = city;
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("Your City updated sucesfully"); Console.ForegroundColor = ConsoleColor.White;
                                                    break;
                                                case 4:
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("New Skills: "); Console.ForegroundColor = ConsoleColor.White;
                                                    string skills = Console.ReadLine();
                                                    cvUpdate.Skills = skills;
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("Your Skills updated sucesfully"); Console.ForegroundColor = ConsoleColor.White;
                                                    break;
                                                case 5:
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("New experience: "); Console.ForegroundColor = ConsoleColor.White;
                                                    string experience = Console.ReadLine();
                                                    cvUpdate.Experience = experience;
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("Your Expierence updated sucesfully"); Console.ForegroundColor = ConsoleColor.White;
                                                    break;
                                                case 6:
                                                    goto workeroptions;
                                                    break;

                                            }
                                            Console.SetCursorPosition(38, 7);
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("Do you want continue or go back? ");
                                            int choise9 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "Continue", "Back");
                                            switch (choise9)
                                            {
                                                case 0:
                                                    goto updateoptions;
                                                    break;
                                                case 1:
                                                    goto workeroptions;
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Incorrect Id"); Console.ForegroundColor = ConsoleColor.White;
                                            goto updatecv;
                                        }
                                    }
                                    if (choise4 == 3)
                                    {
                                        Console.Clear();
                                        worker.PrintCvs();
                                        if (worker.IsListEmpty(worker.Cvs))
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("Your  cv list empty"); Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.Write("If you want back press enter->");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.ReadLine();
                                        goto workeroptions;
                                    }
                                    if (choise4 == 4)
                                    {
                                    advancedsearch:
                                        int choise6 = ConsoleHelper.MultipleChoice(50, 9, true, 2, "Advanced Search", "All annoucments", "<-Back");
                                        if (choise6 == 0)
                                        {
                                        filitroptions:
                                            Console.Clear();
                                            Console.SetCursorPosition(38, 1);
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("--------Category--------");
                                            int choise7 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "Software developer", "Web/Graphic design", "It/Telecommunications", "Economy", "Marketing / Media / PR", "Human Resources / Staff Management", "<-Back");
                                            switch (choise7)
                                            {
                                                case 0:
                                                    FilitrClass.FilitrCategoryId = 1;
                                                    break;
                                                case 1:
                                                    FilitrClass.FilitrCategoryId = 2;
                                                    break;
                                                case 2:
                                                    FilitrClass.FilitrCategoryId = 3;
                                                    break;
                                                case 3:
                                                    FilitrClass.FilitrCategoryId = 4;
                                                    break;
                                                case 4:
                                                    FilitrClass.FilitrCategoryId = 5;
                                                    break;
                                                case 5:
                                                    FilitrClass.FilitrCategoryId = 6;
                                                    break;
                                                case 6:
                                                    goto advancedsearch;
                                                    break;
                                            }
                                            Console.Clear();
                                            Console.SetCursorPosition(38, 1);
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("--------City--------");
                                            int choise8 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "Sumgait", "Ganja", "Baku", "Lankaran", "Shaki", "Quba", "<-Back");
                                            switch (choise8)
                                            {
                                                case 0:
                                                    FilitrClass.FilitrCity = "Sumgait";
                                                    break;
                                                case 1:
                                                    FilitrClass.FilitrCity = "Ganja";
                                                    break;
                                                case 2:
                                                    FilitrClass.FilitrCity = "Baku";
                                                    break;
                                                case 3:
                                                    FilitrClass.FilitrCity = "Lankaran";
                                                    break;
                                                case 4:
                                                    FilitrClass.FilitrCity = "Shaki";
                                                    break;
                                                case 5:
                                                    FilitrClass.FilitrCity = "Quba";
                                                    break;
                                                case 6:
                                                    goto advancedsearch;
                                                    break;
                                            }
                                            Console.Clear();
                                            Console.SetCursorPosition(38, 1);
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("--------Salary--------");
                                            int choise9 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "800+ Azn", "1000+ Azn", "1500+ Azn", "2000+ Azn", "3000+ Azn", "<-Back");
                                            switch (choise9)
                                            {
                                                case 0:
                                                    FilitrClass.FilitrMinimumSalary = 800;
                                                    break;
                                                case 1:
                                                    FilitrClass.FilitrMinimumSalary = 1000;
                                                    break;
                                                case 2:
                                                    FilitrClass.FilitrMinimumSalary = 1500;
                                                    break;
                                                case 3:
                                                    FilitrClass.FilitrMinimumSalary = 2000;
                                                    break;
                                                case 4:
                                                    FilitrClass.FilitrMinimumSalary = 3000;
                                                    break;
                                                case 5:
                                                    goto advancedsearch;
                                                    break;
                                            }
                                            Database.FilitrAnnoucments = Database.FilitrAnnoucments.FindAll(a => a.CategoryId == FilitrClass.FilitrCategoryId && a.City == FilitrClass.FilitrCity && FilitrClass.FilitrMinimumSalary < a.Salary);
                                            if (Database.FilitrAnnoucments.Count == 0)
                                            {
                                                Database.FilitrAnnoucments.Add(announcement1);
                                                Database.FilitrAnnoucments.Add(announcement2);
                                                Database.FilitrAnnoucments.Add(announcement3);
                                                Database.FilitrAnnoucments.Add(announcement4);
                                                Database.FilitrAnnoucments.Add(announcement5);
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.SetCursorPosition(38, 0);
                                                Console.WriteLine("We havent find annoucment this properties!!"); Console.ForegroundColor = ConsoleColor.White;
                                                Console.SetCursorPosition(38, 1);
                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("If you want continue to search or go Back?"); Console.ForegroundColor = ConsoleColor.White;
                                                int choise10 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "Continue Searching", "<-Back");
                                                switch (choise10)
                                                {
                                                    case 0:
                                                        goto filitroptions;
                                                        break;
                                                    case 1:
                                                        goto advancedsearch;
                                                        break;
                                                }
                                            }
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Database.FilitrAnnoucments.ForEach(a => Console.WriteLine(a));
                                        likeannouncment:
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("Do you like any announcment?(Y/N)");
                                            string option = Console.ReadLine();
                                            if (option == "Y" || option == "y")
                                            {
                                            subscribeannouncment:
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.Write("Enter which announcment you want subscribe(With id): ");
                                                string id = Console.ReadLine();
                                                int check3 = 0;
                                                if (checker.isNumber(id))
                                                {
                                                    foreach (var announcment in Database.FilitrAnnoucments)
                                                    {
                                                        if (announcment.ThisId == int.Parse(id))
                                                        {
                                                            foreach (var employee in db.Employees)
                                                            {
                                                                foreach (var annoucment in employee.Announcements)
                                                                {
                                                                    if (annoucment.ThisId == int.Parse(id))
                                                                    {
                                                                        Notification notification = new Notification { NotificationTime = DateTime.Now, Text = $"{worker.FullName} subscribed your {annoucment.Subject} announcment" };
                                                                        employee.Notifications.Add(notification);
                                                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                                        Console.WriteLine("----You succesfully subscribed this announcment and your cv send----"); Console.ForegroundColor = ConsoleColor.White;
                                                                        foreach (var cv in worker.Cvs)
                                                                        {
                                                                            employee.SubscribedEmployeeCv.Add(cv);
                                                                        }
                                                                        Thread.Sleep(1500);
                                                                        goto likeannouncment;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                    if (check3 == 0)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("No annoucment with this id"); Console.ForegroundColor = ConsoleColor.White;
                                                        Thread.Sleep(1000);
                                                        goto subscribeannouncment;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Incorrect Id"); Console.ForegroundColor = ConsoleColor.White;
                                                    Thread.Sleep(1000);
                                                    goto subscribeannouncment;
                                                }
                                            }
                                            else if (option == "N" || option == "n")
                                            {
                                                goto advancedsearch;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine("Incorrect option"); Console.ForegroundColor = ConsoleColor.White;
                                                Thread.Sleep(1000);
                                                goto likeannouncment;
                                            }



                                        }
                                        else if (choise6 == 1)
                                        {
                                            Console.Clear();
                                            foreach (var employee in db.Employees)
                                            {
                                                employee.PrintAnnoucments();
                                                Console.WriteLine("\n\n");
                                            }
                                        likeannouncment:
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("Do you like any announcment?(Y/N)");
                                            string option = Console.ReadLine();
                                            if (option == "Y" || option == "y")
                                            {
                                            subscribeannouncment:
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.Write("Enter which announcment you want subscribe(With id): ");
                                                string id = Console.ReadLine();
                                                int check3 = 0;
                                                if (checker.isNumber(id))
                                                {
                                                    foreach (var employee in db.Employees)
                                                    {
                                                        foreach (var announcement in employee.Announcements)
                                                        {
                                                            if (announcement.ThisId == int.Parse(id))
                                                            {
                                                                ++check3;
                                                                Notification notification = new Notification { NotificationTime = DateTime.Now, Text = $"{worker.FullName} subscribed your {announcement.Subject} announcment" };
                                                                employee.Notifications.Add(notification);
                                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                                Console.WriteLine("----You succesfully subscribed this announcment and your cv send----"); Console.ForegroundColor = ConsoleColor.White;
                                                                foreach (var cv in worker.Cvs)
                                                                {
                                                                    employee.SubscribedEmployeeCv.Add(cv);
                                                                }
                                                                Thread.Sleep(1500);
                                                                goto likeannouncment;
                                                            }
                                                        }
                                                    }
                                                    if (check3 == 0)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("No annoucment with this id"); Console.ForegroundColor = ConsoleColor.White;
                                                        Thread.Sleep(1000);
                                                        goto subscribeannouncment;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Incorrect Id"); Console.ForegroundColor = ConsoleColor.White;
                                                    Thread.Sleep(1000);
                                                    goto subscribeannouncment;
                                                }
                                            }
                                            else if (option == "N" || option == "n")
                                            {
                                                goto advancedsearch;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine("Incorrect option"); Console.ForegroundColor = ConsoleColor.White;
                                                Thread.Sleep(1000);
                                                goto likeannouncment;
                                            }
                                        }
                                        else if (choise6 == 2)
                                        {
                                            goto workeroptions;
                                        }
                                    }
                                    if (choise4 == 5)
                                    {
                                    Notification:
                                        Console.Clear();
                                        if (worker.Notifications.Count == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("You dont have any notification"); Console.ForegroundColor = ConsoleColor.White;
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.Write("Press enter key go back");
                                            Console.ReadLine(); Console.ForegroundColor = ConsoleColor.White;
                                            goto workeroptions;
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("-----------------------NOTIFICATIONS-----------------------"); Console.ForegroundColor = ConsoleColor.White;
                                        worker.PrintNotifications();
                                        int choise11 = ConsoleHelper.MultipleChoice(65, 1, false, 2, "Select notification", "Accept all notification", "Reject all notification", "<-Back");
                                        if (choise11 == 0)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("-----------------------NOTIFICATIONS-----------------------"); Console.ForegroundColor = ConsoleColor.White;
                                            worker.PrintNotifications();
                                        selectnotification:
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.WriteLine("Which notification you want select?"); Console.ForegroundColor = ConsoleColor.White;
                                            string id = Console.ReadLine();
                                            int count = 0;
                                            int count1 = 0;
                                            int check2 = 0;
                                            if (checker.isNumber(id))
                                            {
                                                foreach (var notification in worker.Notifications)
                                                {
                                                    if (notification.Id == int.Parse(id))
                                                    {
                                                        ++check2;
                                                        break;
                                                    }
                                                    ++count;
                                                }
                                                if (check2 == 0)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("You havent notification this id"); Console.ForegroundColor = ConsoleColor.White;
                                                    Thread.Sleep(1000);
                                                    goto selectnotification;
                                                }
                                                foreach (var joboffer in worker.JobOffers)
                                                {
                                                    if (count == count1)
                                                    {
                                                        Console.Clear();
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine(joboffer); Console.ForegroundColor = ConsoleColor.White;
                                                        int choise10 = ConsoleHelper.MultipleChoice(50, 1, false, 2, "Accept job offer", "Reject job offer");
                                                        if (choise10 == 0)
                                                        {
                                                            Console.Clear();
                                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                            Console.SetCursorPosition(36, 9);
                                                            Console.WriteLine("-----You accepted this job offer succesfully----"); Console.ForegroundColor = ConsoleColor.White;
                                                            worker.Notifications.RemoveAt(count);
                                                            worker.JobOffers.RemoveAt(count);
                                                            Thread.Sleep(1500);
                                                            goto Notification;
                                                        }
                                                        else if (choise10 == 1)
                                                        {
                                                            Console.Clear();
                                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                            Console.SetCursorPosition(36, 9);
                                                            Console.WriteLine("-----You rejected this job offer succesfully----"); Console.ForegroundColor = ConsoleColor.White;
                                                            worker.Notifications.RemoveAt(count);
                                                            worker.JobOffers.RemoveAt(count);
                                                            Thread.Sleep(1500);
                                                            goto Notification;
                                                        }
                                                    }
                                                    ++count1;
                                                }
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine("Incorrect Id"); Console.ForegroundColor = ConsoleColor.White;
                                                Thread.Sleep(1000);
                                                goto selectnotification;
                                            }
                                        }
                                        else if (choise11 == 1)
                                        {

                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.SetCursorPosition(36, 9);
                                            Console.WriteLine("-----You accepted all  job offers succesfully----"); Console.ForegroundColor = ConsoleColor.White;
                                            worker.Notifications.RemoveRange(0, worker.Notifications.Count);
                                            worker.JobOffers.RemoveRange(0, worker.JobOffers.Count);
                                            Thread.Sleep(1500);
                                            goto Notification;
                                        }
                                        else if (choise11 == 2)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.SetCursorPosition(36, 9);
                                            Console.WriteLine("-----You rejected all  job offers succesfully----"); Console.ForegroundColor = ConsoleColor.White;
                                            worker.Notifications.RemoveRange(0, worker.Notifications.Count);
                                            worker.JobOffers.RemoveRange(0, worker.JobOffers.Count);
                                            Thread.Sleep(1500);
                                            goto Notification;
                                        }
                                        else if (choise11 == 3)
                                        {
                                            goto workeroptions;
                                        }
                                    }
                                    if (choise4 == 6)
                                    {
                                        goto SecondPart;
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("Incorrect password try again!!\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    int choise3 = ConsoleHelper.MultipleChoice(50, 5, false, 1, "Continue", "<-Back");
                                    if (choise3 == 1) { goto SecondPart; }
                                    if (choise3 == 0) { checker.ClearCurrentConsoleLine(); checker.ClearLastLine(); Console.WriteLine(); continue; }
                                }
                            }
                        }
                    }
                    if (check == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Incorrect email try again!!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        int choise3 = ConsoleHelper.MultipleChoice(50, 9, false, 1, "Continue", "<-Back");
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
            SecondPart:
                int choise2 = ConsoleHelper.MultipleChoice(44, 9, true, 2, "Sign up", "Sign in", "<-Back");
                if (choise2 == 0)
                {
                    while (true)
                    {
                        Console.Clear();
                        fullName:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Enter your Fullname: ");
                        string fullName = Console.ReadLine();
                        if (checker.isString(fullName)) { }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Incorrect fullname try again!!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto fullName;
                        }
                        username:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Enter your Username: ");
                        string userName = Console.ReadLine();
                        if (checker.isString(userName)) { }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Incorrect username try again!!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto username;
                        }
                    Age:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("--Age must be more than 18--");
                        Console.Write("Enter your Age: ");
                        string age = Console.ReadLine();
                        if (checker.IsValidAge(age)) { }
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
                        if (checker.IsValidEmail(email)) { }
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
                        if (checker.ValidatePassword(password)) { }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Incorrect password try again!!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto Password;
                        }
                        Employee employee = new Employee(fullName, userName, int.Parse(age), email, password);
                        db.Employees.Add(employee);
                        JsonFormat.WriteToJsonFile(db.Employees, "Employees.json");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("---You succesfully signed up---"); Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(1500);
                        goto SecondPart;
                    }
                }
                if (choise2 == 1)
                {
                    Console.Clear();
                    int check = 0;
                email:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Enter your email:");
                    string email = Console.ReadLine();
                    foreach (var employee in db.Employees)
                    {
                        if (employee.Email == email)
                        {
                            while (true)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("Enter your password:");
                                string password = Console.ReadLine();
                                if (password == employee.Password)
                                {
                                    ++check;
                                employeeoptions:
                                    int choise4 = ConsoleHelper.MultipleChoice(50, 9, true, 1, "Add Annoucment", "Delete annoucment", "Update annoucment", "Show your annoucments", "Find Worker", "Show Notifications", "<-Back");
                                    if (choise4 == 0)
                                    {
                                        Console.Clear();
                                        Console.SetCursorPosition(38, 7);
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("-----------Category-----------");
                                        int choise5 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "Software developer", "Web/Graphic design", "IT / Telecommunications", "Ecenomy", "Marketing / Media / PR", "Human Resources / Staff Management", "<-Back");
                                        switch (choise5)
                                        {
                                            case 0:
                                                employee.AddAnnoucment(Helper.AnnoucmentObject(1));
                                                goto employeeoptions;
                                                break;
                                            case 1:
                                                employee.AddAnnoucment(Helper.AnnoucmentObject(2));
                                                goto employeeoptions;
                                                break;
                                            case 2:
                                                employee.AddAnnoucment(Helper.AnnoucmentObject(3));
                                                goto employeeoptions;
                                                break;
                                            case 3:
                                                employee.AddAnnoucment(Helper.AnnoucmentObject(4));
                                                goto employeeoptions;
                                                break;
                                            case 4:
                                                employee.AddAnnoucment(Helper.AnnoucmentObject(5));
                                                goto employeeoptions;
                                                break;
                                            case 5:
                                                employee.AddAnnoucment(Helper.AnnoucmentObject(6));
                                                goto employeeoptions;
                                                break;
                                            case 6:
                                                goto employeeoptions;
                                                break;
                                        }

                                    }
                                    else if (choise4 == 1)
                                    {
                                        Console.Clear();
                                        employee.PrintAnnoucments();
                                    deleteannoucment:
                                        if (employee.IsListEmpty(employee.Announcements))
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("Your  annoucment list empty"); Console.ForegroundColor = ConsoleColor.White;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("Press enter key to go back.."); Console.ForegroundColor = ConsoleColor.White;
                                            Console.ReadLine();
                                            goto employeeoptions;
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.Write("Which announcment you want delete(with id): ");
                                        string id;
                                        int check1 = 0;
                                        id = Console.ReadLine();
                                        if (checker.isNumber(id))
                                        {
                                            foreach (var announcement in employee.Announcements)
                                            {
                                                if (announcement.ThisId.ToString() == id)
                                                {
                                                    ++check1;
                                                    break;
                                                }
                                            }
                                            if (check1 == 0)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("You haven't annoucment this id"); Console.ForegroundColor = ConsoleColor.White;
                                                goto deleteannoucment;
                                            }
                                            var item = employee.Announcements.SingleOrDefault(x => x.ThisId == int.Parse(id));
                                            employee.Announcements.Remove(item);
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("Your announcment deleted succesfully"); Console.ForegroundColor = ConsoleColor.White;
                                            Thread.Sleep(1500);
                                            goto employeeoptions;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Incorrect Id"); Console.ForegroundColor = ConsoleColor.White;
                                            goto deleteannoucment;
                                        }

                                    }
                                    else if (choise4 == 2)
                                    {
                                        int check2 = 0;
                                        Console.Clear();
                                        if (employee.Announcements.Count == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("Your  cv list empty"); Console.ForegroundColor = ConsoleColor.White;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("Press enter key to go back.."); Console.ForegroundColor = ConsoleColor.White;
                                            Console.ReadLine();
                                            goto employeeoptions;
                                        }
                                        employee.PrintAnnoucments();
                                    updateannouncment:
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.WriteLine("Which announcment you want update (with id)");
                                        string id = Console.ReadLine();
                                        if (checker.isNumber(id))
                                        {
                                            foreach (var announcment in employee.Announcements)
                                            {
                                                if (announcment.ThisId.ToString() == id)
                                                {
                                                    ++check2;
                                                    break;
                                                }
                                            }
                                            if (check2 == 0)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("You haven't cv this id"); Console.ForegroundColor = ConsoleColor.White;
                                                goto updateannouncment;
                                            }
                                            var annoucmentUpdate = employee.Announcements.SingleOrDefault(x => x.ThisId == int.Parse(id));
                                            Console.Clear();
                                        updateoptions:
                                            Console.Clear();
                                            Console.SetCursorPosition(38, 7);
                                            Console.WriteLine("Which parameter you want update: ");
                                            int choise8 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "Job Name", "Work Experience", "Age", "City", "Relevant Person", "Email", "Phone Number", "<-Back");
                                            switch (choise8)
                                            {
                                                case 0:
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("New Job Name: "); Console.ForegroundColor = ConsoleColor.White;
                                                    string subject = Console.ReadLine();
                                                    if (checker.isString(subject)) { }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.WriteLine("Incorrect Job name!!");
                                                        Thread.Sleep(1000);
                                                        goto case 0;
                                                    }
                                                    annoucmentUpdate.Subject = subject;
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("Work name updated sucesfully"); Console.ForegroundColor = ConsoleColor.White;
                                                    break;
                                                case 1:
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("New Experience: "); Console.ForegroundColor = ConsoleColor.White;
                                                    string workExperience = Console.ReadLine();
                                                    annoucmentUpdate.WorkExperience = workExperience;
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("Work Experience updated sucesfully"); Console.ForegroundColor = ConsoleColor.White;
                                                    break;
                                                case 2:
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("---Age must be more than 18---");
                                                    Console.WriteLine("New Age: "); Console.ForegroundColor = ConsoleColor.White;
                                                    string age = Console.ReadLine();
                                                    if (checker.IsValidAge(age)) { }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.WriteLine("Incorrect Age!!");
                                                        Thread.Sleep(1000);
                                                        goto case 2;
                                                    }
                                                    annoucmentUpdate.Age = age;
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("Your Age updated sucesfully"); Console.ForegroundColor = ConsoleColor.White;
                                                    break;
                                                case 3:
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("New City: "); Console.ForegroundColor = ConsoleColor.White;
                                                    string city = Console.ReadLine();
                                                    if (checker.isString(city)) { }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.WriteLine("Incorrect city name!!");
                                                        Thread.Sleep(1000);
                                                        goto case 3;
                                                    }
                                                    annoucmentUpdate.City = city;
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("City updated sucesfully"); Console.ForegroundColor = ConsoleColor.White;
                                                    break;
                                                case 4:
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("New Relevant Person: "); Console.ForegroundColor = ConsoleColor.White;
                                                    string relevantPerson = Console.ReadLine();
                                                    if (checker.isString(relevantPerson)) { }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.WriteLine("Incorrect relevant person name!!");
                                                        Thread.Sleep(1000);
                                                        goto case 4;
                                                    }
                                                    annoucmentUpdate.RelevantPerson = relevantPerson;
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("Relevant Person updated sucesfully"); Console.ForegroundColor = ConsoleColor.White;
                                                    break;
                                                case 5:
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("New Email: "); Console.ForegroundColor = ConsoleColor.White;
                                                    string emaill = Console.ReadLine();
                                                    if (checker.IsValidEmail(emaill)) { }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.WriteLine("Incorrect email!!");
                                                        Thread.Sleep(1000);
                                                        goto case 5;
                                                    }
                                                    annoucmentUpdate.Email = emaill;
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("Relevant Person updated sucesfully"); Console.ForegroundColor = ConsoleColor.White;
                                                    break;
                                                case 6:
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                    Console.WriteLine("New Phone Number: "); Console.ForegroundColor = ConsoleColor.White;
                                                    string phoneNumber = Console.ReadLine();
                                                    if (checker.isNumber(phoneNumber)) { }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                                        Console.WriteLine("Incorrect phone number!!");
                                                        Thread.Sleep(1000);
                                                        goto case 6;
                                                    }
                                                    annoucmentUpdate.PhoneNumber = phoneNumber;
                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine("Phone Number updated sucesfully"); Console.ForegroundColor = ConsoleColor.White;
                                                    break;
                                                case 7:
                                                    goto employeeoptions;
                                                    break;
                                            }
                                            Console.SetCursorPosition(38, 7);
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("Do you want continue or go back? ");
                                            int choise9 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "Continue", "Back");
                                            switch (choise9)
                                            {
                                                case 0:
                                                    goto updateoptions;
                                                    break;
                                                case 1:
                                                    goto employeeoptions;
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Incorrect Id"); Console.ForegroundColor = ConsoleColor.White;
                                            goto updateannouncment;
                                        }

                                    }
                                    else if (choise4 == 3)
                                    {
                                        Console.Clear();
                                        employee.PrintAnnoucments();
                                        if (employee.IsListEmpty(employee.Announcements))
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("Your  annoucment list empty"); Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.Write("If you want back press enter key->");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.ReadLine();
                                        goto employeeoptions;
                                    }
                                    else if (choise4 == 4)
                                    {
                                    advancedsearch:
                                        int choise6 = ConsoleHelper.MultipleChoice(50, 9, true, 2, "Advanced Search", "All Cvs", "<-Back");
                                        if (choise6 == 0)
                                        {
                                        filitroptions:
                                            Console.Clear();
                                            Console.SetCursorPosition(38, 1);
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("--------Category--------");
                                            int choise7 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "Software developer", "Web/Graphic design", "It/Telecommunications", "Economy", "Marketing / Media / PR", "Human Resources / Staff Management", "<-Back");
                                            switch (choise7)
                                            {
                                                case 0:
                                                    FilitrClass.FilitrCategoryId = 1;
                                                    break;
                                                case 1:
                                                    FilitrClass.FilitrCategoryId = 2;
                                                    break;
                                                case 2:
                                                    FilitrClass.FilitrCategoryId = 3;
                                                    break;
                                                case 3:
                                                    FilitrClass.FilitrCategoryId = 4;
                                                    break;
                                                case 4:
                                                    FilitrClass.FilitrCategoryId = 5;
                                                    break;
                                                case 5:
                                                    FilitrClass.FilitrCategoryId = 6;
                                                    break;
                                                case 6:
                                                    goto advancedsearch;
                                                    break;
                                            }
                                            Console.Clear();
                                            Console.SetCursorPosition(38, 1);
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("--------City--------");
                                            int choise8 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "Sumgait", "Ganja", "Baku", "Lankaran", "Shaki", "Quba", "<-Back");
                                            switch (choise8)
                                            {
                                                case 0:
                                                    FilitrClass.FilitrCity = "Sumgait";
                                                    break;
                                                case 1:
                                                    FilitrClass.FilitrCity = "Ganja";
                                                    break;
                                                case 2:
                                                    FilitrClass.FilitrCity = "Baku";
                                                    break;
                                                case 3:
                                                    FilitrClass.FilitrCity = "Lankaran";
                                                    break;
                                                case 4:
                                                    FilitrClass.FilitrCity = "Shaki";
                                                    break;
                                                case 5:
                                                    FilitrClass.FilitrCity = "Quba";
                                                    break;
                                                case 6:
                                                    goto advancedsearch;
                                                    break;
                                            }
                                            Console.Clear();
                                            Console.SetCursorPosition(38, 1);
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("--------Age--------");
                                            int choise9 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "18+", "25+ ", "35+", "45+", "50+", "<-Back");
                                            switch (choise9)
                                            {
                                                case 0:
                                                    FilitrClass.FilitrMinimumAge = 18;
                                                    break;
                                                case 1:
                                                    FilitrClass.FilitrMinimumAge = 25;
                                                    break;
                                                case 2:
                                                    FilitrClass.FilitrMinimumAge = 35;
                                                    break;
                                                case 3:
                                                    FilitrClass.FilitrMinimumAge = 45;
                                                    break;
                                                case 4:
                                                    FilitrClass.FilitrMinimumAge = 50;
                                                    break;
                                                case 5:
                                                    goto advancedsearch;
                                                    break;
                                            }
                                            Database.FilitrCvs = Database.FilitrCvs.FindAll(c => c.CategoryId == FilitrClass.FilitrCategoryId && c.City == FilitrClass.FilitrCity && FilitrClass.FilitrMinimumAge < c.Age);
                                            if (Database.FilitrCvs.Count == 0)
                                            {
                                                Database.FilitrCvs.Add(cv1);
                                                Database.FilitrCvs.Add(cv2);
                                                Database.FilitrCvs.Add(cv3);
                                                Database.FilitrCvs.Add(cv4);
                                                Database.FilitrCvs.Add(cv5);
                                                Database.FilitrCvs.Add(cv6);
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.SetCursorPosition(38, 0);
                                                Console.WriteLine("We havent find cv this properties!!"); Console.ForegroundColor = ConsoleColor.White;
                                                Console.SetCursorPosition(38, 1);
                                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("If you want continue to search or go Back?"); Console.ForegroundColor = ConsoleColor.White;
                                                int choise10 = ConsoleHelper.MultipleChoice(36, 9, false, 2, "Continue Searching", "<-Back");
                                                switch (choise10)
                                                {
                                                    case 0:
                                                        goto filitroptions;
                                                        break;
                                                    case 1:
                                                        goto advancedsearch;
                                                        break;
                                                }
                                            }
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Database.FilitrCvs.ForEach(a => Console.WriteLine(a));
                                        likecv:
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("Do you like any cv?(Y/N)");
                                            string option = Console.ReadLine();
                                            if (option == "Y" || option == "y")
                                            {
                                            subscribecv:
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.Write("Enter which cv you want subscribe(With id): ");
                                                string id = Console.ReadLine();
                                                int check3 = 0;
                                                if (checker.isNumber(id))
                                                {
                                                    foreach (var cv in Database.FilitrCvs)
                                                    {
                                                        if (cv.ThisId == int.Parse(id))
                                                        {
                                                            foreach (var worker in db.Workers)
                                                            {
                                                                foreach (var cvv in worker.Cvs)
                                                                {
                                                                    if (cvv.ThisId == int.Parse(id))
                                                                    {
                                                                        Notification notification = new Notification { NotificationTime = DateTime.Now, Text = $"{employee.FullName} subscribed your cv" };
                                                                        worker.Notifications.Add(notification);
                                                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                                        Console.WriteLine("----You succesfully subscribed this announcment and your announcment send----"); Console.ForegroundColor = ConsoleColor.White;
                                                                        foreach (var annoucment in employee.Announcements)
                                                                        {
                                                                            worker.JobOffers.Add(annoucment);
                                                                        }
                                                                        Thread.Sleep(1500);
                                                                        goto likecv;
                                                                    }
                                                                }
                                                               
                                                            }
                                                        }
                                                    }
                                                    if (check3 == 0)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("No cv with this id"); Console.ForegroundColor = ConsoleColor.White;
                                                        Thread.Sleep(1000);
                                                        goto subscribecv;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Incorrect Id"); Console.ForegroundColor = ConsoleColor.White;
                                                    Thread.Sleep(1000);
                                                    goto subscribecv;
                                                }
                                            }
                                            else if (option == "N" || option == "n")
                                            {
                                                goto advancedsearch;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine("Incorrect option"); Console.ForegroundColor = ConsoleColor.White;
                                                Thread.Sleep(1000);
                                                goto likecv;
                                            }
                                        }
                                        else if (choise6 == 1)
                                        {
                                            Console.Clear();
                                            foreach (var worker in db.Workers)
                                            {
                                                worker.PrintCvs();
                                                Console.WriteLine("\n\n");
                                            }
                                        likecv:
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("Do you like any cv?(Y/N)");
                                            string option = Console.ReadLine();
                                            if (option == "Y" || option == "y")
                                            {
                                            subscribecv:
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.Write("Enter which cv you want subscribe(With id): ");
                                                string id = Console.ReadLine();
                                                int check3 = 0;
                                                if (checker.isNumber(id))
                                                {
                                                    foreach (var worker in db.Workers)
                                                    {
                                                        foreach (var cv in worker.Cvs)
                                                        {
                                                            if (cv.ThisId == int.Parse(id))
                                                            {
                                                                ++check3;
                                                                Notification notification = new Notification { NotificationTime = DateTime.Now, Text = $"{employee.FullName} subscribed your cv" };
                                                                worker.Notifications.Add(notification);
                                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                                Console.WriteLine("----You succesfully subscribed this cv and your announcment send----"); Console.ForegroundColor = ConsoleColor.White;
                                                                foreach (var announcment in employee.Announcements)
                                                                {
                                                                    worker.JobOffers.Add(announcment);
                                                                }
                                                                Thread.Sleep(1500);
                                                                goto likecv;
                                                            }
                                                        }
                                                    }
                                                    if (check3 == 0)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("No cv with this id"); Console.ForegroundColor = ConsoleColor.White;
                                                        Thread.Sleep(1000);
                                                        goto subscribecv;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Incorrect Id"); Console.ForegroundColor = ConsoleColor.White;
                                                    Thread.Sleep(1000);
                                                    goto subscribecv;
                                                }
                                            }
                                            else if (option == "N" || option == "n")
                                            {
                                                goto advancedsearch;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine("Incorrect option"); Console.ForegroundColor = ConsoleColor.White;
                                                Thread.Sleep(1000);
                                                goto likecv;
                                            }

                                        }
                                        else if (choise6 == 2)
                                        {
                                            goto employeeoptions;
                                        }
                                    }
                                    else if (choise4 == 5)
                                    {
                                    Notification:
                                        Console.Clear();
                                        if (employee.Notifications.Count == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("You dont have any notification"); Console.ForegroundColor = ConsoleColor.White;
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.Write("Press enter key go back");
                                            Console.ReadLine(); Console.ForegroundColor = ConsoleColor.White;
                                            goto employeeoptions;
                                        }

                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("-----------------------NOTIFICATIONS-----------------------"); Console.ForegroundColor = ConsoleColor.White;
                                        employee.PrintNotifications();
                                        int choise11 = ConsoleHelper.MultipleChoice(65, 1, false, 2, "Select notification", "Accept all notification", "Reject all notification", "<-Back");
                                        if (choise11 == 0)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("-----------------------NOTIFICATIONS-----------------------"); Console.ForegroundColor = ConsoleColor.White;
                                            employee.PrintNotifications();
                                        selectnotification:
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.WriteLine("Which notification you want select?"); Console.ForegroundColor = ConsoleColor.White;
                                            string id = Console.ReadLine();
                                            int count = 0;
                                            int count1 = 0;
                                            int check2 = 0;
                                            if (checker.isNumber(id))
                                            {

                                                foreach (var notification in employee.Notifications)
                                                {
                                                    if (notification.Id == int.Parse(id))
                                                    {
                                                        ++check2;
                                                        break;
                                                    }
                                                    ++count;
                                                }
                                                if (check2 == 0)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("You havent notification this id"); Console.ForegroundColor = ConsoleColor.White;
                                                    Thread.Sleep(1000);
                                                    goto selectnotification;
                                                }
                                                foreach (var subcv in employee.SubscribedEmployeeCv)
                                                {
                                                    if (count == count1)
                                                    {
                                                        Console.Clear();
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine(subcv); Console.ForegroundColor = ConsoleColor.White;
                                                        int choise10 = ConsoleHelper.MultipleChoice(50, 1, false, 2, "Accept Cv", "Reject Cv");
                                                        if (choise10 == 0)
                                                        {
                                                            Console.Clear();
                                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                            Console.SetCursorPosition(36, 9);
                                                            Console.WriteLine("-----You accepted this cv succesfully----"); Console.ForegroundColor = ConsoleColor.White;
                                                            employee.Notifications.RemoveAt(count);
                                                            employee.SubscribedEmployeeCv.RemoveAt(count);
                                                            Thread.Sleep(1500);
                                                            goto Notification;
                                                        }
                                                        else if (choise10 == 1)
                                                        {
                                                            Console.Clear();
                                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                            Console.SetCursorPosition(36, 9);
                                                            Console.WriteLine("-----You rejected this cv succesfully----"); Console.ForegroundColor = ConsoleColor.White;
                                                            employee.Notifications.RemoveAt(count);
                                                            employee.SubscribedEmployeeCv.RemoveAt(count);
                                                            Thread.Sleep(1500);
                                                            goto Notification;
                                                        }
                                                    }
                                                    ++count1;
                                                }
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine("Incorrect Id"); Console.ForegroundColor = ConsoleColor.White;
                                                Thread.Sleep(1000);
                                                goto selectnotification;
                                            }
                                        }
                                        else if (choise11 == 1)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.SetCursorPosition(36, 9);
                                            Console.WriteLine("-----You accepted all  notification succesfully----"); Console.ForegroundColor = ConsoleColor.White;
                                            employee.Notifications.RemoveRange(0, employee.Notifications.Count);
                                            employee.SubscribedEmployeeCv.RemoveRange(0, employee.SubscribedEmployeeCv.Count);
                                            Thread.Sleep(1500);
                                            goto Notification;
                                        }
                                        else if (choise11 == 2)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.SetCursorPosition(36, 9);
                                            Console.WriteLine("-----You rejected all  notification succesfully----"); Console.ForegroundColor = ConsoleColor.White;
                                            employee.Notifications.RemoveRange(0, employee.Notifications.Count);
                                            employee.SubscribedEmployeeCv.RemoveRange(0, employee.SubscribedEmployeeCv.Count);
                                            Thread.Sleep(1500);
                                            goto Notification;
                                        }
                                        else if (choise11 == 3)
                                        {
                                            goto employeeoptions;
                                        }
                                    }
                                    else if (choise4 == 6)
                                    {
                                        goto SecondPart;
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("Incorrect password try again!!\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    int choise3 = ConsoleHelper.MultipleChoice(50, 5, false, 1, "Continue", "<-Back");
                                    if (choise3 == 1) { goto SecondPart; }
                                    if (choise3 == 0) { checker.ClearCurrentConsoleLine(); checker.ClearLastLine(); Console.WriteLine(); continue; }
                                }
                            }
                        }
                    }
                    if (check == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Incorrect email try again!!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        int choise3 = ConsoleHelper.MultipleChoice(50, 9, false, 1, "Continue", "<-Back");
                        if (choise3 == 1) { goto SecondPart; }
                        if (choise3 == 0) { Console.Clear(); goto email; }
                    }
                }
                if (choise2 == 2)
                {
                    goto FirstPart;
                }
            }
        }
    }
}
