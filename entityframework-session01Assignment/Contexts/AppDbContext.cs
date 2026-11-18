using entityframework_session01Assignment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace entityframework_session01Assignment.Contexts
{
    internal class AppDbContext: DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=bookstore;Trusted_Connection=True;trustservercertificate=true");
        }
        public DbSet<authors> authors { get; set; }
        public DbSet<categories> categories { get; set; } 
        public DbSet<Book> books { get; set; }

    }
}
