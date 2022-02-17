using System;
using Microsoft.EntityFrameworkCore;
using BooksApi.Data.Models;

namespace BooksApi.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<Book> Books { get; set;}
    }
}