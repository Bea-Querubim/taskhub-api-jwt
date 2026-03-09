namespace TaskHub.Api.Models
{
    public class User
    {
        public int Id { get; set; }

        public required string Username { get; set; }

        public required string PasswordHash { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public required string Email { get; set; }

        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();// 1:N relationship with TaskItem
    }
}