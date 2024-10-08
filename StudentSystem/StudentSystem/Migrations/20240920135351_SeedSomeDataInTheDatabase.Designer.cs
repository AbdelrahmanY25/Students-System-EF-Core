﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentSystem.Data;

#nullable disable

namespace StudentSystem.Migrations
{
    [DbContext(typeof(StudentSystemContext))]
    [Migration("20240920135351_SeedSomeDataInTheDatabase")]
    partial class SeedSomeDataInTheDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.Property<int>("CoursesId")
                        .HasColumnType("int");

                    b.Property<int>("StudentsId")
                        .HasColumnType("int");

                    b.HasKey("CoursesId", "StudentsId");

                    b.HasIndex("StudentsId");

                    b.ToTable("CourseStudent");
                });

            modelBuilder.Entity("StudentSystem.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("Nvarchar(80)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Coursecs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Learn C#",
                            EndDate = new DateTime(2024, 12, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6648),
                            Name = "C#",
                            Price = 5000.0,
                            StartDate = new DateTime(2024, 9, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6643)
                        },
                        new
                        {
                            Id = 2,
                            Description = "Learn C++",
                            EndDate = new DateTime(2024, 11, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6665),
                            Name = "C++",
                            Price = 2000.0,
                            StartDate = new DateTime(2024, 9, 30, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6657)
                        },
                        new
                        {
                            Id = 3,
                            Description = "Learn Java",
                            EndDate = new DateTime(2026, 1, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6677),
                            Name = "Java",
                            Price = 10000.0,
                            StartDate = new DateTime(2025, 9, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6672)
                        });
                });

            modelBuilder.Entity("StudentSystem.Models.HomeWork", b =>
                {
                    b.Property<int>("HomeWorkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HomeWorkId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.Property<int>("ContentType")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("CourseId1")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubmissionTime")
                        .HasColumnType("datetime2");

                    b.HasKey("HomeWorkId");

                    b.HasIndex("CourseId");

                    b.HasIndex("CourseId1")
                        .IsUnique()
                        .HasFilter("[CourseId1] IS NOT NULL");

                    b.HasIndex("StudentId");

                    b.ToTable("HomeWorks");

                    b.HasData(
                        new
                        {
                            HomeWorkId = 1,
                            Content = "https://learn.microsoft.com/en-us/dotnet/csharp/",
                            ContentType = 0,
                            CourseId = 1,
                            StudentId = 1,
                            SubmissionTime = new DateTime(2024, 9, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6766)
                        },
                        new
                        {
                            HomeWorkId = 2,
                            Content = "https://devdocs.io/cpp/",
                            ContentType = 0,
                            CourseId = 2,
                            StudentId = 2,
                            SubmissionTime = new DateTime(2024, 9, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6774)
                        },
                        new
                        {
                            HomeWorkId = 3,
                            Content = "https://www.cs.cmu.edu/afs/cs.cmu.edu/user/gchen/www/download/java/LearnJava.pdf",
                            ContentType = 1,
                            CourseId = 3,
                            StudentId = 3,
                            SubmissionTime = new DateTime(2024, 9, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6780)
                        });
                });

            modelBuilder.Entity("StudentSystem.Models.Resource", b =>
                {
                    b.Property<int>("ResourceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResourceId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("Nvarchar(50)");

                    b.Property<int>("ResourceType")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.HasKey("ResourceId");

                    b.HasIndex("CourseId");

                    b.ToTable("Resources");

                    b.HasData(
                        new
                        {
                            ResourceId = 1,
                            CourseId = 1,
                            Name = "C# Tutorial",
                            ResourceType = 2,
                            Url = "https://learn.microsoft.com/en-us/dotnet/csharp/"
                        },
                        new
                        {
                            ResourceId = 2,
                            CourseId = 2,
                            Name = "C++ Tutorial",
                            ResourceType = 2,
                            Url = "https://devdocs.io/cpp/"
                        },
                        new
                        {
                            ResourceId = 3,
                            CourseId = 3,
                            Name = "Java Tutorial",
                            ResourceType = 3,
                            Url = "https://www.cs.cmu.edu/afs/cs.cmu.edu/user/gchen/www/download/java/LearnJava.pdf"
                        });
                });

            modelBuilder.Entity("StudentSystem.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("Nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("RegistredOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthday = new DateTime(2001, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Abdelrahman Yasser",
                            PhoneNumber = "010191765",
                            RegistredOn = new DateTime(2024, 9, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6237)
                        },
                        new
                        {
                            Id = 2,
                            Birthday = new DateTime(2001, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Momen Abdo",
                            PhoneNumber = "011554789",
                            RegistredOn = new DateTime(2024, 9, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6345)
                        },
                        new
                        {
                            Id = 3,
                            Birthday = new DateTime(2005, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Mohamed Nagah",
                            PhoneNumber = "0155586674",
                            RegistredOn = new DateTime(2024, 10, 20, 16, 53, 50, 196, DateTimeKind.Local).AddTicks(6354)
                        });
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.HasOne("StudentSystem.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentSystem.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentSystem.Models.HomeWork", b =>
                {
                    b.HasOne("StudentSystem.Models.Course", "Course")
                        .WithMany("HomeWorks")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentSystem.Models.Course", null)
                        .WithOne("HomeWork")
                        .HasForeignKey("StudentSystem.Models.HomeWork", "CourseId1");

                    b.HasOne("StudentSystem.Models.Student", "Student")
                        .WithMany("HomeWorks")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentSystem.Models.Resource", b =>
                {
                    b.HasOne("StudentSystem.Models.Course", "Course")
                        .WithMany("Resources")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("StudentSystem.Models.Course", b =>
                {
                    b.Navigation("HomeWork")
                        .IsRequired();

                    b.Navigation("HomeWorks");

                    b.Navigation("Resources");
                });

            modelBuilder.Entity("StudentSystem.Models.Student", b =>
                {
                    b.Navigation("HomeWorks");
                });
#pragma warning restore 612, 618
        }
    }
}
