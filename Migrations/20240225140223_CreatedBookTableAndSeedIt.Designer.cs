﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestAPI.Data;

#nullable disable

namespace RestAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240225140223_CreatedBookTableAndSeedIt")]
    partial class CreatedBookTableAndSeedIt
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RestAPI.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LaunchDate")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "John Doe",
                            LaunchDate = new DateTime(2023, 8, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7159),
                            Price = 29.99m,
                            Title = "The Art of Programming"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Jane Smith",
                            LaunchDate = new DateTime(2023, 2, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7186),
                            Price = 19.99m,
                            Title = "Data Science Basics"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Robert Johnson",
                            LaunchDate = new DateTime(2023, 11, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7189),
                            Price = 24.99m,
                            Title = "Machine Learning Fundamentals"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Emily White",
                            LaunchDate = new DateTime(2023, 5, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7192),
                            Price = 14.99m,
                            Title = "Web Development Essentials"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Michael Brown",
                            LaunchDate = new DateTime(2023, 7, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7194),
                            Price = 39.99m,
                            Title = "Deep Learning Techniques"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Sophia Davis",
                            LaunchDate = new DateTime(2023, 9, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7198),
                            Price = 17.99m,
                            Title = "Introduction to C# Programming"
                        },
                        new
                        {
                            Id = 7,
                            Author = "Daniel Wilson",
                            LaunchDate = new DateTime(2023, 4, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7200),
                            Price = 32.99m,
                            Title = "The Art of Database Design"
                        },
                        new
                        {
                            Id = 8,
                            Author = "Olivia Taylor",
                            LaunchDate = new DateTime(2023, 6, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7203),
                            Price = 21.99m,
                            Title = "Agile Software Development"
                        },
                        new
                        {
                            Id = 9,
                            Author = "Ethan Miller",
                            LaunchDate = new DateTime(2023, 10, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7205),
                            Price = 27.99m,
                            Title = "iOS App Development Guide"
                        },
                        new
                        {
                            Id = 10,
                            Author = "Ava Martinez",
                            LaunchDate = new DateTime(2023, 3, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7209),
                            Price = 19.99m,
                            Title = "JavaScript for Beginners"
                        },
                        new
                        {
                            Id = 11,
                            Author = "Liam Anderson",
                            LaunchDate = new DateTime(2023, 12, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7211),
                            Price = 34.99m,
                            Title = "Python Programming Mastery"
                        },
                        new
                        {
                            Id = 12,
                            Author = "Emma Harris",
                            LaunchDate = new DateTime(2024, 1, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7213),
                            Price = 23.99m,
                            Title = "UI/UX Design Principles"
                        },
                        new
                        {
                            Id = 13,
                            Author = "Jackson Turner",
                            LaunchDate = new DateTime(2023, 6, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7216),
                            Price = 29.99m,
                            Title = "Network Security Essentials"
                        },
                        new
                        {
                            Id = 14,
                            Author = "Grace Murphy",
                            LaunchDate = new DateTime(2023, 7, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7219),
                            Price = 26.99m,
                            Title = "Android App Development Basics"
                        },
                        new
                        {
                            Id = 15,
                            Author = "Carter Wright",
                            LaunchDate = new DateTime(2023, 11, 25, 11, 2, 23, 203, DateTimeKind.Local).AddTicks(7221),
                            Price = 31.99m,
                            Title = "Cybersecurity Fundamentals"
                        });
                });

            modelBuilder.Entity("RestAPI.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "São Paulo - Brasil",
                            FirstName = "Ayrton",
                            Gender = "Male",
                            LastName = "Senna"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Anchiano - Italy",
                            FirstName = "Leonardo",
                            Gender = "Male",
                            LastName = "da Vinci"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Porbandar - India",
                            FirstName = "Mahatma",
                            Gender = "Male",
                            LastName = "Gandh"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Kentucky - USA",
                            FirstName = "Mohamed",
                            Gender = "Male",
                            LastName = "Gandhi"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Mvezo - South Africa",
                            FirstName = "Nelson",
                            Gender = "Male",
                            LastName = "Mandela"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
