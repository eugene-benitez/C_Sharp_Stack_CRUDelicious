﻿// <auto-generated />
using System;
using CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUDelicious.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CRUDelicious.Models.Dishes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Calories")
                        .IsRequired();

                    b.Property<string>("Chef")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Tastiness")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("id");

                    b.ToTable("Dishes");
                });
#pragma warning restore 612, 618
        }
    }
}
