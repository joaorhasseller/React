using Microsoft.EntityFrameworkCore;
using RestAPI.Models;
using System.Security.Cryptography.Xml;

namespace RestAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasData(new List<Person> 
            {
                new Person { Id = 1, FirstName = "Ayrton", LastName = "Senna", Gender = "Male", Address = "São Paulo - Brasil"},
                new Person { Id = 2,FirstName = "Leonardo", LastName = "da Vinci", Gender = "Male", Address = "Anchiano - Italy"},
                new Person { Id = 3,FirstName = "Mahatma", LastName = "Gandh", Gender = "Male", Address = "Porbandar - India"},
                new Person { Id = 4,FirstName = "Mohamed", LastName = "Gandhi", Gender = "Male", Address = "Kentucky - USA"},
                new Person { Id = 5,FirstName = "Nelson", LastName = "Mandela", Gender = "Male", Address = "Mvezo - South Africa"}
            });

        modelBuilder.Entity<Book>()
            .HasData(new List<Book>
            {
                new Book { Id = 1, Author = "John Doe", LaunchDate = DateTime.Now.AddMonths(-6), Price = 29.99m, Title = "The Art of Programming" },
                new Book { Id = 2, Author = "Jane Smith", LaunchDate = DateTime.Now.AddMonths(-12), Price = 19.99m, Title = "Data Science Basics" },
                new Book { Id = 3, Author = "Robert Johnson", LaunchDate = DateTime.Now.AddMonths(-3), Price = 24.99m, Title = "Machine Learning Fundamentals" },
                new Book { Id = 4, Author = "Emily White", LaunchDate = DateTime.Now.AddMonths(-9), Price = 14.99m, Title = "Web Development Essentials" },
                new Book { Id = 5, Author = "Michael Brown", LaunchDate = DateTime.Now.AddMonths(-7), Price = 39.99m, Title = "Deep Learning Techniques" },
                new Book { Id = 6, Author = "Sophia Davis", LaunchDate = DateTime.Now.AddMonths(-5), Price = 17.99m, Title = "Introduction to C# Programming" },
                new Book { Id = 7, Author = "Daniel Wilson", LaunchDate = DateTime.Now.AddMonths(-10), Price = 32.99m, Title = "The Art of Database Design" },
                new Book { Id = 8, Author = "Olivia Taylor", LaunchDate = DateTime.Now.AddMonths(-8), Price = 21.99m, Title = "Agile Software Development" },
                new Book { Id = 9, Author = "Ethan Miller", LaunchDate = DateTime.Now.AddMonths(-4), Price = 27.99m, Title = "iOS App Development Guide" },
                new Book { Id = 10, Author = "Ava Martinez", LaunchDate = DateTime.Now.AddMonths(-11), Price = 19.99m, Title = "JavaScript for Beginners" },
                new Book { Id = 11, Author = "Liam Anderson", LaunchDate = DateTime.Now.AddMonths(-2), Price = 34.99m, Title = "Python Programming Mastery" },
                new Book { Id = 12, Author = "Emma Harris", LaunchDate = DateTime.Now.AddMonths(-1), Price = 23.99m, Title = "UI/UX Design Principles" },
                new Book { Id = 13, Author = "Jackson Turner", LaunchDate = DateTime.Now.AddMonths(-8), Price = 29.99m, Title = "Network Security Essentials" },
                new Book { Id = 14, Author = "Grace Murphy", LaunchDate = DateTime.Now.AddMonths(-7), Price = 26.99m, Title = "Android App Development Basics" },
                new Book { Id = 15, Author = "Carter Wright", LaunchDate = DateTime.Now.AddMonths(-3), Price = 31.99m, Title = "Cybersecurity Fundamentals" }
            });
    }

    DbSet<Person> People { get; set; }
    DbSet<Book> Books { get; set; }
}
