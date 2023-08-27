using System.Xml.Linq;

namespace WebApp_netmvc.Models
{
    public class StateRepository : IStateRepository
    {
        List<State> _states=new List<State>();
        public StateRepository()
        {
            _states.Add(new State() { Id=1,SName="Haryana",SCode="HR",CId=1});
            _states.Add(new State() { Id=2,SName="Rajsthan",SCode="RJ",CId=1});
            _states.Add(new State() { Id=3,SName="Punjab",SCode="PB",CId=1});
            _states.Add(new State() { Id=4,SName= "Alabama", SCode="AL",CId=2});
            _states.Add(new State() { Id=5,SName= "California", SCode="CF",CId=2});
            _states.Add(new State() { Id=6,SName= "New York", SCode="NY",CId=2});
            _states.Add(new State() { Id=7,SName= "Ontario", SCode="OT",CId=3});
            _states.Add(new State() { Id=8,SName= "Manitoba", SCode="MA",CId=3});
            _states.Add(new State() { Id=9,SName= "Victoria", SCode="VI",CId=4});
            _states.Add(new State() { Id=10,SName= "Queensland", SCode="QL",CId=4});
        }
        public List<State> GetAll()
        {
            return _states;
        }

        public List<State> GetStateByCountry(int CId)
        {
           return _states.FindAll(e=>e.CId== CId);
        }

        public State? Get(int id)
        {
            return _states.FirstOrDefault(e => e.Id == id);
        }
    }
}
