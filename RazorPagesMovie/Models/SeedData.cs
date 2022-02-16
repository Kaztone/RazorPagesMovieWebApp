using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>())) 
            {
                if (context.Movie.Any())
                {
                    return;
                }
                else
                {
                    context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Der Herr der Ringe: Die Gefährten || Azure",
                        ReleaseDate = DateTime.Parse("2001-12-19"),
                        Genre = "Fantasy",
                        Price = 5.99M, 
                        Rating = "9"
                    },
                    new Movie
                    {
                        Title = "Der Herr der Ringe: Die zwei Türme || Azure",
                        ReleaseDate = DateTime.Parse("2002-12-18"),
                        Genre = "Fantasy",
                        Price = 7.99M,
                        Rating = "8"
                    },
                    new Movie
                    {
                        Title = "Der Herr der Ringe: Die Rückker des Königs || Azure",
                        ReleaseDate = DateTime.Parse("2003-12-17"),
                        Genre = "Fantasy",
                        Price = 11.99M,
                        Rating = "10"
                    });

                    context.SaveChanges();
                }              
            }
        }
    }
}
