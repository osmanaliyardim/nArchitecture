using Core.Security.Entities;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistence.Contexts
{
    public class BaseDbContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
       
        public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //    base.OnConfiguring(
            //        optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SomeConnectionString")));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Generally, complex softwares include different namings in DB,
            // so that we have to indicate these rows here explicitly
            // otherwise, it might cause many conflicts in your DB.
            modelBuilder.Entity<Brand>(a =>
            {
                a.ToTable("Brands").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.Name).HasColumnName("Name");

                // A brand can contain more than one model.
                a.HasMany(p => p.Models);
            });

            modelBuilder.Entity<Model>(a =>
            {
                a.ToTable("Models").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.BrandId).HasColumnName("BrandId");
                a.Property(p => p.Name).HasColumnName("Name");
                a.Property(p => p.DailyPrice).HasColumnName("DailyPrice");
                a.Property(p => p.ImageUrl).HasColumnName("ImageUrl");

                // A model can only contain one brand.
                a.HasOne(p => p.Brand);
            });

            // Seed data for car brands
            Brand[] brandEntitySeeds = { new(1, "BMW"), new(2, "TOGG") };
            modelBuilder.Entity<Brand>().HasData(brandEntitySeeds);

            // Seed data for car models
            Model[] modelEntitySeeds = 
            { 
                new(1, 1, "Series 1", 1500, ""),
                new(2, 1, "Series 3", 2350, ""),
                new(3, 1, "Series 4", 3300, ""),
                new(4, 1, "Series 5", 3150, ""),
                new(5, 1, "Series 7", 4775, ""),
                new(6, 2, "Aksungur", 2680, ""),
                new(7, 2, "Gokbey", 5110, ""),
            };
            modelBuilder.Entity<Model>().HasData(modelEntitySeeds);
        }
    }
}
