using System.Numerics;

namespace WebApp_netmvc.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? SName { get; set; }
        public string? FName { get; set; }
        public string? Class { get; set; }
        public int Rollno { get; set; }
        public long PhoneNo { get; set; }
        public string? Email { get; set; }
    }
}
