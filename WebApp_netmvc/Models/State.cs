namespace WebApp_netmvc.Models
{
    public class State
    {
        public int Id { get; set; }
        public string? SName { get; set; }
        public string? SCode { get; set; }
        public Country? Country{ get; set;}
    }
}
