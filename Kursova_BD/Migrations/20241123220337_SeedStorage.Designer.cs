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
    [Migration("20241123220337_SeedStorage")]
    partial class SeedStorage
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
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\1.img",
                            Name = "М'ясо"
                        },
                        new
                        {
                            Id = 2,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\2.img",
                            Name = "Овочі"
                        },
                        new
                        {
                            Id = 3,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\3.img",
                            Name = "Фрукти"
                        },
                        new
                        {
                            Id = 4,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\4.img",
                            Name = "Риба"
                        },
                        new
                        {
                            Id = 5,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\5.img",
                            Name = "Сири"
                        },
                        new
                        {
                            Id = 6,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\6.img",
                            Name = "Хліб"
                        },
                        new
                        {
                            Id = 7,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\7.img",
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
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\8.img",
                            Name = "Свинина",
                            Price = 50
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\9.img",
                            Name = "Телятина",
                            Price = 45
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\10.img",
                            Name = "Курка",
                            Price = 35
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\11.img",
                            Name = "Качка",
                            Price = 40
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\12.img",
                            Name = "Індичка",
                            Price = 30
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\13.img",
                            Name = "Помідор",
                            Price = 15
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\14.img",
                            Name = "Морква",
                            Price = 12
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\15.img",
                            Name = "Цибуля",
                            Price = 8
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\16.img",
                            Name = "Капуста",
                            Price = 20
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\17.img",
                            Name = "Огірок",
                            Price = 18
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\18.img",
                            Name = "Яблуко",
                            Price = 25
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\19.img",
                            Name = "Банан",
                            Price = 15
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\20.img",
                            Name = "Апельсин",
                            Price = 22
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\21.img",
                            Name = "Манго",
                            Price = 30
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\22.img",
                            Name = "Лимон",
                            Price = 18
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 4,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\23.img",
                            Name = "Карась",
                            Price = 35
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 4,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\24.img",
                            Name = "Короп",
                            Price = 40
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\25.img",
                            Name = "Лосось",
                            Price = 45
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\26.img",
                            Name = "Скумбрія",
                            Price = 38
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\27.img",
                            Name = "Окунь",
                            Price = 32
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 5,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\28.img",
                            Name = "Фета",
                            Price = 25
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 5,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\29.img",
                            Name = "Домашній",
                            Price = 28
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 5,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\30.img",
                            Name = "Брі",
                            Price = 30
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 5,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\31.img",
                            Name = "Моцарелла",
                            Price = 22
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 5,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\32.img",
                            Name = "Пармезан",
                            Price = 35
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 6,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\33.img",
                            Name = "Багет",
                            Price = 15
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 6,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\34.img",
                            Name = "Батон",
                            Price = 10
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 6,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\35.img",
                            Name = "Український",
                            Price = 20
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 6,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\36.img",
                            Name = "Помпушки",
                            Price = 18
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 6,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\37.img",
                            Name = "Лаваш",
                            Price = 12
                        },
                        new
                        {
                            Id = 31,
                            CategoryId = 7,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\38.img",
                            Name = "Кава",
                            Price = 20
                        },
                        new
                        {
                            Id = 32,
                            CategoryId = 7,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\39.img",
                            Name = "Червоне вино",
                            Price = 35
                        },
                        new
                        {
                            Id = 33,
                            CategoryId = 7,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\40.img",
                            Name = "Біле вино",
                            Price = 40
                        },
                        new
                        {
                            Id = 34,
                            CategoryId = 7,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\41.img",
                            Name = "Пиво",
                            Price = 25
                        },
                        new
                        {
                            Id = 35,
                            CategoryId = 7,
                            ImagePath = "D:\\Унік\\3 курс\\Бази даних\\Курсова\\Kursova_BD\\Kursova_BD\\wwwroot\\images\\42.img",
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
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 2,
                            ItemId = 2,
                            Quantity = 75,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 3,
                            ItemId = 3,
                            Quantity = 90,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 4,
                            ItemId = 4,
                            Quantity = 85,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 5,
                            ItemId = 5,
                            Quantity = 95,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 6,
                            ItemId = 6,
                            Quantity = 60,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 7,
                            ItemId = 7,
                            Quantity = 70,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 8,
                            ItemId = 8,
                            Quantity = 65,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 9,
                            ItemId = 9,
                            Quantity = 75,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 10,
                            ItemId = 10,
                            Quantity = 80,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 11,
                            ItemId = 11,
                            Quantity = 55,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 12,
                            ItemId = 12,
                            Quantity = 70,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 13,
                            ItemId = 13,
                            Quantity = 85,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 14,
                            ItemId = 14,
                            Quantity = 90,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 15,
                            ItemId = 15,
                            Quantity = 95,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 16,
                            ItemId = 16,
                            Quantity = 75,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 17,
                            ItemId = 17,
                            Quantity = 80,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 18,
                            ItemId = 18,
                            Quantity = 85,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 19,
                            ItemId = 19,
                            Quantity = 90,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 20,
                            ItemId = 20,
                            Quantity = 95,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 21,
                            ItemId = 21,
                            Quantity = 60,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 22,
                            ItemId = 22,
                            Quantity = 70,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 23,
                            ItemId = 23,
                            Quantity = 75,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 24,
                            ItemId = 24,
                            Quantity = 80,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 25,
                            ItemId = 25,
                            Quantity = 85,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 26,
                            ItemId = 26,
                            Quantity = 80,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 27,
                            ItemId = 27,
                            Quantity = 85,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 28,
                            ItemId = 28,
                            Quantity = 90,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 29,
                            ItemId = 29,
                            Quantity = 95,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 30,
                            ItemId = 30,
                            Quantity = 100,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 31,
                            ItemId = 31,
                            Quantity = 100,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 32,
                            ItemId = 32,
                            Quantity = 95,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 33,
                            ItemId = 33,
                            Quantity = 90,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 34,
                            ItemId = 34,
                            Quantity = 85,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
                        },
                        new
                        {
                            Id = 35,
                            ItemId = 35,
                            Quantity = 80,
                            UpdateTime = new DateTime(2024, 11, 24, 0, 3, 36, 705, DateTimeKind.Local).AddTicks(3043)
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
