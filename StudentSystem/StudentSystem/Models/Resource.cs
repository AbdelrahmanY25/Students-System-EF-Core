using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Resource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; } = null!;
        public string Url { get; set; } = null!;
        public ResourceType ResourceType { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
    }
    public enum ResourceType
    {
        Video,
        Presentation,
        Document,
        Other
    }
}
