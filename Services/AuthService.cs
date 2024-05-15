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

        public bool Register(User user)
        {
            if (_context.Users.Any(u => u.Email == user.Email))
            {
                // Usuário com o mesmo email já existe
                return false;
            }

            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }
    }
}
