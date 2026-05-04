
using EmployeeManagementAPI.DTOs;
using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Repository.Interfaces;



namespace EmployeeManagementAPI.Services
{
    public class EmployeeServices
    {
        private readonly IEmployeeRepository _repo;

        public EmployeeServices(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<EmployeeDTO>> GetAllEmployees()
        {
            var employees = await _repo.GetAllAsync();

            return employees.Select(e => new EmployeeDTO            {
                Employeeid = e.Employeeid,
                Name = e.Name,
                Age = e.Age,
                Email = e.Email,
                Salary = e.Salary,
                Department = e.Department,
                TPT = e.TPT,
                Address = e.Address
            });
        }


    }
}
