using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_shop.Migrations
{
    public partial class AddInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CostPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    RetailPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MinimumStockLevel = table.Column<int>(type: "int", nullable: true),
                    SupplierId = table.Column<int>(type: "int", nullable: true),
                    Weight = table.Column<float>(type: "real", nullable: true),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipientName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deliveries_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasketId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    RetailPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketItems_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryItems_Deliveries_DeliveryId",
                        column: x => x.DeliveryId,
                        principalTable: "Deliveries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeliveryItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, "Kategorija svježeg voća", true, "Voće" },
                    { 2, "Kategorija svježeg povrća", true, "Povrće" },
                    { 3, "Kategorija svježeg mesa", true, "Meso" },
                    { 4, "Kategorija svježe ribe", true, "Riba" },
                    { 5, "Kategorija negaziranih pića", true, "Sok" },
                    { 6, "Kategorija sladoleda", true, "Sladoled" },
                    { 7, "Kategorija namještaja za domaćinstvo", true, "Namještaj" },
                    { 8, "Kategorija igračaka", true, "Igračke" },
                    { 9, "Kategorija mliječnih proizvoda", true, "Mliječni proizvodi" },
                    { 10, "Kategorija kruha i peciva", true, "Kruh i pecivo" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Administrator" },
                    { 2, "Korisnik" },
                    { 3, "Kupac" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "Email", "IsActive", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Ulica Voćnjaka 123", "kontakt@svjezevoce.hr", true, "Svježe Voće d.o.o.", "123-456-7890" },
                    { 2, "Put Farme 456", "info@zelenepovrtnice.hr", true, "Zelene Povrtnice d.d.", "234-567-8901" },
                    { 3, "Obalna Cesta 789", "prodaja@oceanikribe.hr", true, "Oceanik Ribe", "345-678-9012" },
                    { 4, "Mliječna Staza 101", "podrska@mlijecniuzici.hr", true, "Mliječni Užici", "456-789-0123" },
                    { 5, "Ledena Avenija 202", "narudzbe@smrznuteposlastice.hr", true, "Smrznute Poslastice d.o.o.", "567-890-1234" },
                    { 6, "Ulica Kruha 303", "zdravo@pekarskiraj.hr", true, "Pekarski Raj", "678-901-2345" },
                    { 7, "Ulica Udobnosti 404", "kontakt@namjestajzadom.hr", true, "Namještaj za Dom d.o.o.", "789-012-3456" },
                    { 8, "Avenija Igranja 505", "info@svijetigracaka.hr", true, "Svijet Igračaka", "890-123-4567" },
                    { 9, "Cesta Steka 606", "prodaja@gurmanskimesari.hr", true, "Gurmanski Mesari", "901-234-5678" },
                    { 10, "Put Jogurta 707", "podrska@prirodnijogurti.hr", true, "Prirodni Jogurti", "012-345-6789" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CostPrice", "Description", "Dimensions", "ExpirationDate", "IsActive", "MinimumStockLevel", "Name", "Quantity", "RetailPrice", "SupplierId", "Weight" },
                values: new object[,]
                {
                    { 1, 1, 0.79m, "Svježe zelene jabuke 1kg", "10x10x10", new DateTime(2024, 7, 28, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2039), true, 20, "Jabuka", 100, 1.50m, 1, 1f },
                    { 2, 2, 0.60m, "Krumpiri za pečenje rinfuza 1kg", "15x15x15", new DateTime(2024, 7, 18, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2049), true, 50, "Krumpir", 200, 1.00m, 2, 1f },
                    { 3, 4, 10.00m, "Svježi losos za gurmanske užitke 1kg", "30x10x5", new DateTime(2024, 7, 5, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2051), true, 10, "Svježi losos", 50, 15.00m, 3, 1f },
                    { 4, 1, 1.00m, "Svježe žute banane 1kg", "20x15x10", new DateTime(2024, 7, 8, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2053), true, 30, "Banana", 150, 2.00m, 1, 1f },
                    { 5, 1, 1.20m, "Svježe naranče za sok 1kg", "20x20x15", new DateTime(2024, 7, 13, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2055), true, 25, "Naranča", 120, 2.50m, 1, 1f },
                    { 6, 2, 0.80m, "Svježe rajčice 1kg", "10x10x10", new DateTime(2024, 7, 5, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2057), true, 40, "Rajčica", 180, 1.60m, 2, 1f },
                    { 7, 2, 0.50m, "Zelena salata 1 komad", "5x5x5", new DateTime(2024, 7, 3, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2058), true, 50, "Zelena salata", 200, 1.00m, 2, 0.3f },
                    { 8, 3, 3.00m, "Svježa piletina 1kg", "30x20x10", new DateTime(2024, 7, 5, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2060), true, 20, "Piletina", 90, 6.00m, 3, 1f },
                    { 9, 3, 4.00m, "Svježa junetina za gulaš 1kg", "30x20x10", new DateTime(2024, 7, 8, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2062), true, 15, "Junetina", 70, 8.00m, 3, 1f },
                    { 10, 3, 3.50m, "Svježa svinjetina za pečenje 1kg", "30x20x10", new DateTime(2024, 7, 8, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2064), true, 20, "Svinjetina", 80, 7.00m, 3, 1f },
                    { 11, 9, 0.50m, "Svježe mlijeko 1L", "10x10x10", new DateTime(2024, 7, 3, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2066), true, 20, "Mlijeko", 100, 1.00m, 4, 1f },
                    { 12, 9, 0.70m, "Jogurt 1L", "10x10x10", new DateTime(2024, 7, 3, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2069), true, 20, "Jogurt", 100, 1.50m, 4, 1f },
                    { 13, 9, 0.50m, "Kefir 1kg", "10x10x10", new DateTime(2024, 7, 3, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2071), true, 20, "Kefir", 20, 1.00m, 4, 1f },
                    { 14, 6, 2.00m, "Sladoled od vanilije 1L", "10x10x10", new DateTime(2024, 7, 28, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2075), true, 10, "Sladoled", 50, 3.00m, 5, 1f },
                    { 15, 10, 0.50m, "Kruh od bijelog brašna 0,7kg", "10x10x10", new DateTime(2024, 6, 29, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2086), true, 20, "Kruh", 100, 1.00m, 6, 0.7f },
                    { 16, 10, 0.20m, "Pecivo sa sirom 0,2kg", "10x10x10", new DateTime(2024, 6, 29, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2087), true, 20, "Pecivo", 100, 0.50m, 6, 0.2f },
                    { 17, 10, 0.7m, "Kruh sa suncokretovim i bučinim sjemenkama 0,4kg", "10x10x10", new DateTime(2024, 6, 29, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2090), true, 10, "Kruh sa sjemenkama", 100, 2.10m, 7, 0.4f },
                    { 18, 4, 5.00m, "Svježi brancin, idealan za pečenje, 1kg", "25x15x5", new DateTime(2024, 7, 3, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2092), true, 15, "Brancin", 60, 10.00m, 4, 1f },
                    { 19, 4, 4.50m, "Svježa pastrva, odlična za roštilj, 1kg", "20x10x5", new DateTime(2024, 7, 3, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2093), true, 10, "Pastrva", 50, 9.00m, 4, 0.8f },
                    { 20, 5, 0.80m, "Prirodni jabučni sok bez dodanog šećera 1l", "10x10x30", new DateTime(2024, 9, 26, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2094), true, 20, "Jabučni sok", 100, 1.60m, 5, 1f },
                    { 21, 5, 0.90m, "100% prirodni narančin sok 1l", "10x10x30", new DateTime(2024, 9, 26, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2096), true, 20, "Narančin sok", 100, 1.80m, 5, 1f },
                    { 22, 5, 1.00m, "Sok od grejpa bez dodatka šećera 1l", "10x10x30", new DateTime(2024, 9, 26, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2099), true, 20, "Sok od grejpa", 100, 2.00m, 5, 1f },
                    { 23, 6, 2.50m, "Bogati čokoladni sladoled s komadićima čokolade 1L", "10x10x10", new DateTime(2024, 12, 25, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2103), true, 15, "Čokoladni sladoled", 80, 4.00m, 5, 1f },
                    { 24, 6, 2.00m, "Osvežavajući sladoled od jagode 1L", "10x10x10", new DateTime(2024, 12, 25, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2104), true, 15, "Jagoda sladoled", 80, 3.50m, 5, 1f },
                    { 25, 7, 20.00m, "Drveni noćni ormarić s ladicom", "40x40x60", new DateTime(2025, 6, 28, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2106), true, 5, "Noćni ormarić", 30, 40.00m, 8, 5f },
                    { 26, 7, 30.00m, "Moderan stolić za kavu od masivnog drva", "90x50x45", new DateTime(2025, 6, 28, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2107), true, 3, "Stolić za kavu", 20, 60.00m, 8, 7f },
                    { 27, 7, 15.00m, "Plutena zidna polica za knjige i dekoracije", "100x20x20", new DateTime(2025, 6, 28, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2113), true, 10, "Zidna polica", 50, 30.00m, 8, 3f },
                    { 28, 8, 20.00m, "Kreativni Lego set za djecu", "30x20x10", new DateTime(2025, 6, 28, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2115), true, 10, "Lego set", 50, 40.00m, 9, 0.5f },
                    { 29, 8, 15.00m, "Zabavna društvena igra za cijelu obitelj", "40x25x5", new DateTime(2025, 6, 28, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2116), true, 5, "Društvena igra", 40, 30.00m, 9, 1f },
                    { 30, 8, 10.00m, "Mekani plišani medvjedić, idealan za poklon", "15x15x25", new DateTime(2025, 6, 28, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2123), true, 15, "Plush medvjedić", 60, 20.00m, 9, 0.2f },
                    { 31, 9, 0.90m, "Prirodni jogurt bez dodataka, 1L", "10x10x15", new DateTime(2024, 7, 18, 2, 1, 27, 273, DateTimeKind.Utc).AddTicks(2134), true, 20, "Jogurt", 100, 1.80m, 10, 1f }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Email", "IsActive", "Name", "PasswordHash", "PasswordSalt", "RoleId", "Surname", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(1987, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "mmatic@mail.hr", true, "Mate", "$2a$11$fOdyG76UzUn/YC0.G2eDfutwgQv37XehMSsS0hwqUUPJLfm3wWe9y", "$2a$11$fOdyG76UzUn/YC0.G2eDfu", 2, "Matić", "mmatic" },
                    { 2, new DateTime(1983, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "iivic@mail.hr", true, "Ivo", "$2a$11$G3P5ADka.mwD6orjGqUAve8EGYF7cd3nzEFrNEE2MJ2.Pd5U6Ge2C", "$2a$11$G3P5ADka.mwD6orjGqUAve", 3, "Ivić", "iivic" },
                    { 3, new DateTime(1911, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sysadm@mail.hr", true, "Sys", "$2a$11$4FZlPUdVaMms72CIBo4soe9BuIx8jUpa4s2YV4ik8aO2mHsnwiBY2", "$2a$11$4FZlPUdVaMms72CIBo4soe", 1, "Adm", "sa" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_BasketId",
                table: "BasketItems",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ProductId",
                table: "BasketItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_UserId",
                table: "Deliveries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryItems_DeliveryId",
                table: "DeliveryItems",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryItems_ProductId",
                table: "DeliveryItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropTable(
                name: "DeliveryItems");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
