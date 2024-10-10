using PulseTask.Models;

namespace PulseTask.IRepository
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmpDTO>> GetAllEmployeesAsync();
        Task<EmpDTO> GetEmployeeByIdAsync(int id);
        Task AddEmployeeAsync(EmpDTO employee);
        Task UpdateEmployeeAsync(EmpDTO employee);
        Task DeleteEmployeeAsync(int id);
        Task<bool> EmployeeExistsAsync(int id);
    }
}
