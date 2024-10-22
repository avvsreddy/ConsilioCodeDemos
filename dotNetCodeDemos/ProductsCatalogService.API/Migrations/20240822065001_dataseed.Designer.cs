﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductsCatalogService.API.Model.Data;

#nullable disable

namespace ProductsCatalogService.API.Migrations
{
    [DbContext(typeof(ProductsDbContext))]
    [Migration("20240822065001_dataseed")]
    partial class dataseed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductsCatalogService.API.Model.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Brand = "TechBrand",
                            Category = "Electronics",
                            Country = "USA",
                            Description = "Latest model with high-resolution camera and fast processor",
                            IsAvailable = true,
                            Name = "Smartphone X1",
                            Price = 799
                        },
                        new
                        {
                            ProductId = 2,
                            Brand = "ComputeTech",
                            Category = "Computers",
                            Country = "Germany",
                            Description = "Powerful laptop with 16GB RAM and 512GB SSD",
                            IsAvailable = true,
                            Name = "Laptop Pro 15",
                            Price = 1299
                        },
                        new
                        {
                            ProductId = 3,
                            Brand = "SoundGear",
                            Category = "Accessories",
                            Country = "Japan",
                            Description = "Noise-cancelling over-ear headphones with long battery life",
                            IsAvailable = false,
                            Name = "Wireless Headphones",
                            Price = 199
                        },
                        new
                        {
                            ProductId = 4,
                            Brand = "ViewMax",
                            Category = "Electronics",
                            Country = "South Korea",
                            Description = "Ultra HD 4K Smart TV with built-in streaming apps",
                            IsAvailable = true,
                            Name = "Smart TV 55\"",
                            Price = 499
                        },
                        new
                        {
                            ProductId = 5,
                            Brand = "SportX",
                            Category = "Sportswear",
                            Country = "India",
                            Description = "Comfortable and durable running shoes with excellent grip",
                            IsAvailable = true,
                            Name = "Running Shoes",
                            Price = 120
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
