﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesInMove.Models;
using System;
using System.Collections.Generic;

namespace SalesInMove.DatabaseRelated
{
    public class SalesmenDbContext : IdentityDbContext
    {
        //connection with the entityframework core
        public SalesmenDbContext(DbContextOptions<SalesmenDbContext> options) : base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Employee> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var splitStringConverter = new ValueConverter<IList<string>, string>(v => string.Join(";", v), v => v.Split(new[] { ';' }));
            builder.Entity<Company>().Property(nameof(Company.EmployeeOpinions)).HasConversion(splitStringConverter);
            
            builder.Entity<Company>().Property(nameof(Company.CompanyProfile)).HasConversion(splitStringConverter);

            #region PositionSeed
            builder.Entity<WorkHourRatio>().HasData(
                new WorkHourRatio
                {
                    WorkHourRatioId = 4,
                    WorkHoursPerMonth = 184,
                    HomeOfficeHours = 100,
                    DrivingHours = 20,
                    OfficeHours = 64
                }
            );

            builder.Entity<Position>().HasData(
                new Position
                {
                    PositionId = 3,
                    WorkHourRatioId = 4,
                    Name = "Sales manager",
                    City = "Halásztelek",
                    Description = "Good",
                    BossExpectations = "Be good and reliable!",
                    WorkHour = "Full",
                    OtherBenefits = "Laptop and car",
                    ProgressionSupport = true
                }
            );
            #endregion

            #region Company seed
            builder.Entity<User>().HasData(
                new User
                {
                    Id = "0",
                    Email = "marko@gmail.com",
                    Password = "Asd123",
                    UserType = 2,
                }
            );

            builder.Entity<Company>().HasData(
                new Company
                {
                    CompanyId = 12,
                    Name = "Markoó Kft.",
                    Headquarter = "Halásztelek",
                    TaxNumber = 24767107243,
                    Registry = 0109321480,
                    YearOfFoundation = DateTime.Parse("Jan 1, 2000"),
                    NumberOfSalesman = 10,
                    AnnualNettoIncome = 2000321865,
                    EmployeeOpinions = new List<string>() { "Good", "Bad", "Terrific!", "Horrific!" },
                    SalesSupport = true,
                    UserId = "0",
                    PositionId = 3

                }
            );
            #endregion

        }

    }
}
