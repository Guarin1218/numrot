using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Helpers
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {

        }
       
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().ToTable("roles");
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<Gender>().ToTable("genders");

           
        }
       

    }
}

