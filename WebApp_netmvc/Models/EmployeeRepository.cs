namespace WebApp_netmvc.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> _employees=new List<Employee>();
        public EmployeeRepository() 
        {
            _employees.Add(new Employee() { Id=101,Name="Manish",Department=".net"});
            _employees.Add(new Employee() { Id=102,Name="Raman",Department="Webd"});
            _employees.Add(new Employee() { Id=103,Name="Karan",Department="Webd"});
            _employees.Add(new Employee() { Id=104,Name="Mohit",Department=".net"});
            _employees.Add(new Employee() { Id=105,Name="Aman",Department="Sw"});
        }
        public Employee add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Employee GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
           return _employees;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        void IEmployeeRepository.DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}
