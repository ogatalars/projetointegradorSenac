using System.Linq;
using Projeto.Data;
using Projeto.Models;

namespace Projeto.Services
{
    public class AuthService
    {
        private readonly ApplicationDbContext _context;

        public AuthService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Authenticate(User user)
        {
            var existingUser = _context.Users.SingleOrDefault(u => u.Email == user.Email);
            return existingUser != null && existingUser.Password == user.Password;
        }
    }
}
