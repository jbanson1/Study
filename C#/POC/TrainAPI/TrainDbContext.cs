using Microsoft.EntityFrameworkCore;
using TrainAPI.Model;
using TrainAPI.Model.Entities;

namespace TrainAPI
{
    public class TrainDbContext : DbContext
    {
        public DbSet<Train> Trains { get; set; }

        public DbSet<Station> Stations { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<TrainDbContext>(
                options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));
        }
    }
}
