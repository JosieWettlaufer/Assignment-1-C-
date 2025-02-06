using Microsoft.EntityFrameworkCore; 

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
                new Category { CategoryId = "F", CategoryName = "Family" },
                new Category { CategoryId = "W", CategoryName = "Work"},
                new Category { CategoryId = "R", CategoryName = "Friend"}

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
                    CategoryId = "R"
                },
                new Contact
                {
                    ContactId = 2,
                    FirstName = "Efren",
                    LastName = "Herrera",
                    PhoneNumber = "555-456-7890",
                    Email = "efren@aol.com",
                    CategoryId = "W"
                },
                new Contact
                {
                    ContactId = 3,
                    FirstName = "Mary Ellen",
                    LastName = "Walton",
                    PhoneNumber = "555-123-4567",
                    Email = "MaryEllen@yahoo.com",
                    CategoryId = "F"
                }
            );
        }
    }
}
