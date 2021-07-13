using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss.az
{
    
    class Worker:Person
    {
        public Worker(string fullname, string username, int age,  string email, string password) : base(fullname, username, age,  email, password)
        {

        }
        public override string ToString()
        {            
            return base.ToString();
        }
    }
}
