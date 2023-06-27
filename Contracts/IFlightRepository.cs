using Entities.Models;

namespace Contracts
{
    public interface IFlightRepository
    {
        IEnumerable<Flight> GetFlights(bool trackchanges);
    }
}
