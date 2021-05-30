using System.ComponentModel.DataAnnotations;

namespace contracted.Models
{
    public class ContractorJobs
    {
        public int Id { get; set; }
        [Required]
        public int JobId { get; set; }
        [Required]
        public int ContractorId { get; set; }
    }
    public class ContractorJobsViewModel : Job
    {
        public string ContractorName { get; set; }
        public string Skill { get; set; }
        public int JobId { get; set; }
        public int ContractorId { get; set; }
        public int ContractorJobId { get; set; }
    }
}