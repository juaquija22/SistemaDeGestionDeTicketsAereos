using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeGestionDeTicketsAereos.src.modules.airport.Infrastructure.Entity;

namespace SistemaDeGestionDeTicketsAereos.src.modules.route.Infrastructure.Entity;

public sealed class RouteEntityConfiguration : IEntityTypeConfiguration<RouteEntity>
{
    public void Configure(EntityTypeBuilder<RouteEntity> builder)
    {
        builder.ToTable("Route");

        builder.HasKey(x => x.IdRoute);

        builder.Property(x => x.IdRoute)
            .HasColumnName("IdRoute")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.OriginAirport)
            .HasColumnName("OriginAirport")
            .IsRequired();

        builder.Property(x => x.DestinationAirport)
            .HasColumnName("DestinationAirport")
            .IsRequired();

        builder.Property(x => x.DistanceKm)
            .HasColumnName("DistanceKm")
            .HasColumnType("decimal(10,2)")
            .IsRequired();

        builder.Property(x => x.EstDuration)
            .HasColumnName("EstDuration")
            .IsRequired();

        builder.Property(x => x.Active)
            .HasColumnName("Active")
            .HasColumnType("tinyint(1)")
            .HasDefaultValue(true)
            .IsRequired();

        builder.HasOne(x => x.OriginAirportNavigation)
            .WithMany()
            .HasForeignKey(x => x.OriginAirport)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.DestinationAirportNavigation)
            .WithMany()
            .HasForeignKey(x => x.DestinationAirport)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
