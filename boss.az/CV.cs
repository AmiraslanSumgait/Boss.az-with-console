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
        private string _name;
        private int _age;
        private string _city;
        private string _gender;
        private DateTime _cvTime;
        private DateTime _cvEndTime;  
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public DateTime CvTime
        {
            get { return _cvTime; }
            set { _cvTime = value; }
        }
        public DateTime CvEndTime
        {
            get { return _cvEndTime; }
            set { _cvEndTime = value; }
        }
        public string Skills { get; set; }
        public string Experience { get; set; }
        public CV(int categoryid,string workname,string name, int age, string city,  DateTime cvTime, DateTime cvEndTime,string skills,string experience)
        {
            ThisId = ++Id;
            CategoryId = categoryid;
            WorkName = workname;
            _name = name;
            _age = age;
            _city = city;
            _cvTime = cvTime;
            _cvEndTime = cvEndTime;
            Skills = skills;
            Experience = experience;
        }
    }
}
