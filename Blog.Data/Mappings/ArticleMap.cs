using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Blog.Data.Mappings
{
    internal class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
                builder.HasData(new Article
                {
                    Id = Guid.NewGuid(),
                    Title = "Title",
                    Content = "LOREM ASADASD DASASDADS SDASDA  SA DAS  S DAS  DSA DSADSADSAASD D SA DSA D AS DSA DSA D A DSA SASDA SD A SDA DAS SA DSA DSA SDA D SA ASD SA SDA  DAD AS SA DSA DSA D SA SDA",
                    ViewCount = 15,
                    CategoryId = Guid.Parse("1D72B1BF-8991-4C6F-8FC3-F12571B85D8D"),
                    ImageId = Guid.Parse("DD19EB03-77DD-474C-9F2B-7FDD809C3B43"),
                    CreatedBy = "Admin test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Article
                {
                    Id = Guid.NewGuid(),
                    Title = "2Title",
                    Content = "2.buLOREM ASADASD DASASDADS SDASDA  SA DAS  S DAS  DSA DSADSADSAASD D SA DSA D AS DSA DSA D A DSA SASDA SD A SDA DAS SA DSA DSA SDA D SA ASD SA SDA  DAD AS SA DSA DSA D SA SDA",
                    ViewCount = 15,
                    CategoryId = Guid.Parse("9A6C0A2E-7065-46B4-BBBD-186D04CA9E06"),
                    ImageId= Guid.Parse("2BF61FDB-43AA-4E7F-A46E-6884E514C31D"),
                    CreatedBy = "Admin test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                }
            );
        }
    }
}
