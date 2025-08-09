using IntermediateProject.Domain.Entities.InvoiceItems;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using IntermediateProject.Domain.Entities.Shared;
using IntermediateProject.Domain.Entities.InvoiceItems.ValueObjects;

namespace IntermediateProject.Infrastructure.Configurations
{
	public class InvoiceItemConfiguration : IEntityTypeConfiguration<InvoiceItem>
	{
		public void Configure(EntityTypeBuilder<InvoiceItem> builder)
		{
			builder.Property(item => item.SellPrice)
				.HasConversion(
					sellPrice => sellPrice.Value,
					value => new Money(value))
				.IsRequired()
				.HasPrecision(18, 2);

			builder.Property(item => item.TotalPrice)
				.HasConversion(
					totalPrice => totalPrice.Value,
					value => new Money(value))
				.IsRequired()
				.HasPrecision(18, 2);

			builder.Property(item => item.Quantity)
				.HasConversion(
					quantity => quantity.Value,
					value => new Quantity(value))
				.IsRequired();

			builder.Property(x => x.RowVersion)
			   .IsRowVersion();

			builder.Property(item => item.Description)
			   .HasConversion(
				   description => description.Value,
				   value => new Title(value))
			   .IsRequired()
			   .HasMaxLength(45);
		}
	}

}
