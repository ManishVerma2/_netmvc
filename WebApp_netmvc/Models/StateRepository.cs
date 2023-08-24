using System.Xml.Linq;

namespace WebApp_netmvc.Models
{
    public class StateRepository : IStateRepository
    {
        List<State> _states=new List<State>();
        public StateRepository()
        {
            _states.Add(new State() {Id=101,SName="Chandigher",SCode="CHD",Country=new Country() { Id = 1, CName = "India", CCode = "IN" } });
            _states.Add(new State() {Id=102,SName="Delhi",SCode="DL", Country = new Country() { Id = 1, CName = "India", CCode = "IN" } });
            _states.Add(new State() {Id=103,SName="Mumbai",SCode="MB", Country = new Country() { Id = 1, CName = "India", CCode = "IN" } });
            _states.Add(new State() {Id=104,SName="KOlkata",SCode="KL", Country = new Country() { Id = 1, CName = "India", CCode = "IN" } });

            _states.Add(new State() { Id = 105, SName = "Alabama", SCode = "AL",Country=new Country() { Id = 2, CName = "America", CCode = "US" } });
            _states.Add(new State() { Id = 106, SName = "Alaska", SCode = "AK", Country = new Country() { Id = 2, CName = "America", CCode = "US" } });
            _states.Add(new State() { Id = 107, SName = "Colorado", SCode = "CO", Country = new Country() { Id = 2, CName = "America", CCode = "US" } });
            _states.Add(new State() { Id = 108, SName = "Delaware", SCode = "DE", Country = new Country() { Id = 2, CName = "America", CCode = "US" } });

            _states.Add(new State() { Id = 109, SName = "Alberta", SCode = "AB", Country = new Country() { Id = 3, CName = "Canada", CCode = "CA" } });
            _states.Add(new State() { Id = 110, SName = "Manitoba", SCode = "MA", Country = new Country() { Id = 3, CName = "Canada", CCode = "CA" } });
            _states.Add(new State() { Id = 111, SName = "Nova Scotia", SCode = "NS", Country = new Country() { Id = 3, CName = "Canada", CCode = "CA" } });
            _states.Add(new State() { Id = 112, SName = "Yukon", SCode = "YU", Country = new Country() { Id = 3, CName = "Canada", CCode = "CA" } });

            _states.Add(new State() { Id = 113, SName = "Victoria", SCode = "VI" , Country = new Country() { Id = 4, CName = "Australia", CCode = "AU" } });
            _states.Add(new State() { Id = 114, SName = "Queensland", SCode = "QU", Country = new Country() { Id = 4, CName = "Australia", CCode = "AU" } });
            _states.Add(new State() { Id = 115, SName = "Western Australia", SCode = "WAUS", Country = new Country() { Id = 4, CName = "Australia", CCode = "AU" } });
            _states.Add(new State() { Id = 116, SName = "Tasmania", SCode = "TA", Country = new Country() { Id = 4, CName = "Australia", CCode = "AU" } });

        }

        public List<State> GetAll()
        {
            return _states;
        }
    }
}
