﻿// <auto-generated />
using System;
using AdventureLandWebapp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdventureLandWebapp.Migrations
{
    [DbContext(typeof(AdventureLandWebappContext))]
    [Migration("20231017013701_testy3")]
    partial class testy3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AdventureLandWebapp.Models.ATTRACTION", b =>
                {
                    b.Property<int>("AttractionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AttractionID"));

                    b.Property<int>("Age_Req")
                        .HasColumnType("int");

                    b.Property<string>("AttractionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("Close_Time")
                        .HasColumnType("datetime2");

                    b.Property<int>("Height_Req_Inches")
                        .HasColumnType("int");

                    b.Property<DateTime>("Last_Maintained")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Open_Time")
                        .HasColumnType("datetime2");

                    b.HasKey("AttractionID");

                    b.ToTable("ATTRACTION");
                });

            modelBuilder.Entity("AdventureLandWebapp.Models.ATTRACTION_EMPLOYEE", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AttractionID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ATTRACTION_EMPLOYEE");
                });

            modelBuilder.Entity("AdventureLandWebapp.Models.EMPLOYEE", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<int>("Auth_Level")
                        .HasColumnType("int");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Hourly_Wage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone_Number")
                        .HasColumnType("int");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("SSN")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SuperID")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.ToTable("EMPLOYEE");
                });

            modelBuilder.Entity("AdventureLandWebapp.Models.EVENT", b =>
                {
                    b.Property<int>("EventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventID"));

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Event_Ended")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Event_Started")
                        .HasColumnType("datetime2");

                    b.Property<int>("VenueID")
                        .HasColumnType("int");

                    b.HasKey("EventID");

                    b.ToTable("EVENT");
                });

            modelBuilder.Entity("AdventureLandWebapp.Models.EVENT_WORK_REC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Work_Completed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Work_Started")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("EVENT_WORK_REC");
                });

            modelBuilder.Entity("AdventureLandWebapp.Models.MAINTENENCE_PERSONNEL_REC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("Maint_RecID")
                        .HasColumnType("int");

                    b.Property<DateTime>("work_ended")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("work_started")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MAINTENENCE_PERSONNEL_REC");
                });

            modelBuilder.Entity("AdventureLandWebapp.Models.MAINTENENCE_REC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AttractionID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Main_Ended")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Main_Started")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MAINTENENCE_REC");
                });

            modelBuilder.Entity("AdventureLandWebapp.Models.SHOP", b =>
                {
                    b.Property<int>("ShopID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShopID"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone_Number")
                        .HasColumnType("int");

                    b.Property<string>("ShopName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShopID");

                    b.ToTable("SHOP");
                });

            modelBuilder.Entity("AdventureLandWebapp.Models.SHOP_EMPLOYEE", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ShopID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SHOP_EMPLOYEE");
                });

            modelBuilder.Entity("AdventureLandWebapp.Models.SHOP_INVENTORY_ITEM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ShopID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Sold_On")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Stocked_On")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SHOP_INVENTORY_ITEM");
                });
#pragma warning restore 612, 618
        }
    }
}