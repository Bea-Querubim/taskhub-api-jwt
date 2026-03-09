namespace TaskHub.Api.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public string? Description { get; set; }

        public TaskStatus Status { get; set; } = TaskStatus.Created;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? FinalDate { get; set; }

        // Foreign Key - User
        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}