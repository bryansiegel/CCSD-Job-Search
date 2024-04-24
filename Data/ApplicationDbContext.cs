using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CCSD_Job_Search.Models;

namespace CCSD_Job_Search.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CCSD_Job_Search.Models.Job> Job { get; set; } = default!;
    }
}
