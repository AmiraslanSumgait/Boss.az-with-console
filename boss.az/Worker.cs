using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss.az
{
    
    class Worker:Person
    {
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
        public Worker(string name, string surname, int age, string gender,string email,string password):base( name,  surname,  age,  gender)
        {
            _email = email;
            _password = password;
        }
        public override string ToString()
        {
             
            return base.ToString()+$"Email: {_email}\nPassword: {_password}";
        }
    }
}
