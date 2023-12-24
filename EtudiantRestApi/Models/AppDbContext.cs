using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EtudiantRestApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Etudiant> Etudiants { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            // Send Student Table
            modelBuilder.Entity<Etudiant>().HasData(
                new Etudiant
                {
                    EtudiantId = 1,
                    FirstName = "Siber",
                    LastName = "Saint",
                    Email = "siber@yahoo.com",
                    DateOfBirth = new DateTime(2001, 10, 1),
                    Gender = Gender.Male,
                    DepartmentId = 1,
                    PhhotoPath = "Images/siber.png"
                });
            modelBuilder.Entity<Etudiant>().HasData(
                new Etudiant
                {
                    EtudiantId = 2,
                    FirstName = "Doray",
                    LastName = "Saint",
                    Email = "doray@yahoo.com",
                    DateOfBirth = new DateTime(2002, 09, 2),
                    Gender = Gender.Female,
                    DepartmentId = 2,
                    PhhotoPath = "Images/doray.png"
                });

        }  
        
    }
}
