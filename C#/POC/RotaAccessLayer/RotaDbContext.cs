using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RotaAPI.Models;

namespace RotaAccessLayer
{
    public class RotaDbContext : DbContext
    {
        public DbSet<Client>

        public RotaDbContext(DbContextOptions<RotaDbContext>options):base(options) 
        {
        
        } 
    }
}
