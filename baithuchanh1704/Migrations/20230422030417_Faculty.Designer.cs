﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Data;

#nullable disable

namespace baithuchanh1704.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    [Migration("20230422030417_Faculty")]
    partial class Faculty
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("baithuchanh1704.Models.Address", b =>
                {
                    b.Property<string>("AddressID")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressNane")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AddressID");

                    b.ToTable("Adđress");
                });

            modelBuilder.Entity("baithuchanh1704.Models.Faculty", b =>
                {
                    b.Property<string>("FacultyID")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("FacultyID");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("baithuchanh1704.Models.Sex", b =>
                {
                    b.Property<string>("SexID")
                        .HasColumnType("TEXT");

                    b.Property<string>("SexName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SexID");

                    b.ToTable("Sex");
                });

            modelBuilder.Entity("baithuchanh1704.Models.Student", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FacultyID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SexID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StudentID");

                    b.HasIndex("AddressID");

                    b.HasIndex("FacultyID");

                    b.HasIndex("SexID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("baithuchanh1704.Models.Student", b =>
                {
                    b.HasOne("baithuchanh1704.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("baithuchanh1704.Models.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("baithuchanh1704.Models.Sex", "Sex")
                        .WithMany()
                        .HasForeignKey("SexID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Faculty");

                    b.Navigation("Sex");
                });
#pragma warning restore 612, 618
        }
    }
}
