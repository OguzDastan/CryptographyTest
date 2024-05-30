﻿// <auto-generated />
using System;
using CryptographyTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CryptographyTest.Migrations
{
    [DbContext(typeof(DetectiveApiDbContext))]
    [Migration("20240530194118_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("CryptographyTest.Models.Case", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DetectiveId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SupervisorId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DetectiveId");

                    b.HasIndex("SupervisorId");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("CryptographyTest.Models.ContactPerson", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ContactPersons");
                });

            modelBuilder.Entity("CryptographyTest.Models.Tip", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CaseId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ContactPersonId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LogDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CaseId");

                    b.HasIndex("ContactPersonId");

                    b.ToTable("Tips");
                });

            modelBuilder.Entity("CryptographyTest.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("BadgeNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CryptographyTest.Models.Case", b =>
                {
                    b.HasOne("CryptographyTest.Models.User", "Detective")
                        .WithMany()
                        .HasForeignKey("DetectiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CryptographyTest.Models.User", "Supervisor")
                        .WithMany()
                        .HasForeignKey("SupervisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Detective");

                    b.Navigation("Supervisor");
                });

            modelBuilder.Entity("CryptographyTest.Models.Tip", b =>
                {
                    b.HasOne("CryptographyTest.Models.Case", null)
                        .WithMany("Tips")
                        .HasForeignKey("CaseId");

                    b.HasOne("CryptographyTest.Models.ContactPerson", "ContactPerson")
                        .WithMany()
                        .HasForeignKey("ContactPersonId");

                    b.Navigation("ContactPerson");
                });

            modelBuilder.Entity("CryptographyTest.Models.Case", b =>
                {
                    b.Navigation("Tips");
                });
#pragma warning restore 612, 618
        }
    }
}
