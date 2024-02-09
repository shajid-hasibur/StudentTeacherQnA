using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace StudentTeacherQnA.Models

{
    
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [Display(Name = "Re-type password")]
        [NotMapped]
        public string ConfirmPassword { get; set; }
        [Required (ErrorMessage = "First name is required")]
        public string FirstName { get; set; }
        [Required (ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        public string InstituteName { get; set; }
        public string InstituteIDCardNumber { get; set; }

        [Required (ErrorMessage = "User Type is required")]
        public string UserType { get; set; }
    }
}
