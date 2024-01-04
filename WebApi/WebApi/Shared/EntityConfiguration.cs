using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HireMe.WebApi.Shared;

public abstract class EntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
    where TEntity : Entity
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder
            .Property(entity => entity.CreatedAt)
            .HasDefaultValueSql("now()")
            .ValueGeneratedOnAdd();
        builder
            .Property(entity => entity.ModifiedAt)
            .HasDefaultValueSql("now()")
            .ValueGeneratedOnUpdate();
    }
}
