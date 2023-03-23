﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using baithuchanh2003.Data;

#nullable disable

namespace baithuchanh2003.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230323043059_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("baithuchanh2003.Models.Student", b =>
                {
                    b.Property<string>("StudentCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StudentCode");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}