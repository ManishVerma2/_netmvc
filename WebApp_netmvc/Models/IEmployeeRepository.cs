namespace WebApp_netmvc.Models
{
    public interface IEmployeeRepository
    {
        Employee add(Employee employee);
        Employee GetById(int id);
        Employee GetByName(string name);
        List<Employee> GetEmployees();

        Employee UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
    }
}
