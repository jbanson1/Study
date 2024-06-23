using Microsoft.EntityFrameworkCore;
using UndergroundAPI.Models.Entities;

namespace UndergroundAPI
{
    public class TrainDbContext : DbContext
    {
        public DbSet<Train> Trains { get; set; }

        public DbSet<Station> Stations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MONGOL\\SQLEXPRESS;Initial Catalog=rotadb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

    }
}