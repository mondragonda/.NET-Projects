using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data.Entity;

namespace BookApp.UI.Models
{
    public class SampleData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();
            context.Database.Migrate();

            if (!context.Book.Any())
            {
                var austen = context.Author.Add(new Author()
                {
                    Name = "Jane Austen",
                    Nationality = "American"
                }).Entity;

                var dickens = context.Author.Add(new Author()
                {
                    Name = "Charles Dickens",
                    Nationality = "American"
                }).Entity;

                var cervantes = context.Add(new Author()
                {
                    Name = "Miguel Cervantes",
                    Nationality = "Spanish"
                }).Entity;

                context.Book.AddRange(
                    new Book()
                    {
                        Title = "Pride and Prejudice",
                        Author = austen,
                        Description = "Is a good book",
                        Year = 1983,
                        Genre = "Commedy of Manners",
                    },

                    new Book()
                    {
                        Title = "David Copperfield",
                        Year = 1850,
                        Author = dickens,
                        Genre = "Bildungsroman"
                    },

                    new Book()
                    {
                        Title = "Don Quixote",
                        Year = 1617,
                        Author = cervantes,
                        Genre = "Picaresque",
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
