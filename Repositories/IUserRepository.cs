using TaskHub.Api.Models;

namespace TaskHub.Api.Repositories
{
    public interface IUserRepository
    {
        User GetUserById(int id);
        User GetUserByUsername(string username);
        User GetUserByEmailAndPassword(string email, string password);

        User CreateUser(User user);

        void UpdateUser(User user); //

        void DeleteUser(int id);
        void DeleteUser(string email);
    }
}
