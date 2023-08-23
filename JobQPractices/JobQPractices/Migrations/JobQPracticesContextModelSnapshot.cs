﻿// <auto-generated />
using System;
using JobQPractices.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobQPractices.Migrations
{
    [DbContext(typeof(JobQPracticesContext))]
    partial class JobQPracticesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("JobQPractices.Models.jobDetails", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FinishDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("JobStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("jobDetails");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Description = "first job",
                            FinishDate = new DateTime(2023, 8, 23, 11, 27, 19, 66, DateTimeKind.Local).AddTicks(1919),
                            JobStatus = 0
                        },
                        new
                        {
                            Id = "2",
                            Description = "second job",
                            FinishDate = new DateTime(2023, 8, 23, 11, 27, 19, 66, DateTimeKind.Local).AddTicks(1940),
                            JobStatus = 5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
