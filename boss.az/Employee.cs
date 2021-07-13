using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss.az
{
    interface IEmploye
    {
        public void AddAnnoucment();
        
    }
    class Employee : Person, IEmploye
    {
        public List<Announcement> announcements { get; set; }
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
         public Employee(string name, string surname, int age, string gender,string email,string password):base(name,surname,age,gender)
         {
            _email = email;
            _password = password;
        }
        public void AddAnnoucment()
        {
            throw new NotImplementedException();
        }
    }
}
