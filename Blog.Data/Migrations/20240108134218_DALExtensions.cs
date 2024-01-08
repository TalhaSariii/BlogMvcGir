using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class DALExtensions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0a69056e-885c-4824-b7c3-14771705303c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2bbdf1fe-b72a-4507-8711-d34b8e6114bf"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("2406a5e4-d761-46d8-836c-94fd0fa2caf6"), new Guid("1d72b1bf-8991-4c6f-8fc3-f12571b85d8d"), "LOREM ASADASD DASASDADS SDASDA  SA DAS  S DAS  DSA DSADSADSAASD D SA DSA D AS DSA DSA D A DSA SASDA SD A SDA DAS SA DSA DSA SDA D SA ASD SA SDA  DAD AS SA DSA DSA D SA SDA", "Admin test", new DateTime(2024, 1, 8, 16, 42, 18, 362, DateTimeKind.Local).AddTicks(4372), null, null, new Guid("dd19eb03-77dd-474c-9f2b-7fdd809c3b43"), false, null, null, "Title", 15 },
                    { new Guid("57e6f037-7f2f-478d-a42f-9619e306bcd9"), new Guid("9a6c0a2e-7065-46b4-bbbd-186d04ca9e06"), "2.buLOREM ASADASD DASASDADS SDASDA  SA DAS  S DAS  DSA DSADSADSAASD D SA DSA D AS DSA DSA D A DSA SASDA SD A SDA DAS SA DSA DSA SDA D SA ASD SA SDA  DAD AS SA DSA DSA D SA SDA", "Admin test", new DateTime(2024, 1, 8, 16, 42, 18, 362, DateTimeKind.Local).AddTicks(4398), null, null, new Guid("2bf61fdb-43aa-4e7f-a46e-6884e514c31d"), false, null, null, "2Title", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d72b1bf-8991-4c6f-8fc3-f12571b85d8d"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 8, 16, 42, 18, 362, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a6c0a2e-7065-46b4-bbbd-186d04ca9e06"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 8, 16, 42, 18, 362, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2bf61fdb-43aa-4e7f-a46e-6884e514c31d"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 8, 16, 42, 18, 362, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("dd19eb03-77dd-474c-9f2b-7fdd809c3b43"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 8, 16, 42, 18, 362, DateTimeKind.Local).AddTicks(4889));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2406a5e4-d761-46d8-836c-94fd0fa2caf6"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("57e6f037-7f2f-478d-a42f-9619e306bcd9"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("0a69056e-885c-4824-b7c3-14771705303c"), new Guid("1d72b1bf-8991-4c6f-8fc3-f12571b85d8d"), "LOREM ASADASD DASASDADS SDASDA  SA DAS  S DAS  DSA DSADSADSAASD D SA DSA D AS DSA DSA D A DSA SASDA SD A SDA DAS SA DSA DSA SDA D SA ASD SA SDA  DAD AS SA DSA DSA D SA SDA", "Admin test", new DateTime(2024, 1, 5, 18, 50, 58, 133, DateTimeKind.Local).AddTicks(3747), null, null, new Guid("dd19eb03-77dd-474c-9f2b-7fdd809c3b43"), false, null, null, "Title", 15 },
                    { new Guid("2bbdf1fe-b72a-4507-8711-d34b8e6114bf"), new Guid("9a6c0a2e-7065-46b4-bbbd-186d04ca9e06"), "2.buLOREM ASADASD DASASDADS SDASDA  SA DAS  S DAS  DSA DSADSADSAASD D SA DSA D AS DSA DSA D A DSA SASDA SD A SDA DAS SA DSA DSA SDA D SA ASD SA SDA  DAD AS SA DSA DSA D SA SDA", "Admin test", new DateTime(2024, 1, 5, 18, 50, 58, 133, DateTimeKind.Local).AddTicks(3755), null, null, new Guid("2bf61fdb-43aa-4e7f-a46e-6884e514c31d"), false, null, null, "2Title", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d72b1bf-8991-4c6f-8fc3-f12571b85d8d"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 18, 50, 58, 133, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a6c0a2e-7065-46b4-bbbd-186d04ca9e06"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 18, 50, 58, 133, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2bf61fdb-43aa-4e7f-a46e-6884e514c31d"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 18, 50, 58, 133, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("dd19eb03-77dd-474c-9f2b-7fdd809c3b43"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 18, 50, 58, 133, DateTimeKind.Local).AddTicks(4083));
        }
    }
}
