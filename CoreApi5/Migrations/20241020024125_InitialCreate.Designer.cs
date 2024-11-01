﻿// <auto-generated />
using System;
using CoreApi5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoreApi5.Migrations
{
    [DbContext(typeof(DeviceDbContext))]
    [Migration("20241020024125_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoreApi5.Models.Device", b =>
                {
                    b.Property<int>("DeviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeviceId"));

                    b.Property<string>("DeviceName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("DeviceType")
                        .HasColumnType("int");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("Price")
                        .IsRequired()
                        .HasColumnType("money");

                    b.Property<DateTime?>("ReleaseDate")
                        .IsRequired()
                        .HasColumnType("date");

                    b.HasKey("DeviceId");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            DeviceId = 1,
                            DeviceName = "Sym",
                            DeviceType = 1,
                            InStock = true,
                            Picture = "1.jpg",
                            Price = 12000m,
                            ReleaseDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("CoreApi5.Models.Spec", b =>
                {
                    b.Property<int>("SpecId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpecId"));

                    b.Property<int>("DeviceId")
                        .HasColumnType("int");

                    b.Property<string>("SpecName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SpecValue")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SpecId");

                    b.HasIndex("DeviceId");

                    b.ToTable("Specs");

                    b.HasData(
                        new
                        {
                            SpecId = 1,
                            DeviceId = 1,
                            SpecName = "Ram",
                            SpecValue = "4GB"
                        },
                        new
                        {
                            SpecId = 2,
                            DeviceId = 1,
                            SpecName = "Storage",
                            SpecValue = "64GB"
                        });
                });

            modelBuilder.Entity("CoreApi5.Models.Spec", b =>
                {
                    b.HasOne("CoreApi5.Models.Device", "Devices")
                        .WithMany("Specs")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Devices");
                });

            modelBuilder.Entity("CoreApi5.Models.Device", b =>
                {
                    b.Navigation("Specs");
                });
#pragma warning restore 612, 618
        }
    }
}
