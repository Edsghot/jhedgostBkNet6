using jhedgostBK.Modules.Team.Domain;
using jhedgostBK.Modules.User.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace jhedgostBK.Configuration.DataBase.EntityConfigurations;

public class TeamEntityConfiguration: IEntityTypeConfiguration<TeamEntity>
{
    public void Configure(EntityTypeBuilder<TeamEntity> builder) {
        builder.ToTable("Team");
        builder.HasKey(u => u.Id); 

        builder.Property(u => u.FirstName)
            .HasMaxLength(100)
            .IsRequired(); 
        builder.Property(u => u.LastName).HasMaxLength(300).IsRequired();
        builder.Property(u => u.ProfilePictureUrl).HasMaxLength(600).IsRequired();
        builder.Property(u => u.ExperienceYears).IsRequired();
        builder.Property(u => u.Position).HasMaxLength(200).IsRequired();
        builder.Property(u => u.LinkedInUrl).HasMaxLength(600).IsRequired();
        builder.Property(u => u.GitHubUrl).HasMaxLength(600).IsRequired();
        builder.Property(u => u.InstagramUrl).HasMaxLength(600).IsRequired();



    }
    
}