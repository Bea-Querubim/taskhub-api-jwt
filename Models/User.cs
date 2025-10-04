namespace TaskHub.Api.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public string Email { get; set; }

        public ICollection<TaskItem> Tasks { get; set; }  // 1:N relationship with TaskItem
    }
}