﻿// <auto-generated />
using ClothingSizeApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClothingSizeApi.Migrations
{
    [DbContext(typeof(ClothingSizeApiContext))]
    [Migration("20220427023413_TestMigration1")]
    partial class TestMigration1
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
                            Gender = "female",
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
                            Gender = "male",
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
                            Gender = "female",
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
                            Gender = "male",
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
                            Gender = "male",
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
                            Gender = "male",
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
                            Gender = "female",
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
                            Gender = "female",
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
#pragma warning restore 612, 618
        }
    }
}