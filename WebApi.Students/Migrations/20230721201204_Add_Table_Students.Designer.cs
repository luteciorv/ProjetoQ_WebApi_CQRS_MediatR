﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Students.Context;

#nullable disable

namespace Students.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230721201204_Add_Table_Students")]
    partial class Add_Table_Students
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Students.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Activated")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Students", (string)null);
                });

            modelBuilder.Entity("Students.Entities.Student", b =>
                {
                    b.OwnsOne("Students.ValueObjects.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("StudentId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("City");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Country");

                            b1.Property<string>("Number")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Number");

                            b1.Property<string>("State")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("State");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Street");

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("ZipCode");

                            b1.HasKey("StudentId");

                            b1.ToTable("Students");

                            b1.WithOwner()
                                .HasForeignKey("StudentId");
                        });

                    b.OwnsOne("Students.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<Guid>("StudentId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Address")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Email");

                            b1.Property<bool>("Confirmed")
                                .HasColumnType("bit")
                                .HasColumnName("ConfirmedEmail");

                            b1.HasKey("StudentId");

                            b1.ToTable("Students");

                            b1.WithOwner()
                                .HasForeignKey("StudentId");
                        });

                    b.OwnsOne("Students.ValueObjects.Perfil", "Perfil", b1 =>
                        {
                            b1.Property<Guid>("StudentId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Age")
                                .HasColumnType("int")
                                .HasColumnName("Age");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("FirstName");

                            b1.Property<int>("Gender")
                                .HasColumnType("int");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("LastName");

                            b1.HasKey("StudentId");

                            b1.ToTable("Students");

                            b1.WithOwner()
                                .HasForeignKey("StudentId");
                        });

                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Email")
                        .IsRequired();

                    b.Navigation("Perfil")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}