using FiguraRestaurant.Models;
using Microsoft.AspNetCore.Identity;

namespace FiguraRestaurant.Repositories
{
    public class UserRepository : IUserRepository
    {
        UserDbContext _context;

        public UserRepository(UserDbContext context)
        {
            _context = context;
        }

        public User? Login(string email, string password)
        {
            User? user = _context.Users.FirstOrDefault(x => x.Email == email);

            var hasher = new PasswordHasher<User>();
            var result = hasher.VerifyHashedPassword(user, user.Password, password);

            if (result != PasswordVerificationResult.Success)
            {
                user = null;
            }
            return user;
        }

        public void Register(string name, string email, string password)
        {
            User user = new User { Name = name, Email = email, Password = password };
            var hasher = new PasswordHasher<User>();
            user.Password = hasher.HashPassword(user, user.Password);
            _context.Add(user);
            _context.SaveChanges();
        }

        public User? GetUser(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }
    }
}
