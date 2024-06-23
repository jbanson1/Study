using Microsoft.EntityFrameworkCore;
using UndergroundAPI.Infrastructure.Models.Entities;

namespace UndergroundAPI.Domain
{
    public class TrainDbContext : DbContext
    {
        public DbSet<Train> Trains { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MONGOL\\SQLEXPRESS;Initial Catalog=rotadb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

    }
}