namespace WebApp_netmvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string? DName { get; set; }
        public Country? Country { get; set; }
        public State? State { get; set; }
        public location? Loc { get; set; }
    }
}
