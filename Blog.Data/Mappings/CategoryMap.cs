using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("1D72B1BF-8991-4C6F-8FC3-F12571B85D8D"),
                Name = "Tştle",
                CreatedBy = "Admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Category
            {
              
                
                Id = Guid.Parse("9A6C0A2E-7065-46B4-BBBD-186D04CA9E06"),
                Name = "Tştle",
                CreatedBy = "Admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
               

            });
           
        }
    }
}
