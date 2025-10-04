namespace TaskHub.Api.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string? Description { get; set; }

        public TaskStatus IsCompleted { get; set; } = TaskStatus.Created;

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? FinalDate { get; set; }

        // Foreign Key - User
        public int UserId { get; set; }
        public User User { get; set; }
    }

    public enum TaskStatus
    {
        Created,
        InProgress,
        Paused,
        Cancelled,
        Done
    }
}