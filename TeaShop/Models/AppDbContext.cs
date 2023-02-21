using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TeaShop.Models
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPhoto> ProductsPhoto { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartDetails> CartDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        public DbSet<OrderStatus> orderStatuses { get; set; }
        public int Counter { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, CategoryName = "Zielone" },
                new Category() { Id = 2, CategoryName = "Czarne" },
                new Category() { Id = 3, CategoryName = "Owocowe" },
                new Category() { Id = 4, CategoryName = "Dodatki" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Bancha",
                    Amount = 30,
                    Description = "Bancha należy do grona herbat zielonych. Pozyskiwana jest z krzewu Camellia sinensis czyli z tego samego, z którego pozyskuje się herbatę Sencha. Sencha powstaje z pierwszego zbioru delikatnych, młodych listków herbaty. Bancha zaś to tzw. herbata późnego zbioru (zbierana późnym latem, jesienią, a nawet i niekiedy zimą.",
                    Price = 20,
                    Weight = 250,
                    CategoryId=1,
                    PhotoId=1,
                },
                new Product()
                {
                    Id = 2,
                    Name = "China GunPowder",
                    Amount = 50,
                    Description = "Mianem Gunpowder (czyli proch strzelniczy) jest nazywana herbata o listkach zwiniętych do postaci herbacianych kulek małej średnicy, twardych w dotyku, o szaro-zielonym odcieniu. China Gunpowder pochodzi z chińskiej prowincji Anhwei gdzie jest produkowany podczas wyjątkowo krótkich zbiorów. ",
                    Price = 35,
                    Weight = 200,
                    CategoryId = 1,
                    PhotoId = 2,
                },
                new Product()
                {
                    Id = 3,
                    Name = "Sencha",
                    Amount = 100,
                    Description = "Herbaty pochodzenia japońskiego charakteryzują się wybitną jakością wynikającą z obowiązujących bardzo wysokich standardów prowadzenia upraw i obróbki zebranego materiału.Japońska Sencha to klasyka zielonych herbat pochodzących z Kraju Kwitnącej Wiśni. Właściwie przygotowany napar charakteryzuje wykwintny smak i aromat.",
                    Price = 30,
                    Weight = 150,
                    CategoryId = 1,
                    PhotoId=3,
                },
                new Product()
                {
                    Id = 4,
                    Name = "Golden Yunnan",
                    Amount = 50,
                    Description = "Herbata pochodzi z górskiej prowincji Yunnan położonej w Chinach przy granicy z Wietnamem, Birmą i Laosem, a rosnące w tym regionie krzewy herbaciane charakteryzują się szerokimi i mięsistymi liśćmi o połyskującej powierzchni. Golden Yunnan swoją nazwę zawdzięcza dużej ilości złotych \"tipsów\", dzięki którym uzyskiwany susz ma niespotykany złocisto-bursztynowy odcień.",
                    Price = 20,
                    Weight = 100,
                    CategoryId = 2,
                    PhotoId=4
                },
                new Product()
                {
                    Id = 5,
                    Name = "English Breakfast",
                    Amount = 150,
                    Description = "Popularna kompozycja dwóch czarnych herbat gatunków Assam i Cejlon. Dedykowana jest do spożycia w godzinach porannych. Charakteryzuje się mocnym i wyrazistym smakiem i brązowo-bursztynową barwą. ",
                    Price = 10,
                    Weight = 200,
                    CategoryId = 2,
                    PhotoId=5,
                },
                new Product()
                {
                    Id = 6,
                    Name = "Ceylon High Grown OP",
                    Amount = 200,
                    Description = "Ceylon High Grown OP (Orange Pekoe) to propozycja herbaty czarnej o długich, spiczastych liściach, sporadycznie zawierającej złotawe tipsy Napar charakteryzuje się delikatnym aromatem, orzeźwiającym smakiem oraz czerwono- złotą barwą.",
                    Price = 25,
                    Weight = 250,
                    CategoryId = 2,
                    PhotoId=6,
                },
                new Product()
                {
                    Id = 7,
                    Name = "Bora Bora",
                    Amount = 220,
                    Description = "Wspaniale fantazyjne połączenie owoców: jabłka, papai, owocu czarnego bzu, maliny oraz truskawki w towarzystwie hibiskusa, delikatnych płatków słonecznika i aromatycznego bławatka. Z każdym kolejnym łykiem przenosi nas w cudowny klimat egzotyki. Wyśmienita do podawania jako słodki dodatek podczas spotkań z rodziną czy przyjaciółmi.",
                    Price = 25,
                    Weight = 200,
                    CategoryId = 3,
                    PhotoId=7,
                },
                new Product()
                {
                    Id = 8,
                    Name = "Owocowe Love",
                    Amount = 300,
                    Description = "Kompozycja owocowa, w której skład wchodzi: jabłko, skórka dzikiej róży, skórka pomarańczy, hibiskus, malina i bławatek.",
                    Price = 15,
                    Weight = 150,
                    CategoryId = 3,
                    PhotoId = 8
                },
                new Product()
                {
                    Id = 9,
                    Name = "Paris Paris",
                    Amount = 150,
                    Description = "Wybierz się na spacer uliczkami miasta miłości. W jego zakamarkach znajdziesz kwiaty intensywnego hibiskusa i delikatnej róży, skosztujesz owoców truskawki, żurawiny i wiśni, a także natkniesz się na romantyczne cukrowe serduszka, które osłodzą przechadzkę.",
                    Price = 35,
                    Weight = 150, 
                    CategoryId = 3,
                    PhotoId=9
                },
                new Product()
                {
                    Id = 10,
                    Name = "Miodowe Lawendowe",
                    Amount = 50,
                    Description = "Polecamy jako słodki dodatek do herbaty. Miód z lawnendą",
                    Price = 15,
                    Weight = 50,
                    CategoryId = 4,
                    PhotoId=10
                },
                new Product()
                {
                    Id = 11,
                    Name = "Miodowy Cynamon",
                    Amount = 50,
                    Description = "Polecamy jako słodki dodatek do herbaty. Miód z cynamonem",
                    Price = 15,
                    Weight = 50,
                    CategoryId = 4,
                    PhotoId=11
                },
                new Product()
                {
                    Id = 12,
                    Name = "Miód z migdałami",
                    Amount = 50,
                    Description = "Polecamy jako słodki dodatek do herbaty. Miód z migdałami",
                    Price = 17,
                    Weight = 50,
                    CategoryId = 4,
                    PhotoId=12
                }

                );
            modelBuilder.Entity<ProductPhoto>().HasData(
                new ProductPhoto()
                {
                    Id= 1,
                    ImageName="1",
                    ImagePath= "/images/1.jpg", 
                    ProductId= 1,
                },
                new ProductPhoto()
                {
                    Id = 2,
                    ImageName = "2",
                    ImagePath = "/images/2.jpg",
                    ProductId= 2,
                },
                new ProductPhoto()
                {
                    Id = 3,
                    ImageName = "3",
                    ImagePath = "/images/3.jpg",
                    ProductId= 3,
                },
                new ProductPhoto()
                {
                    Id = 4,
                    ImageName = "4",
                    ImagePath = "/images/4.jpg",
                    ProductId= 4,
                },
                new ProductPhoto()
                {
                    Id = 5,
                    ImageName = "5",
                    ImagePath = "/images/5.png",
                    ProductId= 5,
                },
                new ProductPhoto()
                {
                    Id = 6,
                    ImageName = "6",
                    ImagePath = "/images/6.jpg",
                    ProductId= 6,
                },
                new ProductPhoto()
                {
                    Id = 7,
                    ImageName = "7",
                    ImagePath = "/images/7.jpg",
                    ProductId= 7,
                },
                new ProductPhoto()
                {
                    Id = 8,
                    ImageName = "8",
                    ImagePath = "/images/8.jpg",
                    ProductId= 8,
                },
                new ProductPhoto()
                {
                    Id = 9,
                    ImageName = "9",
                    ImagePath = "/images/9.jpg",
                    ProductId= 9,
                },
                new ProductPhoto()
                {
                    Id = 10,
                    ImageName = "10",
                    ImagePath = "/images/10.jpg",
                    ProductId= 10,
                },
                new ProductPhoto()
                {
                    Id = 11,
                    ImageName = "11",
                    ImagePath = "/images/11.jpg",
                    ProductId= 11,
                },
                 new ProductPhoto()
                 {
                     Id = 12,
                     ImageName = "12",
                     ImagePath = "/images/12.jpg",
                     ProductId= 12,
                 }

                );
            modelBuilder.Entity<OrderStatus>().HasData(
                new OrderStatus() { Id = 1, StatusId = 1, StatusName="Złożone" },
                new OrderStatus() { Id = 2, StatusId = 2, StatusName="W trakcie" },
                new OrderStatus() { Id = 3, StatusId = 3, StatusName="Anulowane" }
                );
            modelBuilder.Entity<Product>()
                .HasOne<Category>(u => u.Category)
                .WithMany(d => d.Products)
                .IsRequired();
            modelBuilder.Entity<Product>()
                .HasOne<ProductPhoto>(s => s.ProductPhoto)
                .WithOne(c => c.Product)
                .HasForeignKey<ProductPhoto>(k => k.ProductId);


        }



    }
}
