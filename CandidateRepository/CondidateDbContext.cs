using CandidateCore.Models;
using Microsoft.EntityFrameworkCore;

namespace CandidateRepository
{
    public class CondidateDbContext : DbContext
    {
        public CondidateDbContext(DbContextOptions<CondidateDbContext> options) : base(options)
        {
            //bu bir constructure method'dur.
            //bir clastan nesne oluşturulduğu zaman, ilk burası çalışır.
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<RecruitmentStep> RecruitmentSteps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}