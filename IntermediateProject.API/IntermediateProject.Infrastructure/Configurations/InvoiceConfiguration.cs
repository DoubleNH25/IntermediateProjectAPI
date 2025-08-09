﻿
using IntermediateProject.Domain.Entities.Invoices;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using IntermediateProject.Domain.Entities.Invoices.ValueObjects;
using IntermediateProject.Domain.Entities.Shared;

namespace IntermediateProject.Infrastructure.Configurations
{
	public class InvoiceConfigurations : IEntityTypeConfiguration<Invoice>
	{
		public void Configure(EntityTypeBuilder<Invoice> builder)
		{
			builder.Property(invoice => invoice.PoNumber)
			   .HasConversion(
				   poNumber => poNumber.Value,
				   value => new PoNumber(value))
			   .IsRequired()
			   .HasMaxLength(45);

			builder.Property(invoice => invoice.TotalBalance)
				.HasConversion(
					totalBalance => totalBalance.Value,
					value => new Money(value))
				.IsRequired()
				.HasPrecision(18, 2);

			builder.HasMany(invoice => invoice.PurchasedProducts)
				.WithOne(x => x.Invoice)
				.HasForeignKey(x => x.InvoiceId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.Property(x => x.RowVersion)
			   .IsRowVersion();
		}
	}

}
