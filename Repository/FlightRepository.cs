using Contracts;

using Entities.Models;

namespace Repository
{
    public class FlightRepository : RepositoryBase<Flight>, IFlightRepository
    {
        public FlightRepository(RepositoryContext context) : base(context)
        {
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
    }
}
