﻿// <auto-generated />
using System;
using App_Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App_Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240914014808_Create_DB")]
    partial class Create_DB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("App_Data.Models.HDCT", b =>
                {
                    b.Property<Guid>("IDSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDHD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("DonGia")
                        .HasColumnType("bigint");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IDSP", "IDHD");

                    b.HasIndex("IDHD");

                    b.ToTable("HDCTS");
                });

            modelBuilder.Entity("App_Data.Models.HoaDon", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreateDate");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime2");

                    b.Property<long>("TongTien")
                        .HasColumnType("bigint");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("HoaDons");
                });

            modelBuilder.Entity("App_Data.Models.SanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Gia")
                        .HasColumnType("bigint");

                    b.Property<string>("HangSX")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mota")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SanPhams");
                });

            modelBuilder.Entity("App_Data.Models.HDCT", b =>
                {
                    b.HasOne("App_Data.Models.HoaDon", "HoaDon")
                        .WithMany("HDCTs")
                        .HasForeignKey("IDHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_HDCT_HD");

                    b.HasOne("App_Data.Models.SanPham", "SanPham")
                        .WithMany("HDCTs")
                        .HasForeignKey("IDSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_HDCT_SP");

                    b.Navigation("HoaDon");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("App_Data.Models.HoaDon", b =>
                {
                    b.Navigation("HDCTs");
                });

            modelBuilder.Entity("App_Data.Models.SanPham", b =>
                {
                    b.Navigation("HDCTs");
                });
#pragma warning restore 612, 618
        }
    }
}
