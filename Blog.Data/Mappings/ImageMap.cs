using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {

                    
               Id = Guid.Parse("DD19EB03-77DD-474C-9F2B-7FDD809C3B43"),
                FileName = "images/testImage",
               FileType = "png",
               CreatedBy = "Admin test",
               CreatedDate = DateTime.Now,
               IsDeleted = false
                  

            },
            new Image
            {
                Id = Guid.Parse("2BF61FDB-43AA-4E7F-A46E-6884E514C31D"),
                FileName = "images/testImage",
                FileType = "png",
                CreatedBy = "Admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            });
        }
    }
}
