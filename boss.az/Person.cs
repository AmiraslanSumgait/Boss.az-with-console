using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss.az
{
    class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private string _gender;
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public Person(string name, string surname, int age, string gender)
        {
            _name = name;
            _surname = surname;
            _age = age;
            _gender = gender;
        }
        public override string ToString()
        {
            return $"Name: {_name}\nSurname:{_surname}\nAge: {_age}\nGender: {Gender}\n";
        }
    }
}
