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
        public int CategoryId { get; set; }
        public string City { get; set; }
        public string Age { get; set; }
        public string Subject { get; set; }
        public DateTime AnnoucmentTime { get; set; }
        public DateTime AnnoucmentEndTime { get; set; }
        public double Salary { get; set; }
        public string WorkExperience { get; set; }
        public string RelevantPerson { get; set; }      
        public string Email { get; set; }   
        public string PhoneNumber { get; set; }
        public Announcement(int categoryId,string subject,string city, string age, DateTime annoucmentTime,  DateTime annoucmentEndTime, double salary,string workExperience, string relevantPerson,  string email, string phoneNumber)
        {
            Subject = subject;
            CategoryId = categoryId;
            ThisId = ++Id;
            City = city;
            Age = age;
            AnnoucmentTime = annoucmentTime;
            AnnoucmentEndTime = annoucmentEndTime;         
            Salary = salary;
            WorkExperience = workExperience;        
            RelevantPerson = relevantPerson;          
            Email = email;                 
            PhoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            return $"ID:{ThisId}\nSubject:{Subject}\nCity:{City}\nAge: {Age}\nAnnoucmentTime:{AnnoucmentTime}\nAnnoucmentEndTime: {AnnoucmentEndTime}\n" +
                $"Salary:{Salary}\nWorkExperience: {WorkExperience}\nRelevantPerson: {RelevantPerson}\nEmail: {Email}\nPhoneNumber: {PhoneNumber}";
        }
    }
}
