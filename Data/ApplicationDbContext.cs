using System;
using System.Collections.Generic;
using System.Text;
using IrishNationalStud.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IrishNationalStud.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Stallions> Stallions { get; set; }
        public DbSet<Mares> Mares { get; set; }
        public DbSet<Foals> Foals { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Foals>().HasData(
                 new Foals
                 {
                     Id = 1,
                     Name = "",
                     DOB = DateTime.Parse("29-04-17"),
                     Sire = "Dragon Pulse",
                     Dam = "Alava",
                     Colour = "Bay",

                 },
                    new Foals
                    {
                        Id = 2,
                        Name = "",
                        DOB = DateTime.Parse("08-05-17"),
                        Sire = "Invincible Spirit",
                        Dam = "Bayja",
                        Colour = "Bay"

                    },
                    new Foals
                    {
                        Id = 3,
                        Name = "",
                        DOB = DateTime.Parse("08-05-17"),
                        Sire = "National Defense",
                        Dam = "Dansky",
                        Colour = "Bay"

                    },
                    new Foals
                    {
                        Id = 4,
                        Name = "",
                        DOB = DateTime.Parse("25-03-17"),
                        Sire = "Elusive Pimpernel",
                        Dam = "Cascading",
                        Colour = "Bay"

                    },

                    new Foals
                    {
                        Id = 5,
                        Name = "",
                        DOB = DateTime.Parse("24-03-17"),
                        Sire = "Decorated Knight",
                        Dam = "Follow My Lead",
                        Colour = "Grey"

                    },

                    new Foals
                    {
                        Id = 6,
                        Name = "",
                        DOB = DateTime.Parse("03-05-17"),
                        Sire = "Gale Force Ten",
                        Dam = "Diamond Sky",
                        Colour = "Chestnut"

                    },

                    new Foals
                    {
                        Id = 7,
                        Name = "",
                        DOB = DateTime.Parse("05-12-17"),
                        Sire = "Free Eagle",
                        Dam = "Dazzle Dancer",
                        Colour = "Brown"

                    }

                );

                        builder.Entity<Mares>().HasData(

                        new Mares
                        {
                            Id = 1,
                            Name = "Alava",
                            DOB = DateTime.Parse("12-03-2006"),
                            Sire = "Anabaa",
                            Dam = "Cerita",
                            Colour = "Bay",
                            Stallions = "Invincible Spirit",
                            Foal = ""

                        },
                        new Mares
                        {
                            Id = 2,
                            Name = "Bayja",
                            DOB = DateTime.Parse("26-02-2009"),
                            Sire = "Galileo",
                            Dam = "New Revenue",
                            Colour = "Bay",
                            Stallions = "Free Eagle",
                            Foal = ""
                        },
                        new Mares
                        {
                            Id = 3,
                            Name = "Dansky",
                            DOB = DateTime.Parse("12-10-1995"),
                            Sire = "Danehill",
                            Dam = "Our Tristalight",
                            Colour = "Bay",
                            Stallions = "Galileo",
                            Foal = ""
                        },
                        new Mares
                        {
                            Id = 4,
                            Name = "Cascading",
                            DOB = DateTime.Parse("02-08-2011"),
                            Sire = "Teofilo",
                            Dam = "Angel Falls",
                            Colour = "Bay",
                            Stallions = "Australia",
                            Foal = ""
                        },

                        new Mares
                        {
                            Id = 5,
                            Name = "Follow My Lead",
                            DOB = DateTime.Parse("10-01-2008"),
                            Sire = "Stratum",
                            Dam = "Pompeii",
                            Colour = "Grey",
                            Stallions = "Sea The Stars",
                            Foal = ""
                        },

                        new Mares
                        {
                            Id = 6,
                            Name = "Diamond Sky",
                            DOB = DateTime.Parse("25-02-2010"),
                            Sire = "Montjeu",
                            Dam = "Danaskaya",
                            Colour = "Chestnut",
                            Stallions = "Dragon Pulse",
                            Foal = ""
                        },

                        new Mares
                        {
                            Id = 7,
                            Name = "Dazzle Dancer",
                            DOB = DateTime.Parse("14-02-2006"),
                            Sire = "Montjeu",
                            Dam = "Another Dancer",
                            Colour = "Brown",
                            Stallions = "Decorated Knight",
                            Foal = ""
                        }

                    );

                        builder.Entity<Stallions>().HasData(

                        new Stallions
                        {
                            Id = 1,
                            Name = "Invincible Spirit",
                            DOB = DateTime.Parse("17-02-1997"),
                            Sire = "Green Dessert",
                            Dam = "Rafha (Kris)",
                            Colour = "Bay"


                        },
                      new Stallions
                      {
                          Id = 2,
                          Name = "National Defense",
                          DOB = DateTime.Parse("17-02-2014"),
                          Sire = "Invincible Spirit",
                          Dam = "Angel Falls (Kingmambo)",
                          Colour = "Bay"

                      },
                       new Stallions
                       {
                           Id = 3,
                           Name = "Free Eagle",
                           DOB = DateTime.Parse("04-05-2011"),
                           Sire = "High Chaparral",
                           Dam = "Polished Gem (Danehill)",
                           Colour = "Bay"

                       },
                        new Stallions
                        {
                            Id = 4,
                            Name = "Dragon Pulse",
                            DOB = DateTime.Parse("17-02-2014"),
                            Sire = "Kyllachy",
                            Dam = "Poetical (Croco Rouge)",
                            Colour = "Chestnut"

                        },

                        new Stallions
                        {
                            Id = 5,
                            Name = "Elusive Pimpernel",
                            DOB = DateTime.Parse("17-02-2007"),
                            Sire = "Elusive Quality",
                            Dam = "Cara Fantasy (Sadler's Wells)",
                            Colour = "Brown"

                        },

                        new Stallions
                        {
                            Id = 6,
                            Name = "Decorated Knight",
                            DOB = DateTime.Parse("17-02-2009"),
                            Sire = "Galileo",
                            Dam = "Pearling (Storm Cat)",
                            Colour = "Bay"

                        },

                        new Stallions
                        {
                            Id = 7,
                            Name = "Gale Force Ten",
                            DOB = DateTime.Parse("20-02-2010"),
                            Sire = "Oasis Dream",
                            Dam = "Ronaldsay (Kirkwall)",
                            Colour = "Bay"

                        }
                );
        }
    }
}
