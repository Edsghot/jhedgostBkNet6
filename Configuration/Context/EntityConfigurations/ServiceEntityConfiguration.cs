using jhedgostBK.Modules.Services.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace jhedgostBK.Configuration.DataBase.EntityConfigurations;

public class ServiceEntityConfiguration : IEntityTypeConfiguration<ServiceEntity>
{
    public void Configure(EntityTypeBuilder<ServiceEntity> builder)
    {
        builder.ToTable("Service");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(500).IsRequired();
        builder.Property(x => x.Description).HasMaxLength(1000).IsRequired();
    }
}