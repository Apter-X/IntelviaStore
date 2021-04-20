﻿// <auto-generated />
using System;
using IntelviaStore.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IntelviaStore.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210419101100_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IntelviaStore.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverPhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Book"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Watch"
                        });
                });

            modelBuilder.Entity("IntelviaStore.Models.Photo", b =>
                {
                    b.Property<int>("PhotoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OfTheProductID")
                        .HasColumnType("int");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("PhotoID");

                    b.HasIndex("ProductID");

                    b.ToTable("Galery");

                    b.HasData(
                        new
                        {
                            PhotoID = 1,
                            OfTheProductID = 1,
                            PhotoPath = "images/watch01.png"
                        },
                        new
                        {
                            PhotoID = 2,
                            OfTheProductID = 2,
                            PhotoPath = "images/watch02.png"
                        },
                        new
                        {
                            PhotoID = 3,
                            OfTheProductID = 3,
                            PhotoPath = "images/book01.png"
                        },
                        new
                        {
                            PhotoID = 4,
                            OfTheProductID = 4,
                            PhotoPath = "images/book02.png"
                        });
                });

            modelBuilder.Entity("IntelviaStore.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int>("CreatedByUserID")
                        .HasColumnType("int");

                    b.Property<int>("IncludeInCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            CreatedByUserID = 0,
                            IncludeInCategoryID = 1,
                            ProductDescription = "Peut - être le temps est - il très proche où l'on s'avisera que la pierre angulaire des édifices sublimes et inconditionnés que les philosophes dogmatiques",
                            ProductName = "Par-delà bien et mal",
                            UnitPrice = 8.5999999999999996,
                            UpdatedOn = new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProductID = 2,
                            CreatedByUserID = 0,
                            IncludeInCategoryID = 1,
                            ProductDescription = "Alain Soral dérange, agace, mais il l'un des rares penseurs de sa génération à se poser et à poser les bonnes questions : celles qui font mal, parfois, et surtout celle que l'on n'aime pas s'entendre poser.",
                            ProductName = "Comprendre l'Empire",
                            UnitPrice = 15.5,
                            UpdatedOn = new DateTime(2011, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProductID = 3,
                            CreatedByUserID = 0,
                            IncludeInCategoryID = 2,
                            ProductDescription = "Sivis pasem para belum.",
                            ProductName = "Festina Chronograph",
                            UnitPrice = 79.989999999999995,
                            UpdatedOn = new DateTime(2019, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProductID = 4,
                            CreatedByUserID = 0,
                            IncludeInCategoryID = 2,
                            ProductDescription = "Lorem Ipsum Mostrious Giligitamous.",
                            ProductName = "Swatch Originals Big Bold Jellyfish",
                            UnitPrice = 189.99000000000001,
                            UpdatedOn = new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("IntelviaStore.Models.Photo", b =>
                {
                    b.HasOne("IntelviaStore.Models.Product", null)
                        .WithMany("Galery")
                        .HasForeignKey("ProductID");
                });

            modelBuilder.Entity("IntelviaStore.Models.Product", b =>
                {
                    b.HasOne("IntelviaStore.Models.Category", null)
                        .WithMany("Product")
                        .HasForeignKey("CategoryID");
                });

            modelBuilder.Entity("IntelviaStore.Models.Category", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("IntelviaStore.Models.Product", b =>
                {
                    b.Navigation("Galery");
                });
#pragma warning restore 612, 618
        }
    }
}