using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercitoOData.Models
{
    public class EjercitoStoreContext : DbContext
    {
        public EjercitoStoreContext(DbContextOptions<EjercitoStoreContext> options) : base(options)
        {
        }
        public DbSet<Ejercito> Ejercitos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Ejercito>().OwnsOne(x => x.Ubicacion);
        }

    }
}

/*
 * 
 */
