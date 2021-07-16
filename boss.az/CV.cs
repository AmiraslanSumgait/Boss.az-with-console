using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss.az
{
    class CV
    {
        public int ThisId { get; set; }
        public static int Id { get; set; } = 100;
        public int CategoryId { get; set; }
        public string WorkName { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public DateTime CvTime { get; set; }
        public DateTime CvEndTime { get; set; }
        public string Skills { get; set; }
        public string Experience { get; set; }
        public CV(int categoryid,string workname,string name, int age, string city,  DateTime cvTime, DateTime cvEndTime,string skills,string experience)
        {
            ThisId = ++Id;
            CategoryId = categoryid;
            WorkName = workname;
            Name = name;
            Age = age;
            City = city;
            CvTime = cvTime;
            CvEndTime = cvEndTime;
            Skills = skills;
            Experience = experience;
        }
        public override string ToString()
        {
            return $"Id: {ThisId}\nCategory Id:{CategoryId}\nAge: {Age}\nJob: {WorkName}\nName: {Name}\nCity: {City}\nCv Share Time: {CvTime}\nCv End Time: {CvEndTime}\nSkills: {Skills}\nExperience: {Experience}";
        }
    }
}
