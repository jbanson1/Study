using Microsoft.EntityFrameworkCore;
using RotaAPI.Models;

namespace RotaAPI.DataAccessLayer
{
    public class RotaDbContext : DbContext
    {
        public DbSet<Client> clients { get; set; }

        public DbSet<Assignment> assignments { get; set; }

        public DbSet<Person> people { get; set; }

        public DbSet<Certification> certifications { get; set; }

        public DbSet<Indicator> indicators { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MONGOL\\SQLEXPRESS;Initial Catalog=rotadb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
