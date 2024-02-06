using System.ComponentModel.DataAnnotations;

namespace StudentTeacherQnA.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
