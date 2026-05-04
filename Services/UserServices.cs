using EmployeeManagementAPI.DTOs;
using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Repository.Interfaces;
using BCrypt.Net;

namespace EmployeeManagementAPI.Services
{
    public class UserServices
    {
        private readonly IUserRepository _repo;

        public UserServices(IUserRepository repo)
        {
            _repo = repo; 
        }


        public async Task<string> Register(RegisterDTO dto)
        {
            var existing = await _repo.GetByemailAsync(dto.Email);

            if (existing != null) {

                return "User already Exists";
            }


            var user = new User
            {
                Email = dto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password),
                Role = dto.Role,
                IsActive = true,
                CreatedAt = DateTime.Now
            };


            await _repo.AddUserAsync(user);

            return "User Created Successfully";
        }



        public async Task<string> UpdatePasswordAsyc(UpdateDTO dto)
        {
            var user = await _repo.GetByemailAsync(dto.Email);

            if (user == null)
                return "User not found";

            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password);

            await _repo.UpdatePasswordAsyc(user);

            return "User updated successfully";
        }

    }
}
