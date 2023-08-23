namespace WebApp_netmvc.Models
{
    public class StudentRepository : IStudentRepository
    {
        List<Student> _Students=new List<Student>();
        public StudentRepository()
        {
            _Students.Add(new Student() { Id=1101,SName="Manish Kumar",FName="Rameshwar Dass",Class="B.A",Rollno=559,PhoneNo=9992094217,Email="manishKiroriwal2@gmail.com"});
            _Students.Add(new Student() { Id=1102,SName="Karan Rajput",FName="Bholpal singh",Class="Pol.",Rollno=109,PhoneNo=8168022243,Email="KaranRajput@gmail.com"});
            _Students.Add(new Student() { Id=1103,SName="Raman Verma",FName="Indersen",Class="12th",Rollno=4073,PhoneNo=8907267854,Email="ramankararwal98@gmail.com"});
        }
        public Student Add(Student student)
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudent()
        {
            return _Students;
        }

        public Student GetStudentById(int id)
        {
            return _Students.FirstOrDefault(s => s.Id == id);
        }

        public Student GetStudentByName(string name)
        {
            throw new NotImplementedException();
        }

        public Student Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
