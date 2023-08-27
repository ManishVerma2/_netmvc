namespace WebApp_netmvc.Models
{
    public interface IStateRepository
    {
        List<State> GetAll();
        List<State> GetStateByCountry(int CId);
        State? Get(int id);
    }
}
