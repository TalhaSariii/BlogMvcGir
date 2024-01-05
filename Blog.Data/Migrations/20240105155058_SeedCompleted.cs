using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class SeedCompleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("1d72b1bf-8991-4c6f-8fc3-f12571b85d8d"), "Admin test", new DateTime(2024, 1, 5, 18, 50, 58, 133, DateTimeKind.Local).AddTicks(3958), null, null, false, null, null, "Tştle" },
                    { new Guid("9a6c0a2e-7065-46b4-bbbd-186d04ca9e06"), "Admin test", new DateTime(2024, 1, 5, 18, 50, 58, 133, DateTimeKind.Local).AddTicks(3960), null, null, false, null, null, "Tştle" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("2bf61fdb-43aa-4e7f-a46e-6884e514c31d"), "Admin test", new DateTime(2024, 1, 5, 18, 50, 58, 133, DateTimeKind.Local).AddTicks(4100), null, null, "images/testImage", "png", false, null, null },
                    { new Guid("dd19eb03-77dd-474c-9f2b-7fdd809c3b43"), "Admin test", new DateTime(2024, 1, 5, 18, 50, 58, 133, DateTimeKind.Local).AddTicks(4083), null, null, "images/testImage", "png", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("0a69056e-885c-4824-b7c3-14771705303c"), new Guid("1d72b1bf-8991-4c6f-8fc3-f12571b85d8d"), "LOREM ASADASD DASASDADS SDASDA  SA DAS  S DAS  DSA DSADSADSAASD D SA DSA D AS DSA DSA D A DSA SASDA SD A SDA DAS SA DSA DSA SDA D SA ASD SA SDA  DAD AS SA DSA DSA D SA SDA", "Admin test", new DateTime(2024, 1, 5, 18, 50, 58, 133, DateTimeKind.Local).AddTicks(3747), null, null, new Guid("dd19eb03-77dd-474c-9f2b-7fdd809c3b43"), false, null, null, "Title", 15 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("2bbdf1fe-b72a-4507-8711-d34b8e6114bf"), new Guid("9a6c0a2e-7065-46b4-bbbd-186d04ca9e06"), "2.buLOREM ASADASD DASASDADS SDASDA  SA DAS  S DAS  DSA DSADSADSAASD D SA DSA D AS DSA DSA D A DSA SASDA SD A SDA DAS SA DSA DSA SDA D SA ASD SA SDA  DAD AS SA DSA DSA D SA SDA", "Admin test", new DateTime(2024, 1, 5, 18, 50, 58, 133, DateTimeKind.Local).AddTicks(3755), null, null, new Guid("2bf61fdb-43aa-4e7f-a46e-6884e514c31d"), false, null, null, "2Title", 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0a69056e-885c-4824-b7c3-14771705303c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2bbdf1fe-b72a-4507-8711-d34b8e6114bf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d72b1bf-8991-4c6f-8fc3-f12571b85d8d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a6c0a2e-7065-46b4-bbbd-186d04ca9e06"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2bf61fdb-43aa-4e7f-a46e-6884e514c31d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("dd19eb03-77dd-474c-9f2b-7fdd809c3b43"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
