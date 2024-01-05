﻿// <auto-generated />
using System;
using Blog.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Blog.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0a69056e-885c-4824-b7c3-14771705303c"),
                            CategoryId = new Guid("1d72b1bf-8991-4c6f-8fc3-f12571b85d8d"),
                            Content = "LOREM ASADASD DASASDADS SDASDA  SA DAS  S DAS  DSA DSADSADSAASD D SA DSA D AS DSA DSA D A DSA SASDA SD A SDA DAS SA DSA DSA SDA D SA ASD SA SDA  DAD AS SA DSA DSA D SA SDA",
                            CreatedBy = "Admin test",
                            CreatedDate = new DateTime(2024, 1, 5, 18, 50, 58, 133, DateTimeKind.Local).AddTicks(3747),
                            ImageId = new Guid("dd19eb03-77dd-474c-9f2b-7fdd809c3b43"),
                            IsDeleted = false,
                            Title = "Title",
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("2bbdf1fe-b72a-4507-8711-d34b8e6114bf"),
                            CategoryId = new Guid("9a6c0a2e-7065-46b4-bbbd-186d04ca9e06"),
                            Content = "2.buLOREM ASADASD DASASDADS SDASDA  SA DAS  S DAS  DSA DSADSADSAASD D SA DSA D AS DSA DSA D A DSA SASDA SD A SDA DAS SA DSA DSA SDA D SA ASD SA SDA  DAD AS SA DSA DSA D SA SDA",
                            CreatedBy = "Admin test",
                            CreatedDate = new DateTime(2024, 1, 5, 18, 50, 58, 133, DateTimeKind.Local).AddTicks(3755),
                            ImageId = new Guid("2bf61fdb-43aa-4e7f-a46e-6884e514c31d"),
                            IsDeleted = false,
                            Title = "2Title",
                            ViewCount = 15
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1d72b1bf-8991-4c6f-8fc3-f12571b85d8d"),
                            CreatedBy = "Admin test",
                            CreatedDate = new DateTime(2024, 1, 5, 18, 50, 58, 133, DateTimeKind.Local).AddTicks(3958),
                            IsDeleted = false,
                            Name = "Tştle"
                        },
                        new
                        {
                            Id = new Guid("9a6c0a2e-7065-46b4-bbbd-186d04ca9e06"),
                            CreatedBy = "Admin test",
                            CreatedDate = new DateTime(2024, 1, 5, 18, 50, 58, 133, DateTimeKind.Local).AddTicks(3960),
                            IsDeleted = false,
                            Name = "Tştle"
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dd19eb03-77dd-474c-9f2b-7fdd809c3b43"),
                            CreatedBy = "Admin test",
                            CreatedDate = new DateTime(2024, 1, 5, 18, 50, 58, 133, DateTimeKind.Local).AddTicks(4083),
                            FileName = "images/testImage",
                            FileType = "png",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("2bf61fdb-43aa-4e7f-a46e-6884e514c31d"),
                            CreatedBy = "Admin test",
                            CreatedDate = new DateTime(2024, 1, 5, 18, 50, 58, 133, DateTimeKind.Local).AddTicks(4100),
                            FileName = "images/testImage",
                            FileType = "png",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Article", b =>
                {
                    b.HasOne("Blog.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("Blog.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Blog.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
