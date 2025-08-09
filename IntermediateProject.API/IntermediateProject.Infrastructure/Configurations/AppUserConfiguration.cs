using IntermediateProject.Domain.Entities.Identity.Users;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace IntermediateProject.Infrastructure.Configurations
{
	public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
	{
		public void Configure(EntityTypeBuilder<AppUser> builder)
		{
			builder.Property(x => x.Fullname)
				 .IsRequired()
				 .HasMaxLength(25);
		}
	}
}
