
namespace WebApp_netmvc.Models
{
    public interface IStudentRepository
    {
        List<Student> GetStudent();

        Student GetStudentById(int id);
        Student GetStudentByName(string name);
        Student Add(Student student);
        Student Update(Student student);
        void DeleteStudent(int id);
    }
}
