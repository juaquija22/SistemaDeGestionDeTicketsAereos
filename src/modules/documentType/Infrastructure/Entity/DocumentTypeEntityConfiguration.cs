using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaDeGestionDeTicketsAereos.src.modules.documentType.Infrastructure.Entity;

public sealed class DocumentTypeEntityConfiguration : IEntityTypeConfiguration<DocumentTypeEntity>
{
    public void Configure(EntityTypeBuilder<DocumentTypeEntity> builder)
    {
        builder.ToTable("DocumentType");

        builder.HasKey(x => x.IdDocumentType);

        builder.Property(x => x.IdDocumentType)
            .HasColumnName("IdDocumentType")
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .HasColumnType("varchar(50)")
            .IsRequired();
    }
}
