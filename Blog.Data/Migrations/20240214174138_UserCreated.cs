using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class UserCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2406a5e4-d761-46d8-836c-94fd0fa2caf6"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("57e6f037-7f2f-478d-a42f-9619e306bcd9"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("8a980557-2d20-4086-bbd8-953a38952dd1"), new Guid("1d72b1bf-8991-4c6f-8fc3-f12571b85d8d"), "LOREM ASADASD DASASDADS SDASDA  SA DAS  S DAS  DSA DSADSADSAASD D SA DSA D AS DSA DSA D A DSA SASDA SD A SDA DAS SA DSA DSA SDA D SA ASD SA SDA  DAD AS SA DSA DSA D SA SDA", "Admin test", new DateTime(2024, 2, 14, 20, 41, 37, 800, DateTimeKind.Local).AddTicks(4427), null, null, new Guid("dd19eb03-77dd-474c-9f2b-7fdd809c3b43"), false, null, null, "Title", 15 },
                    { new Guid("bf176a19-1738-45c9-ba10-0f7100eea2f2"), new Guid("9a6c0a2e-7065-46b4-bbbd-186d04ca9e06"), "2.buLOREM ASADASD DASASDADS SDASDA  SA DAS  S DAS  DSA DSADSADSAASD D SA DSA D AS DSA DSA D A DSA SASDA SD A SDA DAS SA DSA DSA SDA D SA ASD SA SDA  DAD AS SA DSA DSA D SA SDA", "Admin test", new DateTime(2024, 2, 14, 20, 41, 37, 800, DateTimeKind.Local).AddTicks(4438), null, null, new Guid("2bf61fdb-43aa-4e7f-a46e-6884e514c31d"), false, null, null, "2Title", 15 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("33a5ca12-9dfb-4240-b57e-ee95cc5fe0fb"), "0262516a-4006-473e-8ce4-7f3884c80361", "Admin", "ADMIN" },
                    { new Guid("78ad0677-ddb9-41d9-b3f1-ab5376b3818c"), "e3927789-77c9-4747-84fe-1355bf51839c", "User", "USER" },
                    { new Guid("8b660cda-c909-4a04-9271-a74e2de5de83"), "b72d121f-d257-4770-8ff4-77463c17ce31", "Superadmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3ff64dea-2802-41e7-a601-e1ad9a2dd4c2"), 0, "190757a8-f5d6-4a0b-85c9-a37a269b8d91", "admin@gmail.com", false, "Admin", "User", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEFLCJp3DHH1geFAz9bKI5CqauJfr0OAdJ3P28/FdAbTNMjIo/Nm4i/dpNsBn5esOaw==", "+905439999988", false, "6e1d8a90-0bbd-4160-b998-e69adbfee4c2", false, "admin@gmail.com" },
                    { new Guid("d388cc9a-b0aa-4dda-aa73-7135ab43ba9a"), 0, "3f2c2c76-145a-44ce-bec3-d745212a53ad", "superadmin@gmail.com", true, "Talha", "Sarı", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEBLj9NBS5OHIg9OXSjaLYR+nS8ib25Vi5RHYiH6dGp44Hy1onthsTPGntCTRHa4Frg==", "+905439999999", true, "5b6d6c77-3174-4f33-b5ae-294a68a11f68", false, "superadmin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d72b1bf-8991-4c6f-8fc3-f12571b85d8d"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 14, 20, 41, 37, 800, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a6c0a2e-7065-46b4-bbbd-186d04ca9e06"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 14, 20, 41, 37, 800, DateTimeKind.Local).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2bf61fdb-43aa-4e7f-a46e-6884e514c31d"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 14, 20, 41, 37, 800, DateTimeKind.Local).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("dd19eb03-77dd-474c-9f2b-7fdd809c3b43"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 14, 20, 41, 37, 800, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("33a5ca12-9dfb-4240-b57e-ee95cc5fe0fb"), new Guid("3ff64dea-2802-41e7-a601-e1ad9a2dd4c2") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8b660cda-c909-4a04-9271-a74e2de5de83"), new Guid("d388cc9a-b0aa-4dda-aa73-7135ab43ba9a") });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8a980557-2d20-4086-bbd8-953a38952dd1"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("bf176a19-1738-45c9-ba10-0f7100eea2f2"));

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
    }
}
