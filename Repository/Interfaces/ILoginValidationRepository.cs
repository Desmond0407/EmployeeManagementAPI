using EmployeeManagementAPI.Data;
using EmployeeManagementAPI.Models;

namespace EmployeeManagementAPI.Repository.Interfaces
{
    public interface ILoginValidationRepository
    {
        Task<User?> Login (string email, string password);

    }
}
