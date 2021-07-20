using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss.az
{
    class Notification
    {
        private static int ID { get; set; } = 200;
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime NotificationTime { get; set; }
        public Notification()
        {
            Id = ++ID;
        }
        public override string ToString()
        {
            return $"Id: {Id}\nText: {Text}\nNotification Time: {NotificationTime}";
        }
        public void show()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Text: {Text}");
            Console.WriteLine($"NotificationTime: {NotificationTime}");
        }
    }
}
