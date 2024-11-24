﻿// <auto-generated />
using System;
using Kursova_BD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kursova_BD.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20241123233655_changeNameOf29Item")]
    partial class changeNameOf29Item
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.ToTable("Categories");

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

                    b.ToTable("Items");

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
                            Name = "Кава",
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

                    b.ToTable("Orders");
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

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Kursova_BD.Models.Tables.Storage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ItemId")
                        .IsUnique();

                    b.ToTable("Storages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ItemId = 1,
                            Quantity = 80,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 2,
                            ItemId = 2,
                            Quantity = 75,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 3,
                            ItemId = 3,
                            Quantity = 90,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 4,
                            ItemId = 4,
                            Quantity = 85,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 5,
                            ItemId = 5,
                            Quantity = 95,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 6,
                            ItemId = 6,
                            Quantity = 60,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 7,
                            ItemId = 7,
                            Quantity = 70,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 8,
                            ItemId = 8,
                            Quantity = 65,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 9,
                            ItemId = 9,
                            Quantity = 75,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 10,
                            ItemId = 10,
                            Quantity = 80,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 11,
                            ItemId = 11,
                            Quantity = 55,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 12,
                            ItemId = 12,
                            Quantity = 70,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 13,
                            ItemId = 13,
                            Quantity = 85,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 14,
                            ItemId = 14,
                            Quantity = 90,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 15,
                            ItemId = 15,
                            Quantity = 95,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 16,
                            ItemId = 16,
                            Quantity = 75,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 17,
                            ItemId = 17,
                            Quantity = 80,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 18,
                            ItemId = 18,
                            Quantity = 85,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 19,
                            ItemId = 19,
                            Quantity = 90,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 20,
                            ItemId = 20,
                            Quantity = 95,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 21,
                            ItemId = 21,
                            Quantity = 60,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 22,
                            ItemId = 22,
                            Quantity = 70,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 23,
                            ItemId = 23,
                            Quantity = 75,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 24,
                            ItemId = 24,
                            Quantity = 80,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 25,
                            ItemId = 25,
                            Quantity = 85,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 26,
                            ItemId = 26,
                            Quantity = 80,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 27,
                            ItemId = 27,
                            Quantity = 85,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 28,
                            ItemId = 28,
                            Quantity = 90,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 29,
                            ItemId = 29,
                            Quantity = 95,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 30,
                            ItemId = 30,
                            Quantity = 100,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 31,
                            ItemId = 31,
                            Quantity = 100,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 32,
                            ItemId = 32,
                            Quantity = 95,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 33,
                            ItemId = 33,
                            Quantity = 90,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 34,
                            ItemId = 34,
                            Quantity = 85,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        },
                        new
                        {
                            Id = 35,
                            ItemId = 35,
                            Quantity = 80,
                            UpdateTime = new DateTime(2024, 11, 24, 1, 36, 54, 771, DateTimeKind.Local).AddTicks(9950)
                        });
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

            modelBuilder.Entity("Kursova_BD.Models.Tables.Storage", b =>
                {
                    b.HasOne("Kursova_BD.Models.Tables.Item", "Item")
                        .WithOne("Storage")
                        .HasForeignKey("Kursova_BD.Models.Tables.Storage", "ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Kursova_BD.Models.Tables.Category", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Kursova_BD.Models.Tables.Item", b =>
                {
                    b.Navigation("Storage");
                });

            modelBuilder.Entity("Kursova_BD.Models.Tables.Order", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
