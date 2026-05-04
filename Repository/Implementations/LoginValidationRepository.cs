using EmployeeManagementAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using EmployeeManagementAPI.Repository.Interfaces;
using EmployeeManagementAPI.Models;


namespace EmployeeManagementAPI.Repository.Implementations
{
    public class LoginValidationRepository : ILoginValidationRepository
    {
        private readonly AppDbContext _context;

        public LoginValidationRepository(AppDbContext context) { 

            _context = context;
        }

        public async Task<User?> Login(string email, string password)
        {
            var user = await _context.Users
         .FirstOrDefaultAsync(x => x.Email == email && x.IsActive);

            if (user == null) return null;

            var valid = BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
            if (!valid) return null;

            return user;

        }

    }
}
