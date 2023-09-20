using Microsoft.EntityFrameworkCore;
using planetsapi.Models;

namespace planetsapi.Data
{
    public class IssueDbContext: DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options)
            :base(options)
        {
        }
        public DbSet<Issue> Issues2 { get; set; }
    }
}
