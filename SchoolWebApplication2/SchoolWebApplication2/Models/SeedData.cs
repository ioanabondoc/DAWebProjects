using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace SchoolWebApplication2.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SchoolWebApplication2Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SchoolWebApplication2Context>>()))
            {
                // Look for any movies.
                if (context.Animal.Any())
                {
                    return;   // DB has been seeded
                }

                context.Animal.AddRange(
                    new Animal
                    {
                        Name = "Garfield",
                        Type ="Cat",
                        Gender ="Male",
                        Breed="Tabby",
                        DateArrived=DateTime.Parse("2019-05-10"),
                        Age="Adult",
                        PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/6/66/An_up-close_picture_of_a_curious_male_domestic_shorthair_tabby_cat.jpg/220px-An_up-close_picture_of_a_curious_male_domestic_shorthair_tabby_cat.jpg"
                    },
                    new Animal
                    {
                        Name = "Murry",
                        Type = "Dog",
                        Gender = "Male",
                        Breed = "Beagle",
                        DateArrived = DateTime.Parse("2019-02-12"),
                        Age = "Baby",
                        PhotoLink = "https://static-s.aa-cdn.net/img/ios/383939191/db6eee9421a43546ce6134915b6d57e5?v=1"
                    },
                    new Animal
                    {
                        Name = "Connie",
                        Type = "Cat",
                        Gender = "Female",
                        Breed = "Ragdoll",
                        DateArrived = DateTime.Parse("2019-05-14"),
                        Age = "Young",
                        PhotoLink = "https://pbs.twimg.com/profile_images/2790611619/1783aab500f1ed75f658137e6d9095ba.jpeg"
                    }

                );
                context.SaveChanges();
            }
        }
    }
}