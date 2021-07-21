using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace boss.az
{
    class Database
    {
        public List<Worker> Workers { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Category> Categories { get; set; }
        public static List<Announcement> FilitrAnnoucments { get; set; } = new List<Announcement>();    
        public static List<CV> FilitrCvs { get; set; } = new List<CV>();    
       
        public void PrintAnnoucments()
        {

        }
    }
}

 
