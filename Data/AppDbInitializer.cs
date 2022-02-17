using System;
using System.Linq;
using BooksApi.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BooksApi.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "1st Book",
                        Description = "1st Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Drama",
                        
                        CoverUrl = "google.com",
                        DateAdded = DateTime.Now


                    },
                    new Book()
                    {
                        Title = "2st Book",
                        Description = "2st Book Description",
                        IsRead = false,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Terror",
                        
                        CoverUrl = "google.com",
                        DateAdded = DateTime.Now


                    },
                    new Book()
                    {
                        Title = "3st Book",
                        Description = "3st Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Sprint",
                        
                        CoverUrl = "google.com",
                        DateAdded = DateTime.Now


                    },
                    new Book()
                    {
                        Title = "4st Book",
                        Description = "4st Book Description",
                        IsRead = false,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Adventure",
                        
                        CoverUrl = "google.com",
                        DateAdded = DateTime.Now


                    });

                    context.SaveChanges();
                }
            }
        }
    }    
}

