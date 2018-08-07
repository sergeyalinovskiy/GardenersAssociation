﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SA.GA.DataAccess.Context.Implementation;

namespace SA.GA.WebApp.Migrations
{
    [DbContext(typeof(DataAccess.Context.Implementation.AppContext2))]
    partial class AppContext2ModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SA.GA.Common.Models.Electricity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BankCollections")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnName("BankCollections")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal>("Losses")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnName("Losses")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("Mounth")
                        .HasColumnName("Mounth")
                        .HasColumnType("int");

                    b.Property<decimal>("NecessaryToPlay")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnName("NecessaryToPlay")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal>("Paid")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnName("Paid")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal>("PreviousTestimony")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnName("PreviousTestimony")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("RateId")
                        .HasColumnName("RateId")
                        .HasColumnType("int");

                    b.Property<decimal>("RecentTestimony")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnName("RecentTestimony")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("Year")
                        .HasColumnName("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RateId");

                    b.ToTable("Electricity");
                });

            modelBuilder.Entity("SA.GA.Common.Models.History", b =>
                {
                    b.Property<int>("Id");

                    b.Property<DateTime>("From")
                        .HasColumnName("From")
                        .HasColumnType("datetime");

                    b.Property<int>("PlotId")
                        .HasColumnName("PlotId")
                        .HasColumnType("int");

                    b.Property<DateTime>("To")
                        .HasColumnName("To")
                        .HasColumnType("datetime");

                    b.Property<int>("UserId")
                        .HasColumnName("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("History");
                });

            modelBuilder.Entity("SA.GA.Common.Models.Plot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Area")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnName("Area")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("ElectricityId")
                        .HasColumnName("ElectricityId")
                        .HasColumnType("int");

                    b.Property<bool>("Privatized")
                        .HasColumnName("Privatized")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnName("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ElectricityId");

                    b.HasIndex("UserId");

                    b.ToTable("Plot");
                });

            modelBuilder.Entity("SA.GA.Common.Models.Rate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("From")
                        .HasColumnName("From")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("To")
                        .HasColumnName("To")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Value")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnName("Value")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("Id");

                    b.ToTable("Rate");
                });

            modelBuilder.Entity("SA.GA.Common.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalInformation")
                        .IsRequired()
                        .HasColumnName("AdditionalInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("Address")
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("FirstName")
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("LastName")
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnName("MiddleName")
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnName("PhoneNumber")
                        .HasColumnType("nvarchar(64)");

                    b.Property<bool>("Status")
                        .HasColumnName("UserStatus")
                        .HasColumnType("bit");

                    b.Property<bool>("SuppliedElectricity")
                        .HasColumnName("SuppliedElectricity")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("SA.GA.Common.Models.Electricity", b =>
                {
                    b.HasOne("SA.GA.Common.Models.Rate", "Rate")
                        .WithMany("Electricity")
                        .HasForeignKey("RateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SA.GA.Common.Models.History", b =>
                {
                    b.HasOne("SA.GA.Common.Models.Plot", "Plot")
                        .WithMany("Historys")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SA.GA.Common.Models.User", "User")
                        .WithMany("Historys")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SA.GA.Common.Models.Plot", b =>
                {
                    b.HasOne("SA.GA.Common.Models.Electricity", "Electricity")
                        .WithMany("Plot")
                        .HasForeignKey("ElectricityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SA.GA.Common.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
