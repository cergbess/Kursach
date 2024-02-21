using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;
using OrganizingСoncerts_Classes;

namespace OrganizingСoncerts.DAL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<TechRider> TechRiders { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Scene> Scenes { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Concert> Concerts { get; set; }
        public DbSet<PromotionalOffer> PromotionalOffers { get; set; }
        public DbSet<AdvertisingCampaign> AdvertisingCampaigns { get; set; }
        public DbSet<ConcertEmployee> ConcertEmployees { get; set; }
        public DbSet<InvolvementOfConcertEmployee> InvolvementOfConcertEmployees { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
