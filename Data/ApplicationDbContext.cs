using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CCSD_Job_Search.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CCSD_Job_Search.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is Job && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach(var entity in entities)
            {
                var now = DateTime.UtcNow;
                if (entity.State == EntityState.Added) 
                {
                    ((Job)entity.Entity).UpdatedAt = now;
                }
                else
                {
                    //Entry(entity.Entity).Property(nameof(Job.UpdatedAt)).IsModified = false;
                }
            }
           

            return base.SaveChanges();
        }
        public DbSet<CCSD_Job_Search.Models.Job> Job { get; set; } = default!;
    }
}
