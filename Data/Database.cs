using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MertKaymaz_HW5.Data;

namespace MertKaymaz_HW5.Data { 

    public class Database : DbContext
    {
        string connectionString = @"Server=.\sqlexpress;Database=Database;Trusted_Connection=True;";
        public DbSet<CetUser> CetUsers { get; set; }
        public DbSet<CetRole> CetRoles {get; set;}
        public Database() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(connectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CetUser>().HasData(
                new CetUser
                {
                    Id = 1,
                    Name = "Mert",
                    Surname = "Kaymaz",
                    UserName = "admin",
                    Password = new Service.CetUserService().hashPassword("admin"),
                    CreatedDate = DateTime.Now,
                    role = "Admin"
                    
                }
            );
        }
    }
}
