using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class HomeWork
    {
        public int HomeWorkId { get; set; }
        public string Content { get; set; } = null!;
        public ContentType ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
        public Student Student { get; set; } = null!;
    }
    public enum ContentType
    {
        Application,
        Pdf,
        zip
    }
}
