using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace CCSD_Job_Search.Models
{
    public class Job
    {
      public enum Category
        {
            Admin,
            Support,
            Licensed
        }

        public int Id { get; set; }
        public string JobCategory { get; set; }
        public string Title { get; set; }
        public string? grade { get; set; }
        public string?  Ccode { get; set; }
        public string? Division { get; set; }
        public string? Description { get; set; }
        public string? FilePath { get; set; }
    }
}
