namespace WebApp_netmvc.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        List<Department> _departments=new List<Department>();
        public DepartmentRepository()
        {
            _departments.Add(new Department { Id = 10, DName = "SW", Loc = location.Panchkula ,Country=new Country() { Id=1,CName="India",CCode="IN"} });
            _departments.Add(new Department { Id = 20, DName = "HW", Loc = location.Chandigher, Country = new Country() { Id = 1, CName = "India", CCode = "IN" } });
            _departments.Add(new Department { Id = 30, DName = "Sales", Loc = location.Mohali, Country = new Country() { Id = 1, CName = "India", CCode = "IN" } });
            _departments.Add(new Department { Id = 40, DName = "Android", Loc = location.SIRSA, Country = new Country() { Id = 1, CName = "India", CCode = "IN" } });
        }
        public Department add(Department department)
        {
            _departments.Add(department);
            return department;
        }

        public void DeleteDepartment(int id)
        {
            throw new NotImplementedException();
        }

        public Department GetDepartmentById(int? id)
        {
            return _departments.FirstOrDefault(d => d.Id == id);
        }

        public Department GetDepartmentByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetDepartments()
        {
            return _departments;
        }

        public Department UpdateDepartment(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
