using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace StudentTeacherQnA.Models

{
    
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string Name { get; set; }
        public string InstituteName { get; set; }
        public string InstituteIDCardNumber { get; set; }
    }
}
