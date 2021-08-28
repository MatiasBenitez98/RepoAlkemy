﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoAlkemy.Contexts;

namespace ProyectoAlkemy.Migrations
{
    [DbContext(typeof(ContextGeo))]
    [Migration("20210827231958_Primera")]
    partial class Primera
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProyectoAlkemy.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CantHabitantes")
                        .HasColumnType("int");

                    b.Property<int?>("ContinentId")
                        .HasColumnType("int");

                    b.Property<string>("Denomination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SuperfTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ContinentId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("ProyectoAlkemy.Entities.Continent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Denomination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Continents");
                });

            modelBuilder.Entity("ProyectoAlkemy.Entities.GeographicIcons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Denomination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("History")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("GeocIcons");
                });

            modelBuilder.Entity("ProyectoAlkemy.Entities.City", b =>
                {
                    b.HasOne("ProyectoAlkemy.Entities.Continent", "Continent")
                        .WithMany("Cities")
                        .HasForeignKey("ContinentId");

                    b.Navigation("Continent");
                });

            modelBuilder.Entity("ProyectoAlkemy.Entities.GeographicIcons", b =>
                {
                    b.HasOne("ProyectoAlkemy.Entities.City", "City")
                        .WithMany("GeoIcons")
                        .HasForeignKey("CityId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("ProyectoAlkemy.Entities.City", b =>
                {
                    b.Navigation("GeoIcons");
                });

            modelBuilder.Entity("ProyectoAlkemy.Entities.Continent", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}