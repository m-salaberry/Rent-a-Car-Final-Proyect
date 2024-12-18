﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241129203032_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entity.model.Car", b =>
                {
                    b.Property<string>("plate")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("kilometers")
                        .HasColumnType("int");

                    b.Property<string>("model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("pricePerDay")
                        .HasColumnType("float");

                    b.Property<int>("year")
                        .HasColumnType("int");

                    b.HasKey("plate");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Entity.model.Client", b =>
                {
                    b.Property<long>("Dni")
                        .HasColumnType("bigint");

                    b.Property<bool>("BlackList")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LicenseValidDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantityOfRents")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Dni");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Entity.model.Insurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("TypeOfInsurance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Insurances");
                });

            modelBuilder.Entity("Entity.model.Rent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("FinalPrice")
                        .HasColumnType("float");

                    b.Property<long>("IdClient")
                        .HasColumnType("bigint");

                    b.Property<int>("IdInsurance")
                        .HasColumnType("int");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("RentDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdClient");

                    b.HasIndex("IdInsurance");

                    b.HasIndex("Plate");

                    b.ToTable("Rents");
                });

            modelBuilder.Entity("Entity.model.Rent", b =>
                {
                    b.HasOne("Entity.model.Client", "Client")
                        .WithMany()
                        .HasForeignKey("IdClient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.model.Insurance", "Insurance")
                        .WithMany()
                        .HasForeignKey("IdInsurance")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.model.Car", "Car")
                        .WithMany()
                        .HasForeignKey("Plate")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Client");

                    b.Navigation("Insurance");
                });
#pragma warning restore 612, 618
        }
    }
}
