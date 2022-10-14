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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}