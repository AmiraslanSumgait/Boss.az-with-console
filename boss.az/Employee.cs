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
        public List<Announcement> Announcements { get; set; } = new List<Announcement>();
        public List<Notification> Notifications { get; set; } = new List<Notification>();
        public List<CV> SubscribedEmployeeCv { get; set; } = new List<CV>();


        public Employee(string name, string surname, int age,string email,string password):base(name,surname,age,email,password)
        {
           
        }
        public void AddAnnoucment(Announcement announcement)
        {
            Announcements.Add(announcement);
        }
        public void PrintAnnoucments()
        {
            int count = 0;
            foreach (var annoucment in Announcements)
            {
                ++count;
                if (count % 2 == 0) { Console.ForegroundColor = ConsoleColor.Green; }
                else Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"------------Annoucment {count}------------");
                Console.WriteLine(annoucment);
            }
        }
        public void PrintNotifications()
        {
            int count = 0;
            foreach (var notification in Notifications)
            {
                ++count;
                if (count % 2 == 0) { Console.ForegroundColor = ConsoleColor.Green; }
                else Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"------------Notification {count}------------");
                Console.WriteLine(notification);
            }

        }
        public bool IsListEmpty(List<Announcement> announcements)
        {
            if (announcements.Count == 0) return true;
            else return false;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
