using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss.az
{
    class Person
    {
        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        private string _username;
        public string USerName
        {
            get { return _username; }
            set { _username = value; }
        }
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
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public Person(string fullname, string username, int age, string email, string password)
        {
            _fullName = fullname;
            _username = username;
            _age = age;
            _email = email;
            _password = password;
        }
        public override string ToString()
        {
            return $"Full Name: {_fullName}\nUsername:{_username}\nAge: {_age}\nEmail: {_email}\nPassword: {_password}\n";
        }
    }
}
