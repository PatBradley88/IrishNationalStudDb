﻿// <auto-generated />
using System;
using IrishNationalStud.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IrishNationalStud.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IrishNationalStud.Models.Foals", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Colour")
                        .IsRequired();

                    b.Property<DateTime>("DOB");

                    b.Property<string>("Dam");

                    b.Property<string>("Name");

                    b.Property<int>("Sex");

                    b.Property<string>("Sire");

                    b.HasKey("Id");

                    b.ToTable("Foals");

                    b.HasData(
                        new { Id = 1, Colour = "Bay", DOB = new DateTime(2017, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), Dam = "Alava", Name = "", Sex = 0, Sire = "Dragon Pulse" },
                        new { Id = 2, Colour = "Bay", DOB = new DateTime(2017, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), Dam = "Bayja", Name = "", Sex = 0, Sire = "Invincible Spirit" },
                        new { Id = 3, Colour = "Bay", DOB = new DateTime(2017, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), Dam = "Dansky", Name = "", Sex = 0, Sire = "National Defense" },
                        new { Id = 4, Colour = "Bay", DOB = new DateTime(2017, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), Dam = "Cascading", Name = "", Sex = 0, Sire = "Elusive Pimpernel" },
                        new { Id = 5, Colour = "Grey", DOB = new DateTime(2017, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), Dam = "Follow My Lead", Name = "", Sex = 0, Sire = "Decorated Knight" },
                        new { Id = 6, Colour = "Chestnut", DOB = new DateTime(2017, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), Dam = "Diamond Sky", Name = "", Sex = 0, Sire = "Gale Force Ten" },
                        new { Id = 7, Colour = "Brown", DOB = new DateTime(2017, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), Dam = "Dazzle Dancer", Name = "", Sex = 0, Sire = "Free Eagle" }
                    );
                });

            modelBuilder.Entity("IrishNationalStud.Models.Mares", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Colour")
                        .IsRequired();

                    b.Property<DateTime>("DOB");

                    b.Property<string>("Dam")
                        .IsRequired();

                    b.Property<DateTime>("DueDate");

                    b.Property<string>("Foal");

                    b.Property<bool>("InFoal");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Sire")
                        .IsRequired();

                    b.Property<string>("Stallions");

                    b.HasKey("Id");

                    b.ToTable("Mares");

                    b.HasData(
                        new { Id = 1, Colour = "Bay", DOB = new DateTime(2006, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), Dam = "Cerita", DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Foal = "", InFoal = false, Name = "Alava", Sire = "Anabaa", Stallions = "Invincible Spirit" },
                        new { Id = 2, Colour = "Bay", DOB = new DateTime(2009, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), Dam = "New Revenue", DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Foal = "", InFoal = false, Name = "Bayja", Sire = "Galileo", Stallions = "Free Eagle" },
                        new { Id = 3, Colour = "Bay", DOB = new DateTime(1995, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), Dam = "Our Tristalight", DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Foal = "", InFoal = false, Name = "Dansky", Sire = "Danehill", Stallions = "Galileo" },
                        new { Id = 4, Colour = "Bay", DOB = new DateTime(2011, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), Dam = "Angel Falls", DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Foal = "", InFoal = false, Name = "Cascading", Sire = "Teofilo", Stallions = "Australia" },
                        new { Id = 5, Colour = "Grey", DOB = new DateTime(2008, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), Dam = "Pompeii", DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Foal = "", InFoal = false, Name = "Follow My Lead", Sire = "Stratum", Stallions = "Sea The Stars" },
                        new { Id = 6, Colour = "Chestnut", DOB = new DateTime(2010, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), Dam = "Danaskaya", DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Foal = "", InFoal = false, Name = "Diamond Sky", Sire = "Montjeu", Stallions = "Dragon Pulse" },
                        new { Id = 7, Colour = "Brown", DOB = new DateTime(2006, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), Dam = "Another Dancer", DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Foal = "", InFoal = false, Name = "Dazzle Dancer", Sire = "Montjeu", Stallions = "Decorated Knight" }
                    );
                });

            modelBuilder.Entity("IrishNationalStud.Models.Stallions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Colour")
                        .IsRequired();

                    b.Property<DateTime>("DOB");

                    b.Property<string>("Dam")
                        .IsRequired();

                    b.Property<string>("Image");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Sire")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Stallions");

                    b.HasData(
                        new { Id = 1, Colour = "Bay", DOB = new DateTime(1997, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), Dam = "Rafha (Kris)", Name = "Invincible Spirit", Sire = "Green Dessert" },
                        new { Id = 2, Colour = "Bay", DOB = new DateTime(2014, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), Dam = "Angel Falls (Kingmambo)", Name = "National Defense", Sire = "Invincible Spirit" },
                        new { Id = 3, Colour = "Bay", DOB = new DateTime(2011, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), Dam = "Polished Gem (Danehill)", Name = "Free Eagle", Sire = "High Chaparral" },
                        new { Id = 4, Colour = "Chestnut", DOB = new DateTime(2014, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), Dam = "Poetical (Croco Rouge)", Name = "Dragon Pulse", Sire = "Kyllachy" },
                        new { Id = 5, Colour = "Brown", DOB = new DateTime(2007, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), Dam = "Cara Fantasy (Sadler's Wells)", Name = "Elusive Pimpernel", Sire = "Elusive Quality" },
                        new { Id = 6, Colour = "Bay", DOB = new DateTime(2009, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), Dam = "Pearling (Storm Cat)", Name = "Decorated Knight", Sire = "Galileo" },
                        new { Id = 7, Colour = "Bay", DOB = new DateTime(2010, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), Dam = "Ronaldsay (Kirkwall)", Name = "Gale Force Ten", Sire = "Oasis Dream" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("IrishNationalStud.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Name");

                    b.ToTable("ApplicationUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
