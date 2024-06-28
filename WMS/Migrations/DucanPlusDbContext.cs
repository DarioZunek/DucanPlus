using Microsoft.EntityFrameworkCore;

public class DucanPlusDbContext : DbContext
{
    public DucanPlusDbContext(DbContextOptions<DucanPlusDbContext> options)
        : base(options)
    { }

    public DucanPlusDbContext()
     : this(new DbContextOptionsBuilder<DucanPlusDbContext>()
         .UseSqlServer("Server=DESKTOP-J4BLD8F;Database=DucanPlus;User Id=sa;Password=lozinka00;")
         .Options)
    { }

    public DbSet<CategoryEntity>? Categories { get; set; }
    public DbSet<ProductEntity>? Products { get; set; }
    public DbSet<SupplierEntity>? Suppliers { get; set; }
    public DbSet<UserEntity>? Users { get; set; }
    public DbSet<RoleEntity>? Roles { get; set; }
    public DbSet<BasketEntity>? Baskets { get; set; }
    public DbSet<BasketItemEntity>? BasketItems { get; set; }
    public DbSet<DeliveryEntity>? Deliveries { get; set; }
    public DbSet<DeliveryItemEntity>? DeliveryItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ProductEntity>()
            .HasOne(p => p.Category)
            .WithMany()
            .HasForeignKey(p => p.CategoryId);

        modelBuilder.Entity<SupplierEntity>()
           .HasMany(s => s.Products)
           .WithOne(p => p.Supplier)
           .HasForeignKey(p => p.SupplierId);

        modelBuilder.Entity<UserEntity>()
           .HasOne(u => u.Role)
           .WithMany()
           .HasForeignKey(u => u.RoleId);


        modelBuilder.Entity<ProductEntity>()
           .Property(p => p.CostPrice)
           .HasPrecision(18, 2);

        modelBuilder.Entity<ProductEntity>()
            .Property(p => p.RetailPrice)
            .HasPrecision(18, 2);

        modelBuilder.Entity<BasketEntity>()
        .HasMany(b => b.Items)
        .WithOne(i => i.Basket)
        .HasForeignKey(i => i.BasketId);

        modelBuilder.Entity<BasketItemEntity>()
            .HasOne(bi => bi.Product)
            .WithMany()
            .HasForeignKey(bi => bi.ProductId);

        modelBuilder.Entity<BasketItemEntity>()
           .Property(b => b.RetailPrice)
           .HasPrecision(18, 2);

        modelBuilder.Entity<DeliveryEntity>()
            .HasMany(d => d.DeliveryItems)
            .WithOne(di => di.Delivery)
            .HasForeignKey(di => di.DeliveryId);

        modelBuilder.Entity<DeliveryItemEntity>()
            .HasOne(d => d.Product)
            .WithMany()
            .HasForeignKey(d => d.ProductId);

        modelBuilder.Entity<CategoryEntity>().HasData(
            new CategoryEntity { Id = 1, Name = "Voće", Description = "Kategorija svježeg voća", IsActive = true },
            new CategoryEntity { Id = 2, Name = "Povrće", Description = "Kategorija svježeg povrća", IsActive = true },
            new CategoryEntity { Id = 3, Name = "Meso", Description = "Kategorija svježeg mesa", IsActive = true },
            new CategoryEntity { Id = 4, Name = "Riba", Description = "Kategorija svježe ribe", IsActive = true },
            new CategoryEntity { Id = 5, Name = "Sok", Description = "Kategorija negaziranih pića", IsActive = true },
            new CategoryEntity { Id = 6, Name = "Sladoled", Description = "Kategorija sladoleda", IsActive = true },
            new CategoryEntity { Id = 7, Name = "Namještaj", Description = "Kategorija namještaja za domaćinstvo", IsActive = true },
            new CategoryEntity { Id = 8, Name = "Igračke", Description = "Kategorija igračaka", IsActive = true },
            new CategoryEntity { Id = 9, Name = "Mliječni proizvodi", Description = "Kategorija mliječnih proizvoda", IsActive = true },
            new CategoryEntity { Id = 10, Name = "Kruh i pecivo", Description = "Kategorija kruha i peciva", IsActive = true }
        );

        modelBuilder.Entity<ProductEntity>().HasData(
             new ProductEntity
             {
                 Id = 1,
                 Name = "Jabuka",
                 Description = "Svježe zelene jabuke 1kg",
                 Quantity = 100,
                 CostPrice = 0.79m,
                 RetailPrice = 1.50m,
                 MinimumStockLevel = 20,
                 SupplierId = 1,
                 Weight = 1.0f,
                 Dimensions = "10x10x10",
                 ExpirationDate = DateTime.UtcNow.AddDays(30),
                 IsActive = true,
                 CategoryId = 1
             },
             new ProductEntity
             {
                 Id = 2,
                 Name = "Krumpir",
                 Description = "Krumpiri za pečenje rinfuza 1kg",
                 Quantity = 200,
                 CostPrice = 0.60m,
                 RetailPrice = 1.00m,
                 MinimumStockLevel = 50,
                 SupplierId = 2,
                 Weight = 1.0f,
                 Dimensions = "15x15x15",
                 ExpirationDate = DateTime.UtcNow.AddDays(20),
                 IsActive = true,
                 CategoryId = 2
             },
             new ProductEntity
             {
                 Id = 3,
                 Name = "Svježi losos",
                 Description = "Svježi losos za gurmanske užitke 1kg",
                 Quantity = 50,
                 CostPrice = 10.00m,
                 RetailPrice = 15.00m,
                 MinimumStockLevel = 10,
                 SupplierId = 3,
                 Weight = 1.0f,
                 Dimensions = "30x10x5",
                 ExpirationDate = DateTime.UtcNow.AddDays(7),
                 IsActive = true,
                 CategoryId = 4
             },
             new ProductEntity
             {
                 Id = 4,
                 Name = "Banana",
                 Description = "Svježe žute banane 1kg",
                 Quantity = 150,
                 CostPrice = 1.00m,
                 RetailPrice = 2.00m,
                 MinimumStockLevel = 30,
                 SupplierId = 1,
                 Weight = 1.0f,
                 Dimensions = "20x15x10",
                 ExpirationDate = DateTime.UtcNow.AddDays(10),
                 IsActive = true,
                 CategoryId = 1
             },
             new ProductEntity
             {
                 Id = 5,
                 Name = "Naranča",
                 Description = "Svježe naranče za sok 1kg",
                 Quantity = 120,
                 CostPrice = 1.20m,
                 RetailPrice = 2.50m,
                 MinimumStockLevel = 25,
                 SupplierId = 1,
                 Weight = 1.0f,
                 Dimensions = "20x20x15",
                 ExpirationDate = DateTime.UtcNow.AddDays(15),
                 IsActive = true,
                 CategoryId = 1
             },
             new ProductEntity
             {
                 Id = 6,
                 Name = "Rajčica",
                 Description = "Svježe rajčice 1kg",
                 Quantity = 180,
                 CostPrice = 0.80m,
                 RetailPrice = 1.60m,
                 MinimumStockLevel = 40,
                 SupplierId = 2,
                 Weight = 1.0f,
                 Dimensions = "10x10x10",
                 ExpirationDate = DateTime.UtcNow.AddDays(7),
                 IsActive = true,
                 CategoryId = 2
             },

             new ProductEntity
             {
                 Id = 7,
                 Name = "Zelena salata",
                 Description = "Zelena salata 1 komad",
                 Quantity = 200,
                 CostPrice = 0.50m,
                 RetailPrice = 1.00m,
                 MinimumStockLevel = 50,
                 SupplierId = 2,
                 Weight = 0.3f,
                 Dimensions = "5x5x5",
                 ExpirationDate = DateTime.UtcNow.AddDays(5),
                 IsActive = true,
                 CategoryId = 2
             },
             new ProductEntity
             {
                 Id = 8,
                 Name = "Piletina",
                 Description = "Svježa piletina 1kg",
                 Quantity = 90,
                 CostPrice = 3.00m,
                 RetailPrice = 6.00m,
                 MinimumStockLevel = 20,
                 SupplierId = 3,
                 Weight = 1.0f,
                 Dimensions = "30x20x10",
                 ExpirationDate = DateTime.UtcNow.AddDays(7),
                 IsActive = true,
                 CategoryId = 3
             },
             new ProductEntity
             {
                 Id = 9,
                 Name = "Junetina",
                 Description = "Svježa junetina za gulaš 1kg",
                 Quantity = 70,
                 CostPrice = 4.00m,
                 RetailPrice = 8.00m,
                 MinimumStockLevel = 15,
                 SupplierId = 3,
                 Weight = 1.0f,
                 Dimensions = "30x20x10",
                 ExpirationDate = DateTime.UtcNow.AddDays(10),
                 IsActive = true,
                 CategoryId = 3
             },
             new ProductEntity
             {
                 Id = 10,
                 Name = "Svinjetina",
                 Description = "Svježa svinjetina za pečenje 1kg",
                 Quantity = 80,
                 CostPrice = 3.50m,
                 RetailPrice = 7.00m,
                 MinimumStockLevel = 20,
                 SupplierId = 3,
                 Weight = 1.0f,
                 Dimensions = "30x20x10",
                 ExpirationDate = DateTime.UtcNow.AddDays(10),
                 IsActive = true,
                 CategoryId = 3
             },
             new ProductEntity
             {
                 Id = 11,
                 Name = "Mlijeko",
                 Description = "Svježe mlijeko 1L",
                 Quantity = 100,
                 CostPrice = 0.50m,
                 RetailPrice = 1.00m,
                 MinimumStockLevel = 20,
                 SupplierId = 4,
                 Weight = 1.0f,
                 Dimensions = "10x10x10",
                 ExpirationDate = DateTime.UtcNow.AddDays(5),
                 IsActive = true,
                 CategoryId = 9
             },
             new ProductEntity
             {
                 Id = 12,
                 Name = "Jogurt",
                 Description = "Jogurt 1L",
                 Quantity = 100,
                 CostPrice = 0.70m,
                 RetailPrice = 1.50m,
                 MinimumStockLevel = 20,
                 SupplierId = 4,
                 Weight = 1.0f,
                 Dimensions = "10x10x10",
                 ExpirationDate = DateTime.UtcNow.AddDays(5),
                 IsActive = true,
                 CategoryId = 9
             },
             new ProductEntity
             {
                 Id = 13,
                 Name = "Kefir",
                 Description = "Kefir 1kg",
                 Quantity = 20,
                 CostPrice = 0.50m,
                 RetailPrice = 1.00m,
                 MinimumStockLevel = 20,
                 SupplierId = 4,
                 Weight = 1.0f,
                 Dimensions = "10x10x10",
                 ExpirationDate = DateTime.UtcNow.AddDays(5),
                 IsActive = true,
                 CategoryId = 9
             },
             new ProductEntity
             {
                 Id = 14,
                 Name = "Sladoled",
                 Description = "Sladoled od vanilije 1L",
                 Quantity = 50,
                 CostPrice = 2.00m,
                 RetailPrice = 3.00m,
                 MinimumStockLevel = 10,
                 SupplierId = 5,
                 Weight = 1.0f,
                 Dimensions = "10x10x10",
                 ExpirationDate = DateTime.UtcNow.AddDays(30),
                 IsActive = true,
                 CategoryId = 6
             },
             new ProductEntity
             {
                 Id = 15,
                 Name = "Kruh",
                 Description = "Kruh od bijelog brašna 0,7kg",
                 Quantity = 100,
                 CostPrice = 0.50m,
                 RetailPrice = 1.00m,
                 MinimumStockLevel = 20,
                 SupplierId = 6,
                 Weight = 0.7f,
                 Dimensions = "10x10x10",
                 ExpirationDate = DateTime.UtcNow.AddDays(1),
                 IsActive = true,
                 CategoryId = 10
             },
             new ProductEntity
             {
                 Id = 16,
                 Name = "Pecivo",
                 Description = "Pecivo sa sirom 0,2kg",
                 Quantity = 100,
                 CostPrice = 0.20m,
                 RetailPrice = 0.50m,
                 MinimumStockLevel = 20,
                 SupplierId = 6,
                 Weight = 0.2f,
                 Dimensions = "10x10x10",
                 ExpirationDate = DateTime.UtcNow.AddDays(1),
                 IsActive = true,
                 CategoryId = 10
             },
             new ProductEntity
             {
                 Id = 17,
                 Name = "Kruh sa sjemenkama",
                 Description = "Kruh sa suncokretovim i bučinim sjemenkama 0,4kg",
                 Quantity = 100,
                 CostPrice = 0.7m,
                 RetailPrice = 2.10m,
                 MinimumStockLevel = 10,
                 SupplierId = 7,
                 Weight = 0.4f,
                 Dimensions = "10x10x10",
                 ExpirationDate = DateTime.UtcNow.AddDays(1),
                 IsActive = true,
                 CategoryId = 10
             },
             new ProductEntity
             {
                 Id = 18,
                 Name = "Brancin",
                 Description = "Svježi brancin, idealan za pečenje, 1kg",
                 Quantity = 60,
                 CostPrice = 5.00m,
                 RetailPrice = 10.00m,
                 MinimumStockLevel = 15,
                 SupplierId = 4,
                 Weight = 1.0f,
                 Dimensions = "25x15x5",
                 ExpirationDate = DateTime.UtcNow.AddDays(5),
                 IsActive = true,
                 CategoryId = 4
             },
             new ProductEntity
             {
                 Id = 19,
                 Name = "Pastrva",
                 Description = "Svježa pastrva, odlična za roštilj, 1kg",
                 Quantity = 50,
                 CostPrice = 4.50m,
                 RetailPrice = 9.00m,
                 MinimumStockLevel = 10,
                 SupplierId = 4,
                 Weight = 0.8f,
                 Dimensions = "20x10x5",
                 ExpirationDate = DateTime.UtcNow.AddDays(5),
                 IsActive = true,
                 CategoryId = 4
             },
             new ProductEntity
             {
                 Id = 20,
                 Name = "Jabučni sok",
                 Description = "Prirodni jabučni sok bez dodanog šećera 1l",
                 Quantity = 100,
                 CostPrice = 0.80m,
                 RetailPrice = 1.60m,
                 MinimumStockLevel = 20,
                 SupplierId = 5,
                 Weight = 1.0f,
                 Dimensions = "10x10x30",
                 ExpirationDate = DateTime.UtcNow.AddDays(90),
                 IsActive = true,
                 CategoryId = 5
             },
             new ProductEntity
             {
                 Id = 21,
                 Name = "Narančin sok",
                 Description = "100% prirodni narančin sok 1l",
                 Quantity = 100,
                 CostPrice = 0.90m,
                 RetailPrice = 1.80m,
                 MinimumStockLevel = 20,
                 SupplierId = 5,
                 Weight = 1.0f,
                 Dimensions = "10x10x30",
                 ExpirationDate = DateTime.UtcNow.AddDays(90),
                 IsActive = true,
                 CategoryId = 5
             },
             new ProductEntity
             {
                 Id = 22,
                 Name = "Sok od grejpa",
                 Description = "Sok od grejpa bez dodatka šećera 1l",
                 Quantity = 100,
                 CostPrice = 1.00m,
                 RetailPrice = 2.00m,
                 MinimumStockLevel = 20,
                 SupplierId = 5,
                 Weight = 1.0f,
                 Dimensions = "10x10x30",
                 ExpirationDate = DateTime.UtcNow.AddDays(90),
                 IsActive = true,
                 CategoryId = 5
             },
             new ProductEntity
             {
                 Id = 23,
                 Name = "Čokoladni sladoled",
                 Description = "Bogati čokoladni sladoled s komadićima čokolade 1L",
                 Quantity = 80,
                 CostPrice = 2.50m,
                 RetailPrice = 4.00m,
                 MinimumStockLevel = 15,
                 SupplierId = 5,
                 Weight = 1.0f,
                 Dimensions = "10x10x10",
                 ExpirationDate = DateTime.UtcNow.AddDays(180),
                 IsActive = true,
                 CategoryId = 6
             },
             new ProductEntity
             {
                 Id = 24,
                 Name = "Jagoda sladoled",
                 Description = "Osvežavajući sladoled od jagode 1L",
                 Quantity = 80,
                 CostPrice = 2.00m,
                 RetailPrice = 3.50m,
                 MinimumStockLevel = 15,
                 SupplierId = 5,
                 Weight = 1.0f,
                 Dimensions = "10x10x10",
                 ExpirationDate = DateTime.UtcNow.AddDays(180),
                 IsActive = true,
                 CategoryId = 6
             },
             new ProductEntity
             {
                 Id = 25,
                 Name = "Noćni ormarić",
                 Description = "Drveni noćni ormarić s ladicom",
                 Quantity = 30,
                 CostPrice = 20.00m,
                 RetailPrice = 40.00m,
                 MinimumStockLevel = 5,
                 SupplierId = 8,
                 Weight = 5.0f,
                 Dimensions = "40x40x60",
                 ExpirationDate = DateTime.UtcNow.AddDays(365),
                 IsActive = true,
                 CategoryId = 7
             },
             new ProductEntity
             {
                 Id = 26,
                 Name = "Stolić za kavu",
                 Description = "Moderan stolić za kavu od masivnog drva",
                 Quantity = 20,
                 CostPrice = 30.00m,
                 RetailPrice = 60.00m,
                 MinimumStockLevel = 3,
                 SupplierId = 8,
                 Weight = 7.0f,
                 Dimensions = "90x50x45",
                 ExpirationDate = DateTime.UtcNow.AddDays(365),
                 IsActive = true,
                 CategoryId = 7
             },
             new ProductEntity
             {
                 Id = 27,
                 Name = "Zidna polica",
                 Description = "Plutena zidna polica za knjige i dekoracije",
                 Quantity = 50,
                 CostPrice = 15.00m,
                 RetailPrice = 30.00m,
                 MinimumStockLevel = 10,
                 SupplierId = 8,
                 Weight = 3.0f,
                 Dimensions = "100x20x20",
                 ExpirationDate = DateTime.UtcNow.AddDays(365),
                 IsActive = true,
                 CategoryId = 7
             },
             new ProductEntity
             {
                 Id = 28,
                 Name = "Lego set",
                 Description = "Kreativni Lego set za djecu",
                 Quantity = 50,
                 CostPrice = 20.00m,
                 RetailPrice = 40.00m,
                 MinimumStockLevel = 10,
                 SupplierId = 9,
                 Weight = 0.5f,
                 Dimensions = "30x20x10",
                 ExpirationDate = DateTime.UtcNow.AddDays(365),
                 IsActive = true,
                 CategoryId = 8
             },
             new ProductEntity
             {
                 Id = 29,
                 Name = "Društvena igra",
                 Description = "Zabavna društvena igra za cijelu obitelj",
                 Quantity = 40,
                 CostPrice = 15.00m,
                 RetailPrice = 30.00m,
                 MinimumStockLevel = 5,
                 SupplierId = 9,
                 Weight = 1.0f,
                 Dimensions = "40x25x5",
                 ExpirationDate = DateTime.UtcNow.AddDays(365),
                 IsActive = true,
                 CategoryId = 8
             },
             new ProductEntity
             {
                 Id = 30,
                 Name = "Plush medvjedić",
                 Description = "Mekani plišani medvjedić, idealan za poklon",
                 Quantity = 60,
                 CostPrice = 10.00m,
                 RetailPrice = 20.00m,
                 MinimumStockLevel = 15,
                 SupplierId = 9,
                 Weight = 0.2f,
                 Dimensions = "15x15x25",
                 ExpirationDate = DateTime.UtcNow.AddDays(365),
                 IsActive = true,
                 CategoryId = 8
             },
             new ProductEntity
             {
                 Id = 31,
                 Name = "Jogurt",
                 Description = "Prirodni jogurt bez dodataka, 1L",
                 Quantity = 100,
                 CostPrice = 0.90m,
                 RetailPrice = 1.80m,
                 MinimumStockLevel = 20,
                 SupplierId = 10,
                 Weight = 1.0f,
                 Dimensions = "10x10x15",
                 ExpirationDate = DateTime.UtcNow.AddDays(20),
                 IsActive = true,
                 CategoryId = 9
             }
        );

        modelBuilder.Entity<SupplierEntity>().HasData(
            new SupplierEntity { Id = 1, Name = "Svježe Voće d.o.o.", Address = "Ulica Voćnjaka 123", Phone = "123-456-7890", Email = "kontakt@svjezevoce.hr" },
            new SupplierEntity { Id = 2, Name = "Zelene Povrtnice d.d.", Address = "Put Farme 456", Phone = "234-567-8901", Email = "info@zelenepovrtnice.hr" },
            new SupplierEntity { Id = 3, Name = "Oceanik Ribe", Address = "Obalna Cesta 789", Phone = "345-678-9012", Email = "prodaja@oceanikribe.hr" },
            new SupplierEntity { Id = 4, Name = "Mliječni Užici", Address = "Mliječna Staza 101", Phone = "456-789-0123", Email = "podrska@mlijecniuzici.hr" },
            new SupplierEntity { Id = 5, Name = "Smrznute Poslastice d.o.o.", Address = "Ledena Avenija 202", Phone = "567-890-1234", Email = "narudzbe@smrznuteposlastice.hr" },
            new SupplierEntity { Id = 6, Name = "Pekarski Raj", Address = "Ulica Kruha 303", Phone = "678-901-2345", Email = "zdravo@pekarskiraj.hr" },
            new SupplierEntity { Id = 7, Name = "Namještaj za Dom d.o.o.", Address = "Ulica Udobnosti 404", Phone = "789-012-3456", Email = "kontakt@namjestajzadom.hr" },
            new SupplierEntity { Id = 8, Name = "Svijet Igračaka", Address = "Avenija Igranja 505", Phone = "890-123-4567", Email = "info@svijetigracaka.hr" },
            new SupplierEntity { Id = 9, Name = "Gurmanski Mesari", Address = "Cesta Steka 606", Phone = "901-234-5678", Email = "prodaja@gurmanskimesari.hr" },
            new SupplierEntity { Id = 10, Name = "Prirodni Jogurti", Address = "Put Jogurta 707", Phone = "012-345-6789", Email = "podrska@prirodnijogurti.hr" }
        );

        modelBuilder.Entity<RoleEntity>().HasData(
            new RoleEntity { Id = 1, Name = "Administrator" },
            new RoleEntity { Id = 2, Name = "Korisnik" },
            new RoleEntity { Id = 3, Name = "Kupac" }
        );

        string sol = BCrypt.Net.BCrypt.GenerateSalt();
        string lozinkaHash = BCrypt.Net.BCrypt.HashPassword("lozinka00--", sol);
        string sol1 = BCrypt.Net.BCrypt.GenerateSalt();
        string lozinkaHash1 = BCrypt.Net.BCrypt.HashPassword("lozinka00--", sol1);

        modelBuilder.Entity<UserEntity>().HasData(
           new UserEntity { Id = 1, Name = "Mate", Surname = "Matić", DateOfBirth = DateTime.ParseExact("02.06.1987", "dd.MM.yyyy", null), Email = "mmatic@mail.hr", Role = null, RoleId = 2, Username = "mmatic", IsActive = true, PasswordSalt = sol, PasswordHash = lozinkaHash },
           new UserEntity { Id = 2, Name = "Ivo", Surname = "Ivić", DateOfBirth = DateTime.ParseExact("25.01.1983", "dd.MM.yyyy", null), Email = "iivic@mail.hr", Role = null, RoleId = 3, Username = "iivic", IsActive = true, PasswordSalt = "$2a$11$G3P5ADka.mwD6orjGqUAve", PasswordHash = "$2a$11$G3P5ADka.mwD6orjGqUAve8EGYF7cd3nzEFrNEE2MJ2.Pd5U6Ge2C" },
           new UserEntity { Id = 3, Name = "Sys", Surname = "Adm", DateOfBirth = DateTime.ParseExact("01.01.1911", "dd.MM.yyyy", null), Email = "sysadm@mail.hr", Role = null, RoleId = 1, Username = "sa", IsActive = true, PasswordSalt = sol1, PasswordHash = lozinkaHash1 }
        );
    }
}
