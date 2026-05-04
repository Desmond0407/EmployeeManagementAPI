using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Data;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementAPI.Repository.Interfaces;

namespace EmployeeManagementAPI.Repository.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context) { 
            _context = context;
        }

        public async Task<User> GetByemailAsync(string email)
        {
            return await _context.Users
                .FirstOrDefaultAsync(x=>x.Email==email);

        }


        public async Task AddUserAsync(User user)
        {
            await _context.Users.AddAsync(user);

            await _context.SaveChangesAsync();
        }


        public async Task UpdatePasswordAsyc(User user)
        {
            _context.Users.Attach(user);
            _context.Entry(user).Property(x => x.PasswordHash).IsModified = true;

            await _context.SaveChangesAsync();
        }

    }
}
