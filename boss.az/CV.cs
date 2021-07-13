using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss.az
{
    class CV
    {
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
        public CV()
        {

        }

    }
}
