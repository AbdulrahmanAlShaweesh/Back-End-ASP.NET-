
namespace ClothingStore.DataAccess.Data.Configurations
{
    class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(P => P.Id).UseIdentityColumn(1, 1);
            builder.Property(P => P.Name).HasColumnType("varchar(50)").IsRequired();
            builder.Property(P => P.BrandName).IsRequired().HasMaxLength(50);
            builder.Property(P => P.DiscountPrice).HasColumnType("decimal(18,2)");
            builder.Property(P => P.Rating).HasDefaultValue(0);
            builder.Property(P => P.IsAvailable).IsRequired();
            builder.Property(P => P.ImageUrl).IsRequired();
            builder.Property(P => P.StockQuantity).HasDefaultValue(0);
            builder.Property(P => P.CreatedOn).HasDefaultValueSql("GETDATE()");
            builder.Property(P => P.LastModifiedOn).HasComputedColumnSql("GETDATE()");
        }
    }
}

