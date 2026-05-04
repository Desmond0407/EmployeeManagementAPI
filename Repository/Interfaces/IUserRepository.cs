using EmployeeManagementAPI.Models;
namespace EmployeeManagementAPI.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetByemailAsync(string email);

        Task AddUserAsync(User user);

        Task UpdatePasswordAsyc(User user);
    }
}
