﻿// <auto-generated />
using System;
using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryManagement.Migrations
{
    [DbContext(typeof(LibraryDataBaseContext))]
    partial class LibraryDataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LibraryManagement.Models.BookDetails", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<int?>("Price")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Published")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("BookId");

                    b.ToTable("bookDetails");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Author = "Sanjay",
                            BookName = "DSP",
                            Category = 2,
                            Price = 1000,
                            Published = 1983,
                            Updated = new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            isDeleted = false
                        },
                        new
                        {
                            BookId = 2,
                            Author = "Sam",
                            BookName = "CNS",
                            Category = 1,
                            Price = 1000,
                            Published = 1993,
                            Updated = new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            isDeleted = false
                        },
                        new
                        {
                            BookId = 3,
                            Author = "Ram",
                            BookName = "AI",
                            Category = 0,
                            Price = 1000,
                            Published = 2013,
                            Updated = new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            isDeleted = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
