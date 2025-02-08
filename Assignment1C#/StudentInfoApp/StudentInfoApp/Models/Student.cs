using System.ComponentModel.DataAnnotations;

namespace StudentInfoApp.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage ="please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "please enter an age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "please enter a course")]
        public string Course { get; set; }
    }
}
