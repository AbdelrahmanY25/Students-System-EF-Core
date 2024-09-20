using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public List<Student> Students { get; set; } = null!;
        public ICollection<Resource> Resources { get; } = new List<Resource>();
        public ICollection<HomeWork> HomeWorks { get; } = new List<HomeWork>();
        public HomeWork HomeWork { get; set; } = null!;
    }
}
