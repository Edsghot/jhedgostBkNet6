using System;
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
            // Cambié el nombre de la tabla a 'User'
            modelBuilder.Entity<UserEntity>().ToTable("User");

            // Aquí definimos que la clave primaria es 'Id'
            modelBuilder.Entity<UserEntity>().HasKey(u => u.Id);

            modelBuilder.Entity<UserEntity>()
                .Property(u => u.Name)
                .HasMaxLength(50)
                .IsRequired(); // Ejemplo de cómo configurar propiedades de la entidad
        }


    }
}
