﻿using System.Security.Policy;
using Microsoft.Extensions.Configuration;
using GrupoWebBackend.DomainPets.Domain.Models;
using GrupoWebBackend.DomainPublications.Domain.Models;
using GrupoWebBackend.DomainDistrict.Domain.Models;
using GrupoWebBackend.Security.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using GrupoWebBackend.DomainSubscriptions.Domain.Models;

namespace GrupoWebBackend.Shared.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration _configuration;
        public AppDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }
        
        public DbSet<Pet> Pets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);



            // Districts
            builder.Entity<District>().ToTable("Districts");
            builder.Entity<District>().HasKey(p => p.Id);
            builder.Entity<District>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            
            // Users
            builder.Entity<User>().ToTable("Users");
            builder.Entity<User>().HasKey(p => p.Id);
            builder.Entity<User>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<User>().Property(p => p.UserNick).IsRequired();
            builder.Entity<User>().Property(p => p.Type).IsRequired();
            builder.Entity<User>().Property(p => p.Email).IsRequired();
            builder.Entity<User>().Property(p => p.Phone).IsRequired(false);
            builder.Entity<User>().Property(p => p.DistrictId).IsRequired(false);
            builder.Entity<User>().Property(p => p.Dni).IsRequired(false);
            builder.Entity<User>().Property(p => p.Ruc).IsRequired(false);
            builder.Entity<User>().Property(p => p.Name).IsRequired(false);
            builder.Entity<User>().Property(p => p.LastName).IsRequired(false);
            builder.Entity<User>().Property(p => p.UrlToImageBackground).IsRequired(false);
            builder.Entity<User>().Property(p => p.UrlToImageProfile).IsRequired(false);

            // Pet Constraints
            builder.Entity<Pet>().ToTable("Pets");
            builder.Entity<Pet>().HasKey(p => p.Id);
            builder.Entity<Pet>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Pet>().Property(p => p.Type).IsRequired();
            builder.Entity<Pet>().Property(p => p.Name).IsRequired();
            builder.Entity<Pet>().Property(p => p.Attention).IsRequired();
            builder.Entity<Pet>().Property(p => p.Age).IsRequired();
            builder.Entity<Pet>().Property(p => p.UserId).IsRequired();
            builder.Entity<Pet>().Property(p => p.Race).IsRequired();
            builder.Entity<Pet>().Property(p => p.IsAdopted).IsRequired();
            builder.Entity<Pet>().Property(p => p.PublicationId).IsRequired(false);
            builder.Entity<Pet>().Property(p => p.IsPublished).IsRequired();
            builder.Entity<Pet>().Property(p => p.Gender).IsRequired(false);
            builder.Entity<Pet>().Property(p => p.UrlToImage).IsRequired(false);

            //Publications Constraints
            builder.Entity<Publication>().ToTable("Publications");
            builder.Entity<Publication>().HasKey(p => p.Id);
            builder.Entity<Publication>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Publication>().Property(p => p.DateTime).IsRequired();
            builder.Entity<Publication>().Property(p => p.UserId).IsRequired();
            builder.Entity<Publication>().Property(p => p.PetId).IsRequired();
            builder.Entity<Publication>().Property(p => p.Comment).HasMaxLength(70).IsRequired();

            // Districts
            builder.Entity<District>().ToTable("Districts");
            builder.Entity<District>().HasKey(p => p.Id);
            builder.Entity<District>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<District>().Property(p => p.DistrictName).IsRequired();

            //Subscriptions

            builder.Entity<Subscription>().ToTable("Subscriptions");
            builder.Entity<Subscription>().HasKey(s => s.Id);
            builder.Entity<Subscription>().Property(s => s.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Subscription>().Property(s => s.NumPosts).IsRequired();
            builder.Entity<Subscription>().Property(s => s.StartDate).IsRequired();
            builder.Entity<Subscription>().Property(s => s.EndDate).IsRequired();
            builder.Entity<Subscription>().Property(s => s.UserId).IsRequired();
            builder.Entity<Subscription>().Property(s => s.Expired).IsRequired();



            // District Relationship
            builder.Entity<District>().HasMany(p => p.User)
                .WithOne(p => p.District)
                .HasForeignKey(p => p.DistrictId);
            
            // Pet Relations
            builder.Entity<User>().HasMany(p => p.Pets)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);

            builder.Entity<Pet>().HasOne(p => p.User)
                .WithMany(p => p.Pets)
                .HasForeignKey(p => p.UserId);
            
            //User Relationships
            builder.Entity<User>().HasMany(p => p.Publications)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);

            //Publication Relations
            builder.Entity<Publication>().HasMany(p => p.Pets)
                .WithOne(p => p.Publication)
                .HasForeignKey(p => p.PublicationId);


            //Subscriptions Relations
            builder.Entity<User>().HasOne(u => u.Subscription)
               .WithOne(s => s.User)
               .HasForeignKey<Subscription>(s => s.UserId);
          
          /*  builder.Entity<User>().HasMany(p => p.AdoptionsRequestsList)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserIdAt);

            builder.Entity<Publication>().HasMany(p => p.AdoptionsRequestsList)
                .WithOne(p => p.Publication)
                .HasForeignKey(p => p.PublicationId);
*/
            // builder.Entity<District>().HasData(
            //     new District
            //     {
            //         Id = 1,
            //         DistrictName = "Ventanilla"
            //     },
            //     new District
            //     {
            //         Id = 2,
            //         DistrictName = "San Miguel"
            //     }
            // );
            //
            // builder.Entity<User>().HasData(
            //     new User
            //     {
            //         Id = 1,
            //         Type = "VET",
            //         UserNick = "Frank",
            //         Ruc = "A12345rf",
            //         Dni = "70258688",
            //         Phone = "946401234",
            //         Email = "frank@outlook.com",
            //         Name = "Francisco",
            //         LastName = "Voularte",
            //         DistrictId = 1
            //         //PetId = 100
            //     }
            // );
            //
            // builder.Entity<User>().HasData(
            //     new User
            //     {
            //         Id = 2,
            //         Type = "VET",
            //         UserNick = "Pablo",
            //         Ruc = "",
            //         Dni = "",
            //         Phone = "",
            //         Email = "frank@outlook.com",
            //         Name = "Francisco",
            //         LastName = "Marmol",
            //         DistrictId = 1
            //         //PetId = 100
            //     }
            // );
            //
            // builder.Entity<User>().HasData(
            //     new User
            //     {
            //         Id = 3,
            //         Type = "VET",
            //         UserNick = "Macaco",
            //         Ruc = "101010",
            //         Dni = "101010",
            //         Phone = "987654321",
            //         Email = "frank@outlook.com",
            //         Name = "Macaco",
            //         LastName = "Macaco",
            //         DistrictId = 1
            //         //PetId = 100
            //     }
            // );
            //
            //
            // // Pet Sample Data
            // builder.Entity<Pet>().HasData
            // (
            //     new Pet
            //     {
            //         Id = 100,
            //         Type = "Dog",
            //         Name = "Tito",
            //         Attention = "Required",
            //         Race = "Caninus",
            //         Age = 2,
            //         IsAdopted = true,
            //         UserId = 4,
            //         PublicationId = 2
            //     },
            //     new Pet
            //     {
            //         Id = 101,
            //         Type = "Cat",
            //         Name = "Lolo",
            //         Attention = "Required",
            //         Race = "Catitus",
            //         Age = 2,
            //         IsAdopted = false,
            //         UserId = 4,
            //         PublicationId = 1
            //     },
            //     new Pet
            //     {
            //         Id = 102,
            //         Type = "Cat",
            //         Name = "Lulu",
            //         Attention = "No Required",
            //         Race = "Catitus",
            //         Age = 2,
            //         IsAdopted = false,
            //         UserId = 4,
            //         PublicationId = 1
            //     },
            //     new Pet
            //     {
            //         Id = 103,
            //         Type = "Cat",
            //         Name = "Lulu",
            //         Attention = "No Required",
            //         Race = "Catitus",
            //         Age = 3,
            //         IsAdopted = false,
            //         UserId = 4,
            //         PublicationId = 1
            //     }
            // );
            //
            // //Advertisement Sample Data
            // builder.Entity<Advertisement>().HasData
            // (
            //     new Advertisement
            //     {
            //         Id = 1,
            //         UserId = 1,
            //         DateTime = "29/09/2021 16:20",
            //         Title = "this is a title",
            //         Description = "add description",
            //         Discount = 10,
            //         UrlToImage = "https://www.lasamarillasdezipaquira.com/oc-content/uploads/1/352.jpg",
            //         Promoted = true
            //     }
            // );
            // //User SampleData
            //
            // //Publications SampleData
            // builder.Entity<Publication>().HasData
            // (
            //     new Publication()
            //     {
            //         Id = 1,
            //         UserId = 1,
            //         DateTime = "29/09/2021 16:20",
            //         PetId = 101,
            //         Comment = "this is a comment"
            //     },
            //     new Publication()
            //     {
            //         Id = 2,
            //         UserId = 1,
            //         DateTime = "29/09/2021 16:20",
            //         PetId = 100,
            //         Comment = "this is a comment"
            //     },
            //     new Publication()
            //     {
            //         Id = 3,
            //         UserId = 1,
            //         DateTime = "29/09/2021 16:20",
            //         PetId = -1,
            //         Comment = "this is a comment"
            //     }
            // );

            //AdoptionsRequests SampleData

            // builder.Entity<AdoptionsRequests>().HasData(
            //     new AdoptionsRequests()
            //     {
            //         Id = 1,
            //         Message = "hola",
            //         Status = "pending",
            //         //UserId = -1,
            //         //PublicationId = -1
            //     }
            // );
            // builder.UseSnakeCaseNamingConvention();
        }
    }
}