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
            if (db.isString(name)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect name try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto Cvdisplay;
            }
            job:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Your job: ");
            string workName = Console.ReadLine();
            if (db.isString(workName)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect job name try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto job;
            }
           
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
            city:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Your city: ");
            string city = Console.ReadLine();
            if (db.isString(city)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect city try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto city;
            }
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
        public static Announcement AnnoucmentObject(int categoryId)
        {
            Console.Clear();
            Database db = new Database();
        Cvdisplay:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Subject: ");
            string subject = Console.ReadLine();
            if (db.isString(subject)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect subject try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto Cvdisplay;
            }
        city:
            Console.Write("City: ");
            string city = Console.ReadLine();
            if (db.isString(city)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect city try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto city;
            }
        Age1:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--Age must be more than 18--");
            Console.Write("Enter  Age: ");
            string age = Console.ReadLine();
            if (db.IsValidAge(age)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect age try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto Age1;
            }
            salary:
            Console.Write("Salary: ");
            string salary = Console.ReadLine();
            if (db.isNumber(salary)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect salary try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto salary;
            }
            Console.Write("Work experience: ");
            string workexperience = Console.ReadLine();
        relevantperson:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Relevant person: ");
            string relevantPerson = Console.ReadLine();
            if (db.isString(relevantPerson)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect relevant person name try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto Cvdisplay;
            }
            email:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Email: ");
            string email = Console.ReadLine();
            if (db.IsValidEmail(email)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect email try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto email;
            }
            phonenumber:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();
            if (db.isNumber(phoneNumber)) { }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Incorrect phone number try again!!\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto phonenumber;
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("You succefully added Annoucment");
            Announcement announcement = new Announcement(categoryId, subject, city, age, DateTime.Now, DateTime.Now.AddDays(30), int.Parse(salary), workexperience, relevantPerson,email,phoneNumber); 
            Thread.Sleep(1500); Console.ForegroundColor = ConsoleColor.White;
            return announcement;
        }
    }
}
