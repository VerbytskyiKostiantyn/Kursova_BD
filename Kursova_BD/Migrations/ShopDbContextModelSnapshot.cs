﻿// <auto-generated />
using System;
using Kursova_BD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kursova_BD.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    partial class ShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Kursova_BD.Models.Tables.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImagePath = "/images/1.jpg",
                            Name = "М'ясо"
                        },
                        new
                        {
                            Id = 2,
                            ImagePath = "/images/2.jpg",
                            Name = "Овочі"
                        },
                        new
                        {
                            Id = 3,
                            ImagePath = "/images/3.jpg",
                            Name = "Фрукти"
                        },
                        new
                        {
                            Id = 4,
                            ImagePath = "/images/4.jpg",
                            Name = "Риба"
                        },
                        new
                        {
                            Id = 5,
                            ImagePath = "/images/5.jpg",
                            Name = "Сири"
                        },
                        new
                        {
                            Id = 6,
                            ImagePath = "/images/6.jpg",
                            Name = "Хліб"
                        },
                        new
                        {
                            Id = 7,
                            ImagePath = "/images/7.jpg",
                            Name = "Напої"
                        });
                });

            modelBuilder.Entity("Kursova_BD.Models.Tables.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Items", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            ImagePath = "/images/8.jpg",
                            Name = "Свинина",
                            Price = 50
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            ImagePath = "/images/9.jpg",
                            Name = "Телятина",
                            Price = 45
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            ImagePath = "/images/10.jpg",
                            Name = "Курка",
                            Price = 35
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            ImagePath = "/images/11.jpg",
                            Name = "Качка",
                            Price = 40
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            ImagePath = "/images/12.jpg",
                            Name = "Індичка",
                            Price = 30
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            ImagePath = "/images/13.jpg",
                            Name = "Помідор",
                            Price = 15
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            ImagePath = "/images/14.jpg",
                            Name = "Морква",
                            Price = 12
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            ImagePath = "/images/15.jpg",
                            Name = "Цибуля",
                            Price = 8
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            ImagePath = "/images/16.jpg",
                            Name = "Капуста",
                            Price = 20
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            ImagePath = "/images/17.jpg",
                            Name = "Огірок",
                            Price = 18
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            ImagePath = "/images/18.jpg",
                            Name = "Яблуко",
                            Price = 25
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            ImagePath = "/images/19.jpg",
                            Name = "Банан",
                            Price = 15
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            ImagePath = "/images/20.jpg",
                            Name = "Апельсин",
                            Price = 22
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            ImagePath = "/images/21.jpg",
                            Name = "Манго",
                            Price = 30
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            ImagePath = "/images/22.jpg",
                            Name = "Лимон",
                            Price = 18
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 4,
                            ImagePath = "/images/23.jpg",
                            Name = "Карась",
                            Price = 35
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 4,
                            ImagePath = "/images/24.jpg",
                            Name = "Короп",
                            Price = 40
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            ImagePath = "/images/25.jpg",
                            Name = "Лосось",
                            Price = 45
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            ImagePath = "/images/26.jpg",
                            Name = "Скумбрія",
                            Price = 38
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            ImagePath = "/images/27.jpg",
                            Name = "Окунь",
                            Price = 32
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 5,
                            ImagePath = "/images/28.jpg",
                            Name = "Фета",
                            Price = 25
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 5,
                            ImagePath = "/images/29.jpg",
                            Name = "Домашній",
                            Price = 28
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 5,
                            ImagePath = "/images/30.jpg",
                            Name = "Брі",
                            Price = 30
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 5,
                            ImagePath = "/images/31.jpg",
                            Name = "Моцарелла",
                            Price = 22
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 5,
                            ImagePath = "/images/32.jpg",
                            Name = "Пармезан",
                            Price = 35
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 6,
                            ImagePath = "/images/33.jpg",
                            Name = "Багет",
                            Price = 15
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 6,
                            ImagePath = "/images/34.jpg",
                            Name = "Батон",
                            Price = 10
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 6,
                            ImagePath = "/images/35.jpg",
                            Name = "Український",
                            Price = 20
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 6,
                            ImagePath = "/images/36.jpg",
                            Name = "Пампушки",
                            Price = 18
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 6,
                            ImagePath = "/images/37.jpg",
                            Name = "Лаваш",
                            Price = 12
                        },
                        new
                        {
                            Id = 31,
                            CategoryId = 7,
                            ImagePath = "/images/38.jpg",
                            Name = "Горілка",
                            Price = 20
                        },
                        new
                        {
                            Id = 32,
                            CategoryId = 7,
                            ImagePath = "/images/39.jpg",
                            Name = "Червоне вино",
                            Price = 35
                        },
                        new
                        {
                            Id = 33,
                            CategoryId = 7,
                            ImagePath = "/images/40.jpg",
                            Name = "Біле вино",
                            Price = 40
                        },
                        new
                        {
                            Id = 34,
                            CategoryId = 7,
                            ImagePath = "/images/41.jpg",
                            Name = "Пиво",
                            Price = 25
                        },
                        new
                        {
                            Id = 35,
                            CategoryId = 7,
                            ImagePath = "/images/42.jpg",
                            Name = "Сік",
                            Price = 18
                        });
                });

            modelBuilder.Entity("Kursova_BD.Models.Tables.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfOrder")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalOrderPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("Kursova_BD.Models.Tables.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("OrderQuantity")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems", (string)null);
                });

            modelBuilder.Entity("Kursova_BD.Models.Tables.Item", b =>
                {
                    b.HasOne("Kursova_BD.Models.Tables.Category", null)
                        .WithMany("Items")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Kursova_BD.Models.Tables.OrderItem", b =>
                {
                    b.HasOne("Kursova_BD.Models.Tables.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kursova_BD.Models.Tables.Order", null)
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Kursova_BD.Models.Tables.Category", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Kursova_BD.Models.Tables.Order", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
