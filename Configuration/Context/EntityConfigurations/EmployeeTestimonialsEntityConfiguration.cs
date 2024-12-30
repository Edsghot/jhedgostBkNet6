using jhedgostBK.Modules.EmployeeTestimonials.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace jhedgostBK.Configuration.DataBase.EntityConfigurations;

public class EmployeeTestimonialsEntityConfiguration : IEntityTypeConfiguration<EmployeeTestimonialsEntity>
{

    public void Configure(EntityTypeBuilder<EmployeeTestimonialsEntity> builder)
    {
        builder.ToTable("EmployeeTestimonials");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.FirstName).HasMaxLength(100).IsRequired();
        builder.Property(x => x.LastName).HasMaxLength(300).IsRequired();
        builder.Property(x => x.Message).HasMaxLength(800).IsRequired();
        builder.Property(x => x.Occupation).HasMaxLength(250).IsRequired();
    }
}