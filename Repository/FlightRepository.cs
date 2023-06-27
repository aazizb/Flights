using Contracts;

using Entities.Models;

namespace Repository
{
    public class FlightRepository : RepositoryBase<Flight>, IFlightRepository
    {
        public FlightRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateFlight(Flight flight)
        {
            Create(flight);
        }

        public void DeleteFlight(Flight flight)
        {
            Delete(flight);
        }

        public Flight GetFlightById(int id, bool trackchanges)
        {
            return FindBy(o => o.Id.Equals(id), trackchanges)
                .SingleOrDefault();
        }

        public IEnumerable<Flight> GetFlights(bool trackchanges)
        {
            return FindAll(trackchanges).OrderBy(o => o.Name).ToList();
        }

        public void UpdateFlight(Flight flight)
        {
            Update(flight);
        }
    }
}
