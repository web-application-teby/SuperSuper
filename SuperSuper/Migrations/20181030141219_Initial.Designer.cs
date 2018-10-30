﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuperSuper.Models;

namespace SuperSuper.Migrations
{
    [DbContext(typeof(SuperSuperContext))]
    [Migration("20181030141219_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SuperSuper.Models.CustomerBasket", b =>
                {
                    b.Property<string>("ProductName")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProductsCount");

                    b.HasKey("ProductName");

                    b.ToTable("CustomerBasket");
                });

            modelBuilder.Entity("SuperSuper.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Diet");

                    b.Property<bool>("Kosher");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<string>("Supplier");

                    b.Property<int>("category");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("SuperSuper.Models.Purcheses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<int>("ProductId");

                    b.Property<DateTime>("PurchesDate");

                    b.Property<bool>("Purchesed");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Purcheses");
                });

            modelBuilder.Entity("SuperSuper.Models.PurchesesView", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<string>("CustomerName");

                    b.Property<int>("ProductId");

                    b.Property<string>("ProductName");

                    b.Property<DateTime>("PurchesDate");

                    b.Property<bool>("Purchesed");

                    b.HasKey("Id");

                    b.ToTable("PurchesesView");
                });

            modelBuilder.Entity("SuperSuper.Models.SuperUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("EmailAdress");

                    b.Property<string>("Password");

                    b.Property<int>("UserName");

                    b.HasKey("Id");

                    b.ToTable("SuperUser");
                });

            modelBuilder.Entity("SuperSuper.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("UserType");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("SuperSuper.Models.Admin", b =>
                {
                    b.HasBaseType("SuperSuper.Models.User");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.ToTable("Admin");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("SuperSuper.Models.Customer", b =>
                {
                    b.HasBaseType("SuperSuper.Models.User");

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("EmailAddress")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("Customer_Password");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.Property<string>("confirmPassword");

                    b.ToTable("Customer");

                    b.HasDiscriminator().HasValue("Customer");
                });

            modelBuilder.Entity("SuperSuper.Models.Purcheses", b =>
                {
                    b.HasOne("SuperSuper.Models.Customer", "Customer")
                        .WithMany("Purcheses")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperSuper.Models.Product", "Product")
                        .WithMany("Purcheses")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}