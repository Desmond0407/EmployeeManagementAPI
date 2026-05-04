using EmployeeManagementAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.DTOs;
using System.Globalization;

namespace EmployeeManagementAPI.Services
{
    public class LoginServices
    {

        private readonly ILoginValidationRepository _repo;
        private readonly AuthServices _auth;

        public LoginServices(ILoginValidationRepository repo, AuthServices auth)
        {
            _repo = repo; 
            _auth = auth;
        }

        public async Task<string?> Login(LoginDTO dto)
        {
            var user = await _repo.Login(dto.Email, dto.Password);

            if (user == null) return null;

            return _auth.GenerateToken(user.Email, user.Role);
        }


    }
}
