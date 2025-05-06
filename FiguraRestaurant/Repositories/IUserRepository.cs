using FiguraRestaurant.Models;

namespace FiguraRestaurant.Repositories
{
    public interface IUserRepository
    {
        User? GetUser(int id);
        User? Login(string email, string password);
        void Register(string name, string email, string password);
    }
}