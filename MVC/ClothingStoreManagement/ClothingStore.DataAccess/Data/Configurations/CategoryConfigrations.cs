 

namespace ClothingStore.DataAccess.Data.Configurations
{
    class CategoryConfigrations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(C => C.Id).UseIdentityColumn(1, 1);
            builder.Property(C => C.Name).HasColumnType("varchar(30)").IsRequired();
            builder.Property(C => C.Description).HasColumnType("varchar(150)");
            builder.Property(C => C.Name).IsRequired();
        }
    }
}
