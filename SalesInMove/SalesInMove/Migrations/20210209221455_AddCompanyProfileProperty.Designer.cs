﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SalesInMove.DatabaseRelated;

namespace SalesInMove.Migrations
{
    [DbContext(typeof(SalesmenDbContext))]
    [Migration("20210209221455_AddCompanyProfileProperty")]
    partial class AddCompanyProfileProperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SalesInMove.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<long>("AnnualNettoIncome")
                        .HasColumnType("bigint");

                    b.Property<string>("CompanyProfile")
                        .HasColumnType("text");

                    b.Property<string>("EmployeeOpinions")
                        .HasColumnType("text");

                    b.Property<string>("Headquarter")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("NumberOfSalesman")
                        .HasColumnType("integer");

                    b.Property<int>("PositionId")
                        .HasColumnType("integer");

                    b.Property<long>("Registry")
                        .HasColumnType("bigint");

                    b.Property<bool>("SalesSupport")
                        .HasColumnType("boolean");

                    b.Property<string>("Sector")
                        .HasColumnType("text");

                    b.Property<long>("TaxNumber")
                        .HasMaxLength(11)
                        .HasColumnType("bigint");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("YearOfFoundation")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("CompanyId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            CompanyId = 12,
                            AnnualNettoIncome = 2000321865L,
                            EmployeeOpinions = "Good;Bad;Terrific!;Horrific!",
                            Headquarter = "Halásztelek",
                            Name = "Markoó Kft.",
                            NumberOfSalesman = 10,
                            PositionId = 3,
                            Registry = 109321480L,
                            SalesSupport = true,
                            TaxNumber = 24767107243L,
                            UserId = "0",
                            YearOfFoundation = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("SalesInMove.Models.Position", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("BossExpectations")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Expectations")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("OtherBenefits")
                        .HasColumnType("text");

                    b.Property<bool>("ProgressionSupport")
                        .HasColumnType("boolean");

                    b.Property<string>("Wages")
                        .HasColumnType("text");

                    b.Property<string>("WorkHour")
                        .HasColumnType("text");

                    b.Property<int>("WorkHourRatioId")
                        .HasColumnType("integer");

                    b.HasKey("PositionId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("WorkHourRatioId")
                        .IsUnique();

                    b.ToTable("Position");

                    b.HasData(
                        new
                        {
                            PositionId = 3,
                            BossExpectations = "Be good and reliable!",
                            City = "Halásztelek",
                            Description = "Good",
                            Name = "Sales manager",
                            OtherBenefits = "Laptop and car",
                            ProgressionSupport = true,
                            WorkHour = "Full",
                            WorkHourRatioId = 4
                        });
                });

            modelBuilder.Entity("SalesInMove.Models.WorkHourRatio", b =>
                {
                    b.Property<int>("WorkHourRatioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<byte>("DrivingHours")
                        .HasColumnType("smallint");

                    b.Property<byte>("HomeOfficeHours")
                        .HasColumnType("smallint");

                    b.Property<byte>("OfficeHours")
                        .HasColumnType("smallint");

                    b.Property<int>("WorkHoursPerMonth")
                        .HasColumnType("integer");

                    b.HasKey("WorkHourRatioId");

                    b.ToTable("WorkHourRatio");

                    b.HasData(
                        new
                        {
                            WorkHourRatioId = 4,
                            DrivingHours = (byte)20,
                            HomeOfficeHours = (byte)100,
                            OfficeHours = (byte)64,
                            WorkHoursPerMonth = 184
                        });
                });

            modelBuilder.Entity("SalesInMove.Models.Account", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("Account");
                });

            modelBuilder.Entity("SalesInMove.Models.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("User_Password");

                    b.Property<int>("UserType")
                        .HasColumnType("integer");

                    b.HasDiscriminator().HasValue("User");

                    b.HasData(
                        new
                        {
                            Id = "0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dbff3fee-b160-40b0-ac32-5add4d384132",
                            Email = "marko@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ff7314d5-b1d7-4751-b578-4d7d6a1ce41e",
                            TwoFactorEnabled = false,
                            Password = "Asd123",
                            UserType = 2
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SalesInMove.Models.Company", b =>
                {
                    b.HasOne("SalesInMove.Models.User", "User")
                        .WithOne("Company")
                        .HasForeignKey("SalesInMove.Models.Company", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SalesInMove.Models.Position", b =>
                {
                    b.HasOne("SalesInMove.Models.Company", "Company")
                        .WithMany("Positions")
                        .HasForeignKey("CompanyId");

                    b.HasOne("SalesInMove.Models.WorkHourRatio", "WorkHourRatio")
                        .WithOne("Position")
                        .HasForeignKey("SalesInMove.Models.Position", "WorkHourRatioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("WorkHourRatio");
                });

            modelBuilder.Entity("SalesInMove.Models.Company", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("SalesInMove.Models.WorkHourRatio", b =>
                {
                    b.Navigation("Position");
                });

            modelBuilder.Entity("SalesInMove.Models.User", b =>
                {
                    b.Navigation("Company");
                });
#pragma warning restore 612, 618
        }
    }
}
