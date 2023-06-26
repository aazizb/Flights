using Contracts;

using Entities.Models;

namespace Repository
{
    public class FlightRepository : RepositoryBase<Flight>, IFlightRepository
    {
        public FlightRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
