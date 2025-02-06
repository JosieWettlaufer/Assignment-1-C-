using System.ComponentModel.DataAnnotations;

namespace Assigment1.Models
{
    // Defines contact entries in the database
    public class Contact
    {
        //Primey Key
        public int ContactId { get; set; }

        //Sets first name contraints
        [Required(ErrorMessage = "Please enter first name.")]
        public string? FirstName { get; set; }

        //Sets last name constraints
        [Required(ErrorMessage = "Please enter last name.")]
        public string? LastName { get; set; }

        //Sets phone number constraints
        [Required(ErrorMessage = "Please enter phone number.")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone number must be in the format 000-000-0000.")]
        public string? PhoneNumber { get; set; }

        //sets email address contraints
        [Required (ErrorMessage ="Please enter an email address.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string? Email { get; set; }

        //sets category constraints
        [Required(ErrorMessage = "Please enter a category.")]
        public string? CategoryId { get; set; }
        public Category? Category { get; set; }

        public string Slug =>
            FirstName?.Replace(' ', '-').ToLower() + '-' + LastName?.Replace(' ', '-').ToLower();
    }
}
