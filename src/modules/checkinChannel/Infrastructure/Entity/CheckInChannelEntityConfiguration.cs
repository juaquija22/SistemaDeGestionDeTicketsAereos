using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaDeGestionDeTicketsAereos.src.modules.checkinChannel.Infrastructure.Entity;

public sealed class CheckInChannelEntityConfiguration : IEntityTypeConfiguration<CheckInChannelEntity>
{
    public void Configure(EntityTypeBuilder<CheckInChannelEntity> builder)
    {
        builder.ToTable("CheckInChannel");

        builder.HasKey(x => x.IdChannel);

        builder.Property(x => x.IdChannel)
            .HasColumnName("IdChannel")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.ChannelName)
            .HasColumnName("ChannelName")
            .HasColumnType("varchar(50)")
            .IsRequired();
    }
}
