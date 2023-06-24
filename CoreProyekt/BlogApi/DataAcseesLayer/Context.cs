using Microsoft.EntityFrameworkCore;

namespace BlogApi.DataAcseesLayer
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS; database= BlogApi; integrated security=true; TrustServerCertificate=True; ");
        }
        public DbSet<Employer> Employers { get; set; }

    }
}
