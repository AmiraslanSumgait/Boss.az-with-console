using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss.az
{
    interface IEmploye
    {
        public void AddAnnoucment(Announcement announcement);
        
    }
    class Employee : Person, IEmploye
    {
        public List<Announcement> announcements { get; set; } = new List<Announcement>();

        public Employee(string name, string surname, int age,string email,string password):base(name,surname,age,email,password)
        {
           
        }
        public void AddAnnoucment(Announcement announcement)
        {           
            announcements.Add(announcement);
        }
        public void PrintAnnoucments()
        {
            int count = 0;
            foreach (var annoucment in announcements)
            {
                ++count;
                if (count % 2 == 0) { Console.ForegroundColor = ConsoleColor.Green; }
                else Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"------------Annoucment {count}------------");
                Console.WriteLine(annoucment);
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
