﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RotaAPI.DataAccessLayer;

#nullable disable

namespace RotaAPI.Migrations
{
    [DbContext(typeof(RotaDbContext))]
    [Migration("20240214152704_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RotaAPI.Models.Assignment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("assignment_dt")
                        .HasColumnType("datetime2");

                    b.Property<int>("client_id")
                        .HasColumnType("int");

                    b.Property<string>("comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("completed_ind")
                        .HasColumnType("nvarchar(1)");

                    b.Property<DateTime?>("end_time")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("hours_onsite")
                        .HasColumnType("datetime2");

                    b.Property<string>("late_ind")
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("person_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("start_time")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("assignments");
                });

            modelBuilder.Entity("RotaAPI.Models.Certification", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("acquired_dt")
                        .HasColumnType("datetime2");

                    b.Property<string>("certification_active_ind")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("certification_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("expired_dt")
                        .HasColumnType("datetime2");

                    b.Property<int>("person_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("certifications");
                });

            modelBuilder.Entity("RotaAPI.Models.Client", b =>
                {
                    b.Property<DateTime>("Acquired_dt")
                        .HasColumnType("datetime2");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("client_active")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("client_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.ToTable("clients");
                });

            modelBuilder.Entity("RotaAPI.Models.Indicator", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("indicator_desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("indicator_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("indicator_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("indicators");
                });

            modelBuilder.Entity("RotaAPI.Models.Person", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date_of_birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employment_his")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("health_dec_ind")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("home_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role_ind")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("user_active_ind")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("id");

                    b.ToTable("people");
                });
#pragma warning restore 612, 618
        }
    }
}
