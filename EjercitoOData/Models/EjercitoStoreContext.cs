using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercitoOData.Models
{
    public class EjercitoStoreContext : DbContext
    {
        public DbSet<Ejercito> Ejercitos { get; set; }
        public EjercitoStoreContext(DbContextOptions<EjercitoStoreContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}