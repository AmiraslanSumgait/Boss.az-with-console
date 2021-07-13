using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace boss.az
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            UTF8Encoding utf8 = new UTF8Encoding();
            Worker w1 = new Worker("Nebi", "Nebili", 18, "Male", "nnabili035@gmail.com","Azerbaycan123");
            Worker w2 = new Worker("Kamal", "Eliyev", 15, "Male", "kamalaliyev7@gmail.com", "Salam qaqa");
            Announcement announcement = new Announcement("Sumqayət","18-25", new DateTime(2020, 09, 21), new DateTime(2020, 10, 21), 800, "1 ilden 3 ile qeder", "Amiraslan", "emiraslaneliyev45@gmail.com","+994557134655");
            Database db = new Database{
                 Workers=new List<Worker> {w1,w2}
            };
            Console.WriteLine(announcement);
            Thread.Sleep(5000);
            foreach (var item in db.Workers)
            {
                Console.WriteLine(item);
                //Thread.Sleep(5000);
            }
            Alma:
            int choise1 = ConsoleHelper.MultipleChoice("Worker", "Employee");
            if (choise1 == 0)
            {
                int choise2 = ConsoleHelper.MultipleChoice("Sign up", "Sign in","Exit");
                if (choise2 == 0)
                {

                }
                else if (choise2 == 1)
                {

                }
                else if (choise2 == 2)
                {
                    goto Alma;
                }
            }
            else if (choise1 == 1)
            {

            }
        }     
    }
}
