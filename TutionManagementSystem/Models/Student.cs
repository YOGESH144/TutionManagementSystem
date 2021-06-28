using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutionManagementSystem.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public decimal TutionFees { get; set; }

        public int SubjectID { get; set; }
        public int TeacherID { get; set; }
        public Subject Subject { get; set; }
        public Teacher Teacher { get; set; }
    }
}
