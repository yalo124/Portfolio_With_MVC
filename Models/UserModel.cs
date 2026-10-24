using System.ComponentModel.DataAnnotations;

namespace Portfolio_With_MVC.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please enter your first name.")]
        public string FirstName {get; set;} = string.Empty;

        [Required(ErrorMessage = "Please enter your last name.")]
        public string LastName{get; set;} = string.Empty;

        [Required(ErrorMessage = "Please enter your course.")]  
        public string Course {get; set;} = string.Empty;

        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email {get; set;} = string.Empty;

    
    }
}