﻿// <auto-generated />
using ClothingSizeApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClothingSizeApi.Migrations
{
    [DbContext(typeof(ClothingSizeApiContext))]
    [Migration("20220504020153_SizeUpdate")]
    partial class SizeUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ClothingSizeApi.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClothingType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("L")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("M")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("S")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("XL")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("XS")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("XXL")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("XXS")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("XXXL")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("XXXS")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("XXXXL")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            BrandId = 1,
                            ClothingType = "top",
                            Gender = "mens",
                            L = "12",
                            M = "6",
                            Name = "Gap",
                            S = "2",
                            XL = "16",
                            XS = "0",
                            XXL = "18",
                            XXS = "0",
                            XXXL = "20",
                            XXXS = "00",
                            XXXXL = "24"
                        },
                        new
                        {
                            BrandId = 2,
                            ClothingType = "top",
                            Gender = "mens",
                            L = "12",
                            M = "6",
                            Name = "Gap",
                            S = "2",
                            XL = "16",
                            XS = "0",
                            XXL = "18",
                            XXS = "0",
                            XXXL = "20",
                            XXXS = "00",
                            XXXXL = "24"
                        },
                        new
                        {
                            BrandId = 3,
                            ClothingType = "bottom",
                            Gender = "mens",
                            L = "12",
                            M = "6",
                            Name = "Gap",
                            S = "2",
                            XL = "16",
                            XS = "0",
                            XXL = "18",
                            XXS = "0",
                            XXXL = "20",
                            XXXS = "00",
                            XXXXL = "24"
                        },
                        new
                        {
                            BrandId = 4,
                            ClothingType = "bottom",
                            Gender = "mens",
                            L = "12",
                            M = "6",
                            Name = "Gap",
                            S = "2",
                            XL = "16",
                            XS = "0",
                            XXL = "18",
                            XXS = "0",
                            XXXL = "20",
                            XXXS = "00",
                            XXXXL = "24"
                        },
                        new
                        {
                            BrandId = 5,
                            ClothingType = "top",
                            Gender = "mens",
                            L = "36R",
                            M = "34R",
                            Name = "H&M",
                            S = "32R",
                            XL = "44R",
                            XS = "26R",
                            XXL = "46R",
                            XXS = "n/a",
                            XXXL = " 48R",
                            XXXS = "n/a",
                            XXXXL = "50R"
                        },
                        new
                        {
                            BrandId = 6,
                            ClothingType = "top",
                            Gender = "mens",
                            L = "12",
                            M = "6",
                            Name = "H&M",
                            S = "2",
                            XL = "16",
                            XS = "0",
                            XXL = "18",
                            XXS = "0",
                            XXXL = "20",
                            XXXS = "00",
                            XXXXL = "24"
                        },
                        new
                        {
                            BrandId = 7,
                            ClothingType = "bottom",
                            Gender = "womens",
                            L = "12",
                            M = "6",
                            Name = "H&M",
                            S = "2",
                            XL = "16",
                            XS = "0",
                            XXL = "18",
                            XXS = "0",
                            XXXL = "20",
                            XXXS = "00",
                            XXXXL = "24"
                        },
                        new
                        {
                            BrandId = 8,
                            ClothingType = "bottom",
                            Gender = "womens",
                            L = "12",
                            M = "6",
                            Name = "H&M",
                            S = "2",
                            XL = "16",
                            XS = "0",
                            XXL = "18",
                            XXS = "0",
                            XXXL = "20",
                            XXXS = "00",
                            XXXXL = "24"
                        });
                });

            modelBuilder.Entity("ClothingSizeApi.Models.Size", b =>
                {
                    b.Property<int>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Chest")
                        .HasColumnType("int");

                    b.Property<string>("ClothingType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Hip")
                        .HasColumnType("int");

                    b.Property<int>("Inseam")
                        .HasColumnType("int");

                    b.Property<string>("LetterSize")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Neck")
                        .HasColumnType("double");

                    b.Property<int>("Sleeve")
                        .HasColumnType("int");

                    b.Property<int>("Waist")
                        .HasColumnType("int");

                    b.HasKey("SizeId");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            SizeId = 1,
                            Brand = "Gap",
                            Chest = 38,
                            ClothingType = "top",
                            Gender = "womens",
                            Hip = 30,
                            Inseam = 31,
                            LetterSize = "s",
                            Neck = 15.0,
                            Sleeve = 32,
                            Waist = 32
                        },
                        new
                        {
                            SizeId = 2,
                            Brand = "H&M",
                            Chest = 38,
                            ClothingType = "top",
                            Gender = "mens",
                            Hip = 30,
                            Inseam = 31,
                            LetterSize = "s",
                            Neck = 16.0,
                            Sleeve = 32,
                            Waist = 32
                        },
                        new
                        {
                            SizeId = 3,
                            Brand = "Gap",
                            Chest = 38,
                            ClothingType = "bottom",
                            Gender = "womens",
                            Hip = 30,
                            Inseam = 31,
                            LetterSize = "s",
                            Neck = 15.5,
                            Sleeve = 32,
                            Waist = 32
                        },
                        new
                        {
                            SizeId = 4,
                            Brand = "H&M",
                            Chest = 40,
                            ClothingType = "bottom",
                            Gender = "mens",
                            Hip = 30,
                            Inseam = 32,
                            LetterSize = "m",
                            Neck = 16.0,
                            Sleeve = 33,
                            Waist = 34
                        },
                        new
                        {
                            SizeId = 5,
                            Brand = "Gap",
                            Chest = 40,
                            ClothingType = "top",
                            Gender = "mens",
                            Hip = 30,
                            Inseam = 32,
                            LetterSize = "m",
                            Neck = 16.5,
                            Sleeve = 33,
                            Waist = 34
                        },
                        new
                        {
                            SizeId = 6,
                            Brand = "H&M",
                            Chest = 40,
                            ClothingType = "top",
                            Gender = "mens",
                            Hip = 30,
                            Inseam = 32,
                            LetterSize = "m",
                            Neck = 16.0,
                            Sleeve = 33,
                            Waist = 34
                        },
                        new
                        {
                            SizeId = 7,
                            Brand = "Gap",
                            Chest = 42,
                            ClothingType = "bottom",
                            Gender = "womens",
                            Hip = 30,
                            Inseam = 34,
                            LetterSize = "l",
                            Neck = 16.5,
                            Sleeve = 34,
                            Waist = 36
                        },
                        new
                        {
                            SizeId = 8,
                            Brand = "H&M",
                            Chest = 42,
                            ClothingType = "bottom",
                            Gender = "womens",
                            Hip = 30,
                            Inseam = 34,
                            LetterSize = "l",
                            Neck = 17.0,
                            Sleeve = 34,
                            Waist = 36
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
