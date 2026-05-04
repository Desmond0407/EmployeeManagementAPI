using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Data;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementAPI.Repository.Interfaces;

namespace EmployeeManagementAPI.Repository.Implementations
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;


        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetAllAsync() { 

            return await _context.Employees.ToListAsync();       
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            return await _context.Employees.FindAsync(id);
        }

        public async Task AddAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
        }

    }
}
