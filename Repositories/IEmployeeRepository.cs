// Repositories/IEmployeeRepository.cs
using EmployeeMgmtSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetAllEmployeesAsync();
    Task<Employee> GetEmployeeByIdAsync(int employeeId);
    Task AddEmployeeAsync(Employee employee);
    Task UpdateEmployeeAsync(Employee employee);
    Task DeleteEmployeeAsync(int employeeId);
}
