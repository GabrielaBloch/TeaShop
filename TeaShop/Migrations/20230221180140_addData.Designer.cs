// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeaShop.Models;

#nullable disable

namespace TeaShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230221180140_addData")]
    partial class addData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TeaShop.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("TeaShop.Models.CartDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingCartId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("CartDetails");
                });

            modelBuilder.Entity("TeaShop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Zielone"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Czarne"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Owocowe"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Dodatki"
                        });
                });

            modelBuilder.Entity("TeaShop.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrderStatusId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TeaShop.Models.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("TeaShop.Models.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("orderStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            StatusId = 1,
                            StatusName = "Złożone"
                        },
                        new
                        {
                            Id = 2,
                            StatusId = 2,
                            StatusName = "W trakcie"
                        },
                        new
                        {
                            Id = 3,
                            StatusId = 3,
                            StatusName = "Anulowane"
                        });
                });

            modelBuilder.Entity("TeaShop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhotoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 30,
                            CategoryId = 1,
                            Description = "Bancha należy do grona herbat zielonych. Pozyskiwana jest z krzewu Camellia sinensis czyli z tego samego, z którego pozyskuje się herbatę Sencha. Sencha powstaje z pierwszego zbioru delikatnych, młodych listków herbaty. Bancha zaś to tzw. herbata późnego zbioru (zbierana późnym latem, jesienią, a nawet i niekiedy zimą.",
                            Name = "Bancha",
                            PhotoId = 1,
                            Price = 20m,
                            Weight = 250m
                        },
                        new
                        {
                            Id = 2,
                            Amount = 50,
                            CategoryId = 1,
                            Description = "Mianem Gunpowder (czyli proch strzelniczy) jest nazywana herbata o listkach zwiniętych do postaci herbacianych kulek małej średnicy, twardych w dotyku, o szaro-zielonym odcieniu. China Gunpowder pochodzi z chińskiej prowincji Anhwei gdzie jest produkowany podczas wyjątkowo krótkich zbiorów. ",
                            Name = "China GunPowder",
                            PhotoId = 2,
                            Price = 35m,
                            Weight = 200m
                        },
                        new
                        {
                            Id = 3,
                            Amount = 100,
                            CategoryId = 1,
                            Description = "Herbaty pochodzenia japońskiego charakteryzują się wybitną jakością wynikającą z obowiązujących bardzo wysokich standardów prowadzenia upraw i obróbki zebranego materiału.Japońska Sencha to klasyka zielonych herbat pochodzących z Kraju Kwitnącej Wiśni. Właściwie przygotowany napar charakteryzuje wykwintny smak i aromat.",
                            Name = "Sencha",
                            PhotoId = 3,
                            Price = 30m,
                            Weight = 150m
                        },
                        new
                        {
                            Id = 4,
                            Amount = 50,
                            CategoryId = 2,
                            Description = "Herbata pochodzi z górskiej prowincji Yunnan położonej w Chinach przy granicy z Wietnamem, Birmą i Laosem, a rosnące w tym regionie krzewy herbaciane charakteryzują się szerokimi i mięsistymi liśćmi o połyskującej powierzchni. Golden Yunnan swoją nazwę zawdzięcza dużej ilości złotych \"tipsów\", dzięki którym uzyskiwany susz ma niespotykany złocisto-bursztynowy odcień.",
                            Name = "Golden Yunnan",
                            PhotoId = 4,
                            Price = 20m,
                            Weight = 100m
                        },
                        new
                        {
                            Id = 5,
                            Amount = 150,
                            CategoryId = 2,
                            Description = "Popularna kompozycja dwóch czarnych herbat gatunków Assam i Cejlon. Dedykowana jest do spożycia w godzinach porannych. Charakteryzuje się mocnym i wyrazistym smakiem i brązowo-bursztynową barwą. ",
                            Name = "English Breakfast",
                            PhotoId = 5,
                            Price = 10m,
                            Weight = 200m
                        },
                        new
                        {
                            Id = 6,
                            Amount = 200,
                            CategoryId = 2,
                            Description = "Ceylon High Grown OP (Orange Pekoe) to propozycja herbaty czarnej o długich, spiczastych liściach, sporadycznie zawierającej złotawe tipsy Napar charakteryzuje się delikatnym aromatem, orzeźwiającym smakiem oraz czerwono- złotą barwą.",
                            Name = "Ceylon High Grown OP",
                            PhotoId = 6,
                            Price = 25m,
                            Weight = 250m
                        },
                        new
                        {
                            Id = 7,
                            Amount = 220,
                            CategoryId = 3,
                            Description = "Wspaniale fantazyjne połączenie owoców: jabłka, papai, owocu czarnego bzu, maliny oraz truskawki w towarzystwie hibiskusa, delikatnych płatków słonecznika i aromatycznego bławatka. Z każdym kolejnym łykiem przenosi nas w cudowny klimat egzotyki. Wyśmienita do podawania jako słodki dodatek podczas spotkań z rodziną czy przyjaciółmi.",
                            Name = "Bora Bora",
                            PhotoId = 7,
                            Price = 25m,
                            Weight = 200m
                        },
                        new
                        {
                            Id = 8,
                            Amount = 300,
                            CategoryId = 3,
                            Description = "Kompozycja owocowa, w której skład wchodzi: jabłko, skórka dzikiej róży, skórka pomarańczy, hibiskus, malina i bławatek.",
                            Name = "Owocowe Love",
                            PhotoId = 8,
                            Price = 15m,
                            Weight = 150m
                        },
                        new
                        {
                            Id = 9,
                            Amount = 150,
                            CategoryId = 3,
                            Description = "Wybierz się na spacer uliczkami miasta miłości. W jego zakamarkach znajdziesz kwiaty intensywnego hibiskusa i delikatnej róży, skosztujesz owoców truskawki, żurawiny i wiśni, a także natkniesz się na romantyczne cukrowe serduszka, które osłodzą przechadzkę.",
                            Name = "Paris Paris",
                            PhotoId = 9,
                            Price = 35m,
                            Weight = 150m
                        },
                        new
                        {
                            Id = 10,
                            Amount = 50,
                            CategoryId = 4,
                            Description = "Polecamy jako słodki dodatek do herbaty. Miód z lawnendą",
                            Name = "Miodowe Lawendowe",
                            PhotoId = 10,
                            Price = 15m,
                            Weight = 50m
                        },
                        new
                        {
                            Id = 11,
                            Amount = 50,
                            CategoryId = 4,
                            Description = "Polecamy jako słodki dodatek do herbaty. Miód z cynamonem",
                            Name = "Miodowy Cynamon",
                            PhotoId = 11,
                            Price = 15m,
                            Weight = 50m
                        },
                        new
                        {
                            Id = 12,
                            Amount = 50,
                            CategoryId = 4,
                            Description = "Polecamy jako słodki dodatek do herbaty. Miód z migdałami",
                            Name = "Miód z migdałami",
                            PhotoId = 12,
                            Price = 17m,
                            Weight = 50m
                        });
                });

            modelBuilder.Entity("TeaShop.Models.ProductPhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductsPhoto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageName = "1",
                            ImagePath = "/images/1.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            ImageName = "2",
                            ImagePath = "/images/2.jpg",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 3,
                            ImageName = "3",
                            ImagePath = "/images/3.jpg",
                            ProductId = 3
                        },
                        new
                        {
                            Id = 4,
                            ImageName = "4",
                            ImagePath = "/images/4.jpg",
                            ProductId = 4
                        },
                        new
                        {
                            Id = 5,
                            ImageName = "5",
                            ImagePath = "/images/5.png",
                            ProductId = 5
                        },
                        new
                        {
                            Id = 6,
                            ImageName = "6",
                            ImagePath = "/images/6.jpg",
                            ProductId = 6
                        },
                        new
                        {
                            Id = 7,
                            ImageName = "7",
                            ImagePath = "/images/7.jpg",
                            ProductId = 7
                        },
                        new
                        {
                            Id = 8,
                            ImageName = "8",
                            ImagePath = "/images/8.jpg",
                            ProductId = 8
                        },
                        new
                        {
                            Id = 9,
                            ImageName = "9",
                            ImagePath = "/images/9.jpg",
                            ProductId = 9
                        },
                        new
                        {
                            Id = 10,
                            ImageName = "10",
                            ImagePath = "/images/10.jpg",
                            ProductId = 10
                        },
                        new
                        {
                            Id = 11,
                            ImageName = "11",
                            ImagePath = "/images/11.jpg",
                            ProductId = 11
                        },
                        new
                        {
                            Id = 12,
                            ImageName = "12",
                            ImagePath = "/images/12.jpg",
                            ProductId = 12
                        });
                });

            modelBuilder.Entity("TeaShop.Models.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TeaShop.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TeaShop.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeaShop.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TeaShop.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TeaShop.Models.CartDetails", b =>
                {
                    b.HasOne("TeaShop.Models.Order", null)
                        .WithMany("CartDetail")
                        .HasForeignKey("OrderId");

                    b.HasOne("TeaShop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeaShop.Models.ShoppingCart", "ShoppingCart")
                        .WithMany("CartDetail")
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("TeaShop.Models.Order", b =>
                {
                    b.HasOne("TeaShop.Models.OrderStatus", "OrderStatus")
                        .WithMany()
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderStatus");
                });

            modelBuilder.Entity("TeaShop.Models.OrderDetails", b =>
                {
                    b.HasOne("TeaShop.Models.Order", "Order")
                        .WithMany("OrderDetail")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeaShop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("TeaShop.Models.Product", b =>
                {
                    b.HasOne("TeaShop.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("TeaShop.Models.ProductPhoto", b =>
                {
                    b.HasOne("TeaShop.Models.Product", "Product")
                        .WithOne("ProductPhoto")
                        .HasForeignKey("TeaShop.Models.ProductPhoto", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("TeaShop.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("TeaShop.Models.Order", b =>
                {
                    b.Navigation("CartDetail");

                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("TeaShop.Models.Product", b =>
                {
                    b.Navigation("ProductPhoto")
                        .IsRequired();
                });

            modelBuilder.Entity("TeaShop.Models.ShoppingCart", b =>
                {
                    b.Navigation("CartDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
