using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss.az
{
    abstract class Person
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public Person(string fullname, string username, int age, string email, string password)
        {
            FullName = fullname;
            UserName = username;
            Age = age;
            Email = email;
            Password = password;
        }
        public override string ToString()
        {
            return $"Full Name: {FullName}\nUsername:{UserName}\nAge: {Age}\nEmail: {Email}\nPassword: {Password}\n";
        }
    }
}
