using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss.az
{
    interface IWorker
    {
        public void AddCv(CV cv);
        public void DeleteCv(int id);
    }
    class Worker:Person,IWorker
    {
        public List<CV> Cvs { get; set; } = new List<CV>();
        public List<Notification> Notifications { get; set; } = new List<Notification>();
        public List<Announcement> JobOffers { get; set; } = new List<Announcement>();
        public Worker(string fullname, string username, int age,  string email, string password) : base(fullname, username, age,  email, password)
        {

        }
        public override string ToString()
        {            
            return base.ToString();
        }

        public void AddCv(CV cv)
        {
            Cvs.Add(cv);
        }
        public void DeleteCv(int id)
        {
            foreach (var cv in Cvs)
            {
                if (cv.ThisId == id)
                {
                    Cvs.Remove(cv);
                }
            }
        }
        public void PrintCvs()
        {
            int count = 0;
            foreach (var cv in Cvs)
            {
                ++count;
                if (count % 2 == 0) { Console.ForegroundColor = ConsoleColor.Green; }
                else Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"------------Cv {count}------------");
                Console.WriteLine(cv);
            }
        }
        public bool IsListEmpty(List<CV> cvs)
        {
            if (cvs.Count == 0) return true;
            else return false;
        }
    }
}
