using IrishNationalStud.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IrishNationalStud.Utility;

namespace IrishNationalStud.Models
{
    public class SeedData
    {
        private static object context;

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any Stallions.
                if (context.Stallions.Any())
                {
                    return;   // DB has been seeded
                }

                context.Stallions.AddRange(
                     new Stallions
                     {
                         Name = "Invincible Spirit",
                         DOB = DateTime.Parse("17-02-1997"),
                         Sire = "Green Dessert",
                         Dam = "Rafha (Kris)",
                         Colour = "Bay"


                     },
                      new Stallions
                      {
                          Name = "National Defense",
                          DOB = DateTime.Parse("17-02-2014"),
                          Sire = "Invincible Spirit",
                          Dam = "Angel Falls (Kingmambo)",
                          Colour = "Bay"

                      },
                       new Stallions
                       {
                           Name = "Free Eagle",
                           DOB = DateTime.Parse("04-05-2011"),
                           Sire = "High Chaparral",
                           Dam = "Polished Gem (Danehill)",
                           Colour = "Bay"

                       },
                        new Stallions
                        {
                            Name = "Dragon Pulse",
                            DOB = DateTime.Parse("17-02-2014"),
                            Sire = "Kyllachy",
                            Dam = "Poetical (Croco Rouge)",
                            Colour = "Chestnut"

                        },

                        new Stallions
                        {
                            Name = "Elusive Pimpernel",
                            DOB = DateTime.Parse("17-02-2007"),
                            Sire = "Elusive Quality",
                            Dam = "Cara Fantasy (Sadler's Wells)",
                            Colour = "Brown"

                        },

                        new Stallions
                        {
                            Name = "Decorated Knight",
                            DOB = DateTime.Parse("17-02-2009"),
                            Sire = "Galileo",
                            Dam = "Pearling (Storm Cat)",
                            Colour = "Bay"

                        },

                        new Stallions
                        {
                            Name = "Gale Force Ten",
                            DOB = DateTime.Parse("20-02-2010"),
                            Sire = "Oasis Dream",
                            Dam = "Ronaldsay (Kirkwall)",
                            Colour = "Bay"

                        }

                        );
               
                context.SaveChanges();
            }
        }
    }
}
