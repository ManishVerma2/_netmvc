namespace WebApp_netmvc.Models
{
    public interface ICountryRepository
    {
        List<Country> GetAll();
       
        Country GetById(int id);
    }
}
