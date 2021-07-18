﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss.az
{
    class Notification
    {
        public int ID { get; set; } = 100;
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime NotificationTime { get; set; }
        public Notification()
        {
            Id = ++ID;
        }
        public void show()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Text: {Text}");
            Console.WriteLine($"NotificationTime: {NotificationTime}");
        }
    }
}
