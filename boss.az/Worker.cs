using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boss.az
{
    interface IWorker
    {
        public void AddCv(CV cv);
    }
    class Worker:Person,IWorker
    {
        public List<CV> Cvs { get; set; } = new List<CV>();
        public Worker(string fullname, string username, int age,  string email, string password) : base(fullname, username, age,  email, password)
        {

        }
        public override string ToString()
        {            
            return base.ToString();
        }

        public void AddCv(CV cv)
        {
            Cvs.Add(cv);
        }
    }
}
