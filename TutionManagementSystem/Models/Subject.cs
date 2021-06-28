using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutionManagementSystem.Models
{
    public class Subject
    {
        public int ID { get; set; }
        public string SubjectName { get; set; }
        public decimal Fees { get; set; }

        public List<Student> Students { get; set; }
    }
}
