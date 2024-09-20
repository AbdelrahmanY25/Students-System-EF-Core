using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public DateTime RegistredOn { get; set; }
        public DateTime? Birthday { get; set; }
        public List<Course> Courses { get; set; } = null!;
        public ICollection<HomeWork> HomeWorks { get; } = new List<HomeWork>();
    }
}
