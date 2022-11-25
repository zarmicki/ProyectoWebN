using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoWebN.Data.Entity;
using System.Collections.Generic;

namespace ProyectoWebN.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Country> Countres { set; get; }

        public DbSet<Product> Products { set; get; }

        public DbSet<City> cities { set; get; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }




    }
}
