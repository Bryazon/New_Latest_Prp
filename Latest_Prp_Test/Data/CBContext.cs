using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication7.Data.Entities;
using WebApplication7.Data.Entities.EnumTypes;

namespace WebApplication7.Data
{
    public class CBContext : IdentityDbContext<SystemUserLogin>
    {
        public DbSet<PropertyContact> PropertyContacts { get; set; }
        public DbSet<PropertyImage> PropertyImages { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMembership> TeamMemberships { get; set; } 
        public DbSet<SystemUserImage> SystemUserImages { get; set; }
        public DbSet<SystemUser> SystemUsers { get; set; }

        public CBContext(DbContextOptions<CBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contact>().OwnsOne(c => c.Address);
            modelBuilder.Entity<Property>().OwnsOne(p => p.Address);
            modelBuilder.Entity<SystemUser>().OwnsOne(u => u.Address);
            modelBuilder.Entity<Team>().OwnsOne(t => t.Address);
            modelBuilder.Entity<Organisation>().OwnsOne(o => o.Address);

            modelBuilder.Entity<Property>().Property(p => p.Status).HasConversion(
                p => p.Value,
                p => PropertyStatus.FromValue(p));
        }

    }
}
