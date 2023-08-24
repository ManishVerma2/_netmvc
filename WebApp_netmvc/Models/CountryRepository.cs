namespace WebApp_netmvc.Models
{
    public class CountryRepository : ICountryRepository
    {
        List<Country> _countries=new List<Country>();
        public CountryRepository()
        {
            _countries.Add(new Country() { Id=1,CName="India",CCode="IN"});
            _countries.Add(new Country() { Id=2,CName="America", CCode="US"});
            _countries.Add(new Country() { Id=3,CName="Canada",CCode="CA"});
            _countries.Add(new Country() { Id=4,CName= "Australia", CCode="AU"});
        }
        public List<Country> GetAll()
        {
            return _countries;
        }
        public Country GetById(int id)
        {
            return _countries.FirstOrDefault(c => c.Id == id);
        }
    }
}
