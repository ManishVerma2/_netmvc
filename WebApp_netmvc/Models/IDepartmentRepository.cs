 namespace WebApp_netmvc.Models
{
    public interface IDepartmentRepository
    {
        List<Department> GetDepartments();

        Department GetDepartmentById(int? id);
        Department GetDepartmentByName(string name);
        Department add(Department department);
         void DeleteDepartment(int id);
        Department UpdateDepartment(Department department);
    }
}
