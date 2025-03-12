﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Data;

#nullable disable

namespace MvcMovie.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250312151154_Create_table_Daily")]
    partial class Create_table_Daily
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.2");

            modelBuilder.Entity("MvcMovie.Models.HeThongPhanPhoi", b =>
                {
                    b.Property<string>("MaHTPP")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenHTPP")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaHTPP");

                    b.ToTable("HeThongPhanPhoi");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("MvcMovie.Models.Person", b =>
                {
                    b.Property<string>("PersonId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("MvcMovie.Models.Daily", b =>
                {
                    b.HasBaseType("MvcMovie.Models.HeThongPhanPhoi");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MaDaiLy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenDaiLy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("DaiLy");
                });

            modelBuilder.Entity("MvcMovie.Models.Employee", b =>
                {
                    b.HasBaseType("MvcMovie.Models.Person");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("MvcMovie.Models.Daily", b =>
                {
                    b.HasOne("MvcMovie.Models.HeThongPhanPhoi", null)
                        .WithOne()
                        .HasForeignKey("MvcMovie.Models.Daily", "MaHTPP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MvcMovie.Models.Employee", b =>
                {
                    b.HasOne("MvcMovie.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("MvcMovie.Models.Employee", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
