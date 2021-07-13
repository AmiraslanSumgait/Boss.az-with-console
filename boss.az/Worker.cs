using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss.az
{
    
    class Worker:Person
    {
        public Worker(string name, string surname, int age, string gender, string email, string password) : base(name, surname, age, gender, email, password)
        {

        }
        public override string ToString()
        {            
            return base.ToString();
        }
    }
}
