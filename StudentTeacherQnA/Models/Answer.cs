using System.ComponentModel.DataAnnotations;

namespace StudentTeacherQnA.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        [Required]
        public string Content { get; set; }

        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}
