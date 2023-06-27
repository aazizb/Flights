using Entities.Models;

namespace Service.Contracts
{
    public interface IFlightService
    {
        IEnumerable<Flight> GetAll(bool trackchanges);
        Flight GetFlightBy(int id, bool trackchanges);
    }
}
