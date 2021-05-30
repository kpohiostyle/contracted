using System;

namespace contracted.Models
{
    public class Job
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PayOut { get; set; }
    }
}