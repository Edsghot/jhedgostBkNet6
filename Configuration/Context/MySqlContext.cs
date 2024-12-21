using System;
using jhedgostBK.Configuration.DataBase.EntityConfigurations;
using jhedgostBK.Modules.User.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace jhedgostBK.Configuration.DataBase
{
    public class MySqlContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=jhedgost.com;Database=dbjhfjuv_jhedgostApi;User=dbjhfjuv_edsghot;Password=Repro321.;";

            optionsBuilder.UseMySql(
                connectionString,
                new MySqlServerVersion(new Version(8, 0, 21))
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
        }


    }
}
