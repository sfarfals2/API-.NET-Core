using Med.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Med.Infrastruture.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Medication> Medications { get; set; }
    }
}
