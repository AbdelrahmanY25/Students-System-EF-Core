using Microsoft.EntityFrameworkCore;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Data
{
    internal class StudentSystemContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=localhost;" +
                                        "Initial Catalog=Students System;" +
                                        "Integrated Security=True;" +
                                        "TrustServerCertificate=True");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Coursecs { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<HomeWork> HomeWorks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Courses)
                .WithMany(e => e.Students);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.HomeWorks)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.StudentId)
                .IsRequired(true);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Resources)
                .WithOne(e => e.Course)
                .HasForeignKey(e => e.CourseId)
                .IsRequired(true);

            modelBuilder.Entity<HomeWork>()
                .HasOne(e => e.Course)
                .WithMany(e => e.HomeWorks)
                .HasForeignKey(e => e.CourseId)
                .IsRequired();

            modelBuilder.Entity<Student>()
                .Property(e => e.Name)
                .HasColumnType("Nvarchar(100)");

            modelBuilder.Entity<Student>()
                .Property(e => e.PhoneNumber)
                .HasColumnType("varchar(10)")
                .IsRequired(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.Name)
                .HasColumnType("Nvarchar(80)");

            modelBuilder.Entity<Course>()
                .Property(e => e.Description)
                .IsRequired(false);

            modelBuilder.Entity<Resource>()
                .Property(e => e.Name)
                .HasColumnType("Nvarchar(50)");

            modelBuilder.Entity<Resource>()
                .Property(e => e.Url)
                .HasColumnType("varchar(max)");

            modelBuilder.Entity<HomeWork>()
                .Property(e => e.Content)
                .HasColumnType("varchar(max)");

            // Seed Some Data in the Database

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Abdelrahman Yasser", PhoneNumber = "010191765", RegistredOn = DateTime.Now, Birthday = new DateTime(2001, 9, 22) },
                new Student { Id = 2, Name = "Momen Abdo", PhoneNumber = "011554789", RegistredOn = DateTime.Now, Birthday = new DateTime(2001, 4, 10) },
                new Student { Id = 3, Name = "Mohamed Nagah", PhoneNumber = "0155586674", RegistredOn = DateTime.Now.AddMonths(1), Birthday = new DateTime(2005, 5, 1) }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "C#", Description = "Learn C#", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(3), Price = 5000d },
                new Course { Id = 2, Name = "C++", Description = "Learn C++", StartDate = DateTime.Now.AddDays(10), EndDate = DateTime.Now.AddMonths(2), Price = 2000d },
                new Course { Id = 3, Name = "Java", Description = "Learn Java", StartDate = DateTime.Now.AddYears(1), EndDate = DateTime.Now.AddYears(1).AddMonths(4), Price = 10000d }
            );

            modelBuilder.Entity<Resource>().HasData(
                new Resource { ResourceId = 1, Name = "C# Tutorial", Url = "https://learn.microsoft.com/en-us/dotnet/csharp/", ResourceType = ResourceType.Document, CourseId = 1 },
                new Resource { ResourceId = 2, Name = "C++ Tutorial", Url = "https://devdocs.io/cpp/", ResourceType = ResourceType.Document, CourseId = 2 },
                new Resource { ResourceId = 3, Name = "Java Tutorial", Url = "https://www.cs.cmu.edu/afs/cs.cmu.edu/user/gchen/www/download/java/LearnJava.pdf", ResourceType = ResourceType.Other, CourseId = 3 }
            );

            modelBuilder.Entity<HomeWork>().HasData(
                new HomeWork { HomeWorkId = 1, Content = "https://learn.microsoft.com/en-us/dotnet/csharp/", ContentType = ContentType.Application, SubmissionTime = DateTime.Now, StudentId = 1, CourseId = 1 },
                new HomeWork { HomeWorkId = 2, Content = "https://devdocs.io/cpp/", ContentType = ContentType.Application, SubmissionTime = DateTime.Now, StudentId = 2, CourseId = 2 },
                new HomeWork { HomeWorkId = 3, Content = "https://www.cs.cmu.edu/afs/cs.cmu.edu/user/gchen/www/download/java/LearnJava.pdf", ContentType = ContentType.Pdf, SubmissionTime = DateTime.Now, StudentId = 3, CourseId = 3 }
            );
        }
    }
}
