using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
namespace Assigment1.Models 
{
    // Define a database context class that inherits from DbContext (EF Core base class)
    public class ContactContext : DbContext
    {
        // Constructor that takes database configuration options and passes them to the base DbContext
        public ContactContext(DbContextOptions<ContactContext> options) : base(options) { }

        // DbSet property that represents the Contacts table in the database
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        //Seeds data into the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Family" },
                new Category { CategoryId = 2, CategoryName = "Work"},
                new Category { CategoryId = 3, CategoryName = "Friend"}

                //more as needed
                );


            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    FirstName = "Delores",
                    LastName = "Del Rio",
                    PhoneNumber = "555-987-6543",
                    Email = "delores@hotmail.com",
                    CategoryId = 1,
                    Organization = null,
                    DateAdded = DateTime.ParseExact("01/30/2008 at 12:42", "MM/dd/yyyy 'at' HH:mm", CultureInfo.InvariantCulture)
                },
            new Contact
            {
                    ContactId = 2,
                    FirstName = "Efren",
                    LastName = "Herrera",
                    PhoneNumber = "555-456-7890",
                    Email = "efren@aol.com",
                    CategoryId = 2,
                    Organization = "WHO",
                    DateAdded = DateTime.ParseExact("02/12/2025 at 10:40", "MM/dd/yyyy 'at' HH:mm", CultureInfo.InvariantCulture)
            },
                new Contact
                {
                    ContactId = 3,
                    FirstName = "Mary Ellen",
                    LastName = "Walton",
                    PhoneNumber = "555-123-4567",
                    Email = "MaryEllen@yahoo.com",
                    CategoryId = 3,
                    Organization = "Disorganized",
                    DateAdded = DateTime.ParseExact("12/20/2020 at 09:00", "MM/dd/yyyy 'at' HH:mm", CultureInfo.InvariantCulture)
                }
            );
        }
    }
}
