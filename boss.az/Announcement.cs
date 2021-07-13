using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss.az
{
    class Announcement
    {
        public  int ThisId { get; set; }
        public static int Id { get; set; }
        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        private string _age;
        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        private DateTime _annoucmentTime;
        public DateTime AnnoucmentTime
        {
            get { return _annoucmentTime; }
            set { _annoucmentTime = value; }
        }
        private DateTime _annoucmentEndTime;
        public DateTime AnnoucmentEndTime
        {
            get { return _annoucmentEndTime; }
            set { _annoucmentEndTime = value; }
        }

        private double _salary;
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        private string _workExperience;
        public string WorkExperience
        {
            get { return _workExperience; }
            set { _workExperience = value; }
        }
        private string _relevantPerson;
        public string RelevantPerson
        {
            get { return _relevantPerson; }
            set { _relevantPerson = value; }
        }
        private string _email;      
        public string Email
        {
            get { return _relevantPerson; }
            set { _relevantPerson = value; }
        }
        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public Announcement(string subject,string city, string age, DateTime annoucmentTime,  DateTime annoucmentEndTime, double salary,string workExperience, string relevantPerson,  string email, string phoneNumber)
        {
            _subject = subject;
            ThisId = ++Id;
            _city = city;
            _age = age;
            _annoucmentTime = annoucmentTime;
            _annoucmentEndTime = annoucmentEndTime;         
            _salary = salary;
            _workExperience = workExperience;        
            _relevantPerson = relevantPerson;          
            _email = email;                 
            _phoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            return $"ID:{ThisId}\nCity:{_city}\nAge: {_age}\nAnnoucmentTime:{_annoucmentTime}\nAnnoucmentEndTime: {_annoucmentEndTime}\n" +
                $"Salary:{_salary}\nWorkExperience: {_workExperience}\nRelevantPerson: {_relevantPerson}\nEmail: {_workExperience}\nPhoneNumber: {_phoneNumber}";
        }








    }
}
