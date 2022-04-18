using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApi.Entities.EntityConfiguration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x =>x.Name).HasColumnName("name").HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(x =>x.Description).HasColumnName("description").HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(x =>x.CreatedBy).HasColumnName("created_by").HasColumnType("VARCHAR(50)").HasMaxLength(50);
            builder.Property(x =>x.CreatedOn).HasColumnName("created_on").HasColumnType("DATETIME");
            builder.Property(x =>x.UpdatedBy).HasColumnName("updated_by").HasColumnType("VARCHAR(50)").HasMaxLength(50);
            builder.Property(x =>x.UpdatedOn).HasColumnName("updated_on").HasColumnType("DATETIME");

    }
}
}