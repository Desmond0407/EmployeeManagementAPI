using EmployeeManagementAPI.Models;

namespace EmployeeManagementAPI.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllAsync();
        Task<Employee> GetByIdAsync(int id);

      

        Task AddAsync(Employee employee);

    }
   
}
