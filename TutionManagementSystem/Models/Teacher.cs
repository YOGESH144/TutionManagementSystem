using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutionManagementSystem.Models
{
    public class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Qualification { get; set; }
        public string MainSubject { get; set; }
        public string PhonenNumber { get; set; }

        public List<Student> Students { get; set; }
    }
}
