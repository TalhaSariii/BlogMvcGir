using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("D388CC9A-B0AA-4DDA-AA73-7135AB43BA9A"),
                RoleId= Guid.Parse("8B660CDA-C909-4A04-9271-A74E2DE5DE83"),
            }, 
            new AppUserRole
            {
                UserId= Guid.Parse("3FF64DEA-2802-41E7-A601-E1AD9A2DD4C2"),
                RoleId = Guid.Parse("33A5CA12-9DFB-4240-B57E-EE95CC5FE0FB")

            });
        }
    }
}
