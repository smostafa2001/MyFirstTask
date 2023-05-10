using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mostafa.Domain.Entities.Factors;

namespace Mostafa.Persistence.Mappings;
public class FactorMapping : IEntityTypeConfiguration<Factor>
{
    public void Configure(EntityTypeBuilder<Factor> builder)
    {
        builder.OwnsMany(factor => factor.FactorItems, navBuilder =>
        {
            navBuilder.ToTable("FactorItems");
            navBuilder.HasKey(item => item.Id);
            navBuilder.WithOwner(item => item.Factor).HasForeignKey(item => item.FactorId);
        });
    }
}
