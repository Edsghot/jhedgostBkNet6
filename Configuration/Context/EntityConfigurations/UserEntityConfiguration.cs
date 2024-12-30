using jhedgostBK.Modules.User.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace jhedgostBK.Configuration.DataBase.EntityConfigurations;

public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
{
   public void Configure(EntityTypeBuilder<UserEntity> builder) {
      builder.ToTable("User");
      builder.HasKey(u => u.Id); 

      builder.Property(u => u.FirstName)
         .HasMaxLength(100)
         .IsRequired(); 
      builder.Property(u => u.LastName).HasMaxLength(300).IsRequired();
      builder.Property(u => u.Email).HasMaxLength(100).IsRequired();
      builder.Property(u => u.Password).HasMaxLength(100).IsRequired();
      builder.Property(u => u.PhoneNumber).HasMaxLength(100).IsRequired();
      builder.Property(u => u.Gender).HasMaxLength(100).IsRequired();
      builder.Property(u => u.BirthDate).IsRequired();
      builder.Property(u => u.Years).IsRequired();



   }
}