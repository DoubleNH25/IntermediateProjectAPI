using IntermediateProject.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using IntermediateProject.Domain.Entities.Shared;

namespace IntermediateProject.Infrastructure.Configurations
{
	public class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{

			builder.Property(product => product.Description)
				.HasConversion(
					description => description.Value,
					value => new Title(value))
				.IsRequired()
				.HasMaxLength(45);

			builder.Property(product => product.UnitPrice)
				.HasConversion(
					unitPrice => unitPrice.Value,
					value => new Money(value))
				.IsRequired()
				.HasPrecision(18, 2);

			builder.Property(x => x.RowVersion)
			   .IsRowVersion();
		}
	}

}
