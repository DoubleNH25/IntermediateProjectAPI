using IntermediateProject.Infrastructure.Outbox;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace IntermediateProject.Infrastructure.Configurations
{
	internal sealed class OutboxMessagesConfiguration : IEntityTypeConfiguration<OutboxMessage>
	{
		public void Configure(EntityTypeBuilder<OutboxMessage> builder)
		{
			builder.Property(outboxMessages => outboxMessages.Content)
				.HasColumnType("nvarchar(max)")
				.IsRequired();
		}
	}
}
