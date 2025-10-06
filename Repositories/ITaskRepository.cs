using TaskHub.Api.Models;

namespace TaskHub.Api.Repositories
{
    public interface ITaskRepository
    {
        public TaskItem GetTaskById(int id);
        public IEnumerable<TaskItem> GetTaskByUserId(int userId);
        public TaskItem CreateTask(TaskItem task);
        public void UpdateTask(TaskItem task);
        public void DeleteTask(int id);
    }
}