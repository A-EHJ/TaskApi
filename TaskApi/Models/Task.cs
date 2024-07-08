using System.ComponentModel.DataAnnotations;

namespace TaskApi.Models
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime DueDate  { get; set; }
        public bool Completed { get; set; }
    }
}
