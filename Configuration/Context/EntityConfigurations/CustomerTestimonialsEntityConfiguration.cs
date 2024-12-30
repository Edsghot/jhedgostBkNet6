using jhedgostBK.Modules.CustomerTestimonials.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace jhedgostBK.Configuration.DataBase.EntityConfigurations;

public class CustomerTestimonialsEntityConfiguration : IEntityTypeConfiguration<CustomerTestimonialsEntity>
{
    public void Configure(EntityTypeBuilder<CustomerTestimonialsEntity> builder)
    {
        builder.ToTable("CustomerTestimonials");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.FirstName).HasMaxLength(100).IsRequired();
        builder.Property(x => x.LastName).HasMaxLength(300).IsRequired();
        builder.Property(x => x.Message).HasMaxLength(800).IsRequired();
        builder.Property(x=> x.Occupation).HasMaxLength(250).IsRequired();
    }
}