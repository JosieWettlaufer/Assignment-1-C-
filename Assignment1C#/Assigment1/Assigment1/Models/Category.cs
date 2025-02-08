using System.ComponentModel.DataAnnotations;

namespace Assigment1.Models
{
    public class Category
    {
        //primary key
        [Range(1, 3, ErrorMessage = "Category ID must be between 1 and 3.")]
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
    }
}
