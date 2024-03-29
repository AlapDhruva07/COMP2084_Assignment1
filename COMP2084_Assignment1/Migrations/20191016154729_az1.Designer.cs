﻿// <auto-generated />
using System;
using COMP2084_Assignment1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace COMP2084_Assignment1.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20191016154729_az1")]
    partial class az1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("COMP2084_Assignment1.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarName");

                    b.Property<string>("CompanyName");

                    b.Property<DateTime>("Mfdate");

                    b.Property<string>("Model");

                    b.HasKey("CarId");

                    b.HasIndex("CompanyName");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("COMP2084_Assignment1.Models.Company", b =>
                {
                    b.Property<string>("CompanyName")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Nationality");

                    b.Property<string>("Province");

                    b.HasKey("CompanyName");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("COMP2084_Assignment1.Models.Car", b =>
                {
                    b.HasOne("COMP2084_Assignment1.Models.Company", "Company")
                        .WithMany("Cars")
                        .HasForeignKey("CompanyName");
                });
#pragma warning restore 612, 618
        }
    }
}
