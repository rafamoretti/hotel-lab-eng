﻿// <auto-generated />
using System;
using AppConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220609173008_AddedRelatioshipCheckInGuest")]
    partial class AddedRelatioshipCheckInGuest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("Model.CheckIn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Cost")
                        .HasColumnType("double");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CheckIns");
                });

            modelBuilder.Entity("Model.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Model.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CheckInId")
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomId")
                        .IsUnique();

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Model.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Model.Guest", b =>
                {
                    b.HasOne("Model.CheckIn", "CheckIn")
                        .WithOne("Guest")
                        .HasForeignKey("Model.Guest", "RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Room", "Room")
                        .WithOne("Guest")
                        .HasForeignKey("Model.Guest", "RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CheckIn");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Model.Product", b =>
                {
                    b.HasOne("Model.Room", null)
                        .WithMany("Products")
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("Model.CheckIn", b =>
                {
                    b.Navigation("Guest");
                });

            modelBuilder.Entity("Model.Room", b =>
                {
                    b.Navigation("Guest");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
